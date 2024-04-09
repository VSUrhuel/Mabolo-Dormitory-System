using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Xunit.Sdk;


namespace Mabolo_Dormitory_System.Classes
{
    public class DatabaseManager
    {
        public List<User> Users { get; private set; }
        public List<Department> Departments { get; private set; }
        public List<Room> Rooms { get; private set; }
        public List<EventAttendance> EventAttendances { get; private set; }
        public List<Event> Events { get; private set; }
        public List<Payment> Payments { get; private set; }
        public List<RoomAllocation> RoomAllocations { get; private set; }
        public List<RegularPayable> RegularPayable { get; private set; }
        public List<UserPayable> UserPayables { get; private set; }

        private String con;
        public DatabaseManager()
        {
            this.con = "server=127.0.0.1;port=3306;uid=root;pwd=Laurente1234.";
            Users = new List<User>();
            Departments = new List<Department>();
            Rooms = new List<Room>();
            RegularPayable = new List<RegularPayable>();
            EventAttendances = new List<EventAttendance>();
            Events = new List<Event>();
            Payments = new List<Payment>();
            RoomAllocations = new List<RoomAllocation>();
            UserPayables = new List<UserPayable>();
        }

        // Sign In Account
        public bool CheckAdminEmailExists(String email)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE Email = @Email", connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return true;
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("There was an error while checking admin email");
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public bool AdminPassReset(String email, String password)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE Email = @Email", connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["ImageData"] != DBNull.Value)
                                {
                                    String query = "UPDATE system.account SET Password = @Password WHERE Email = @Email";
                                    MySqlCommand command2 = new MySqlCommand(query, connection);
                                    command2.Parameters.AddWithValue("@Email", email);
                                    command2.Parameters.AddWithValue("@Password", password);
                                    command2.ExecuteNonQuery();
                                }
                                else
                                {
                                    String query = "INSERT INTO system.account(Password) VALUES (@Password) WHERE Email = @Email";
                                    MySqlCommand command2 = new MySqlCommand(query, connection);
                                    command2.Parameters.AddWithValue("@Email", email);
                                    command2.Parameters.AddWithValue("@Password", password);
                                    command2.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    return true;
                }
                catch
                {
                    MessageBox.Show("There was an error while resetting password");
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public List<User> GetUsersTypeWithoutRoom(String userType)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Users.Clear();
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.user WHERE UserType = @UserType AND UserId NOT IN (SELECT FK_UserId_RoomAllocation FROM system.room_allocation)", connection))
                    {
                        command.Parameters.AddWithValue("@UserType", userType);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
                            }
                        }
                    }
                    return Users;
                }
                catch
                {
                    MessageBox.Show("There was an error while retrieving users without room");
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
        
        public String GetUserNameOfAdmin(String email)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE Email = @Email", connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            String name = "";
                            while (reader.Read())
                            {
                                name = (string)reader["UserName"];
                            }
                            return name;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("There was an error while retrieving admin name");
                }
                finally
                {
                    connection.Close();
                }
            }
            return "";
        }

        public Account GetAccount(String email)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE Email = @Email", connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Account account = null;
                            while (reader.Read())
                            {
                                account = new Account((string)reader["Email"], (string)reader["UserName"], (string)reader["Password"], (DateTime)reader["Birthday"], (string)reader["FirstName"], (string)reader["LastName"], (byte[])reader["ImageData"]);
                            }
                            return account;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("There was an error while retrieving account");
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
      
        public void UpdateAccount(String email, String userName, String password, DateTime birthday, String firstName, String lastName, byte[] imageDate)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE Email = @Email", connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["ImageData"] != DBNull.Value)
                                {
                                    String query = "UPDATE system.account SET UserName = @UserName, Password = @Password, Birthday = @Birthday, FirstName = @FirstName, LastName = @LastName, ImageData = @ImageData WHERE Email = @Email";
                                    MySqlCommand command2 = new MySqlCommand(query, connection);
                                    command2.Parameters.AddWithValue("@Email", email);
                                    command2.Parameters.AddWithValue("@UserName", userName);
                                    command2.Parameters.AddWithValue("@Password", password);
                                    command2.Parameters.AddWithValue("@Birthday", birthday);
                                    command2.Parameters.AddWithValue("@FirstName", firstName);
                                    command2.Parameters.AddWithValue("@LastName", lastName);
                                    command2.Parameters.AddWithValue("@ImageData", imageDate);
                                    command2.ExecuteNonQuery();
                                }
                                else
                                {
                                    String query = "INSERT INTO system.account(ImageData) VALUES (@ImageData) WHERE Email = @Email";
                                    MySqlCommand command2 = new MySqlCommand(query, connection);
                                    command2.Parameters.AddWithValue("@Email", email);
                                    command2.Parameters.AddWithValue("@ImageData", imageDate);
                                    command2.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("There was an error while updating account");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
       
        public bool AccountExist(String email, String password)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE Email = @Email AND Password = @Password", connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return true;
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("There was an error while checking account");
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }

        public void AddPicture(String email, byte[] image)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE Email = @Email", connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["ImageData"] != DBNull.Value)
                                {
                                    String query = "UPDATE system.account SET ImageData = @ImageData WHERE Email = @Email";
                                    MySqlCommand command2 = new MySqlCommand(query, connection);
                                    command2.Parameters.AddWithValue("@Email", email);
                                    command2.Parameters.AddWithValue("@ImageData", image);
                                    command2.ExecuteNonQuery();
                                }
                                else
                                {
                                    String query = "INSERT INTO system.account(ImageData) VALUES (@ImageData) WHERE Email = @Email";
                                    MySqlCommand command2 = new MySqlCommand(query, connection);
                                    command2.Parameters.AddWithValue("@Email", email);
                                    command2.Parameters.AddWithValue("@ImageData", image);
                                    command2.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("There was an error while adding picture");
                }
                finally
                {
                    connection.Close();
                }
                
            }
        }
        
        // Users
        public List<User> GetAllUsersExcpetAdmin()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Users.Clear();
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.user WHERE UserType NOT IN ('Dormitory Adviser', 'Assistant Dormitory Adviser');", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
                            }
                        }
                    }
                    return Users;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving users: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
       
        public List<User> GetAllUsers()
        {
            Users.Clear();
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.user", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
                            }
                        }
                    }
                    return Users;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving users: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
        
        public bool AddUser(User user)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO system.user(UserId, FirstName, LastName, Birthday, Email, PhoneNumber, Address, UserStatus, UserType, FK_DepartmentId) VALUES (@UserId, @FirstName, @LastName, @Birthday, @Email, @PhoneNumber, @Address, @UserStatus, @UserType, @DepartmentId)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", user.UserId);
                        command.Parameters.AddWithValue("@FirstName", user.FirstName);
                        command.Parameters.AddWithValue("@LastName", user.LastName);
                        command.Parameters.AddWithValue("@Birthday", user.Birthday);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                        command.Parameters.AddWithValue("@Address", user.Address);
                        command.Parameters.AddWithValue("@UserStatus", user.UserStatus);
                        command.Parameters.AddWithValue("@UserType", user.UserType);
                        command.Parameters.AddWithValue("@DepartmentId", user.FK_DepartmentId);

                        command.ExecuteNonQuery();
                    }

                    AddUserPayable(user.UserId);

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while adding user: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }

        public bool UpdateUser(User user)
        {
            Users = GetAllUsers();
            if (!UserExists(user.UserId))
                throw new ArgumentException("User does not exist");

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                string query = "UPDATE system.user SET FirstName = @FirstName, LastName = @LastName, Birthday = @Birthday, Email = @Email, PhoneNumber = @PhoneNumber, Address = @Address, UserStatus = @UserStatus, UserType = @UserType, FK_DepartmentId = @DepartmentId WHERE UserId = @UserId";
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", user.UserId);
                        command.Parameters.AddWithValue("@FirstName", user.FirstName);
                        command.Parameters.AddWithValue("@LastName", user.LastName);
                        command.Parameters.AddWithValue("@Birthday", user.Birthday);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                        command.Parameters.AddWithValue("@Address", user.Address);
                        command.Parameters.AddWithValue("@UserStatus", user.UserStatus);
                        command.Parameters.AddWithValue("@UserType", user.UserType);
                        command.Parameters.AddWithValue("@DepartmentId", user.FK_DepartmentId);

                        command.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while updating user: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;

        }

        public User GetUser(String userId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.user WHERE UserId = @UserId", connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            User user = null;
                            while (reader.Read())
                            {
                                user = new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]);
                            }
                            return user;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving user: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
       
        public bool UserHasDormer(List<User> users)
        {
            foreach (User user in users)
            {
                if (user.UserType == "Regular Dormer" || user.UserType == "Big Brod" || user.UserType == "Student Assistant")
                    return true;
            }
            return false;
        }

        public bool DeleteUser(String userId)
        {
            Users = GetAllUsers();
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    DeleteUserRoomAllocation(userId);
                    DeletUserPayable(userId);
                    DeleteUserPayment(userId);
                    DeleteUserAllEventAttendance(userId);
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM system.user WHERE UserId = @UserId", connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while deleting user: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                } 
            }
            return false;
        }
      
        public bool UserExists(string userId)
        {
            List<User> u = new List<User>();
            u = GetAllUsers();
            foreach (User user in Users)
            {
                if (user.UserId == userId)
                {
                    return true;
                }
            }
            return false;
        }

        // Room Allocation
        public List<RoomAllocation> GetAllRoomAllocations()
        {
            RoomAllocations.Clear();
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.room_allocation", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                RoomAllocations.Add(new RoomAllocation((int)reader["RoomAllocationId"], (DateTime)reader["StartDate"], (DateTime)reader["EndDate"], (int)reader["FK_RoomId_RoomAllocation"], (string)reader["FK_UserId_RoomAllocation"], true));
                            }
                        }
                    }
                    return RoomAllocations;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving room allocations: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }            
            }
            return null;
        }
      
        public bool DeleteUserRoomAllocation(String userId)
        {
            if(!UserAllocated(userId))
            {
                MessageBox.Show(userId + " does not have a room yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Room r = GetUserRoom(userId);
                    r.DecreaseOccupants(1);
                    UpdateRoomSize(r.RoomId, r.CurrNumOfOccupants);
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM system.room_allocation WHERE FK_UserId_RoomAllocation = @FK_UserId_RoomAllocation", connection))
                    {
                        command.Parameters.AddWithValue("@FK_UserId_RoomAllocation", userId);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while deleting user's room allocation: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public bool UserAllocated(String userId)
        {
            RoomAllocations = GetAllRoomAllocations();
            foreach (RoomAllocation ra in RoomAllocations)
            {
                if (ra.FK_UserId_RoomAllocation == userId)
                    return true;
            }
            return false;
        }

        // Rooms
        public Room GetRoom(int roomId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.room WHERE RoomId = @RoomId", connection))
                    {
                        command.Parameters.AddWithValue("@RoomId", roomId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Room room = null;
                            while (reader.Read())
                            {
                                room = new Room((int)reader["RoomId"], (int)reader["LevelNumber"], (int)reader["MaximumCapacity"], (int)reader["CurrNumOfOccupants"]);
                            }
                            return room;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving room: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }            
            }
            return null;
        }

        public List<Room> GetAllRooms()
        {
            Rooms.Clear();
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.room", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Rooms.Add(new Room((int)reader["RoomId"], (int)reader["LevelNumber"], (int)reader["MaximumCapacity"], (int)reader["CurrNumOfOccupants"]));
                            }
                        }
                    }
                    return Rooms;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving rooms: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
        
        public List<User> GetUsersInRoom(int roomId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Users.Clear();
                    String sql = "SELECT* FROM system.user u INNER JOIN system.room_allocation t ON u.UserId = t.FK_UserId_RoomAllocation WHERE t.FK_RoomId_RoomAllocation = @RoomId;";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@RoomId", roomId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
                            }
                        }
                    }
                    return Users;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving users in room: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }             
            }
            return null;
        }
        
        public void UpdateRoomSize(int roomId, int n)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    String query = "UPDATE system.room SET CurrNumOfOccupants = @n WHERE RoomId = @RoomId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomId", roomId);
                        command.Parameters.AddWithValue("@n", n);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while updating room size: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                } 
            }
        }
      
        public bool RoomHasBigBrod(int roomId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    String sql = "SELECT * FROM system.user u INNER JOIN system.room_allocation t ON u.UserId = t.FK_UserId_RoomAllocation WHERE t.FK_RoomId_RoomAllocation = @RoomId AND UserType = 'Big Brod';";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@RoomId", roomId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while checking if room has Big Brod: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public int CountBigBrod(int roomId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    String query = "SELECT * FROM system.user u INNER JOIN system.room_allocation t ON u.UserId = t.FK_UserId_RoomAllocation WHERE t.FK_RoomId_RoomAllocation = @RoomId AND UserType = 'Big Brod';";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomId", roomId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int count = 0;
                            while (reader.Read())
                            {
                                count++;
                            }
                            return count;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while counting Big Brods: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return -1;
        }
        
        public bool AddUserInRoom(int roomId, String userId)
        {
            if (roomId < 0 || roomId > 9)
                throw new ArgumentException("Invalid Room Id");
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            if (UserAllocated(userId))
            {
                MessageBox.Show(userId + " already had a room.\nClick the edit button if you want to change its room.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            Rooms = GetAllRooms();
            if (!Rooms[roomId - 1].CanIncreaseOccupancy(1) || UserAllocated(userId))
            {
                MessageBox.Show("Room is already full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                { 
                    string query = "INSERT INTO system.room_allocation(RoomAllocationId, StartDate, EndDate, FK_RoomId_RoomAllocation, FK_UserId_RoomAllocation) VALUES (@RoomAllocationId, @StartDate, @EndDate, @FK_RoomId_RoomAllocation, @FK_UserId_RoomAllocation)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        List<RoomAllocation> ra = GetAllRoomAllocations();
                        int index = 1;
                        if (ra.Count != 0)
                            index = ra[ra.Count - 1].RoomAllocationId + 1;
                        command.Parameters.AddWithValue("@RoomAllocationId", index);
                        command.Parameters.AddWithValue("@StartDate", DateTime.Now);
                        command.Parameters.AddWithValue("@EndDate", DateTime.Now.AddMonths(1));
                        command.Parameters.AddWithValue("@FK_RoomId_RoomAllocation", roomId);
                        command.Parameters.AddWithValue("@FK_UserId_RoomAllocation", userId);
                        command.ExecuteNonQuery();

                        UpdateRoomSize(roomId, Rooms[roomId - 1].CurrNumOfOccupants);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while adding user in room: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public bool UpdateUserRoom(int prevRoomId, int newRoomId, String userId)
        {
            if ((prevRoomId < 0 || prevRoomId > 9) || (newRoomId < 0 || newRoomId > 9))
                throw new ArgumentException("Invalid Room Id");
            Rooms = GetAllRooms();
            if (!Rooms[newRoomId - 1].CanIncreaseOccupancy(1))
            {
                MessageBox.Show("Room is already full", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(!UserAllocated(userId))
            {
                MessageBox.Show(userId + " does not have a room yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(CountBigBrod(newRoomId) == 1 && GetUser(userId).UserType == "Big Brod" && newRoomId != 4)
            {
                MessageBox.Show("This room already has a Big Brod assigned.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(newRoomId == 4 && CountBigBrod(newRoomId) > 1 && GetUser(userId).UserType == "Big Brod")
            {
                MessageBox.Show("Room 4 already has 2 Big Brods.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    String query = "UPDATE system.room_allocation SET FK_RoomId_RoomAllocation = @FK_RoomId_RoomAllocation WHERE FK_UserId_RoomAllocation = @FK_UserId_RoomAllocation";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FK_RoomId_RoomAllocation", newRoomId);
                        command.Parameters.AddWithValue("@FK_UserId_RoomAllocation", userId);
                        command.ExecuteNonQuery();
                        Rooms[prevRoomId - 1].DecreaseOccupants(1);
                        UpdateRoomSize(prevRoomId, Rooms[prevRoomId - 1].CurrNumOfOccupants);
                        UpdateRoomSize(newRoomId, Rooms[newRoomId - 1].CurrNumOfOccupants);

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while updating user's room: " + ex.Message);
                }
                               finally
                {
                    connection.Close();
                }
            }
            return false;
        }

        // Department
        public List<Department> GetAllDepartments()
        {
            Departments.Clear();
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.department", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Departments.Add(new Department((int)reader["DepartmentId"], (string)reader["DepartmentName"], (string)reader["CollegeName"]));
                            }
                        }
                    }
                    return Departments;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving departments: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }

        public Department GetUserDepartment(String userId)
        {
            Department d = null;
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    String sql = "SELECT * FROM system.department WHERE DepartmentId = (SELECT FK_DepartmentId FROM system.user WHERE UserId = @UserId)";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                d = new Department((int)reader["DepartmentId"], (string)reader["DepartmentName"], (string)reader["CollegeName"]);
                            }
                        }
                    }
                    return d;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving user's department: " + ex.Message);
                }
                               finally
                {
                    connection.Close();
                }
            }
            return null;
        }

        public Room GetUserRoom(String userId)
        {
            Room r = null;
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    String sql = "SELECT * FROM system.room WHERE RoomId = (SELECT FK_RoomId_RoomAllocation FROM system.room_allocation WHERE FK_UserId_RoomAllocation = @FK_UserId_RoomAllocation)";
                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FK_UserId_RoomAllocation", userId);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                r = new Room((int)reader["RoomId"], (int)reader["LevelNumber"], (int)reader["MaximumCapacity"], (int)reader["CurrNumOfOccupants"]);
                            }
                        }
                    }
                    return r;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving user's room: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }

        // Events
        public int GetLastEventId()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT MAX(EventId) FROM system.event", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return (int)reader["MAX(EventId)"];
                            }
                        }
                    }
                }
                catch 
                {
                    return 0;
                }
                finally
                {
                    connection.Close();
                }
            }
            return -1;
        }
        
        public List<Event> GetAllEvents()
        {
            Events.Clear();
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.event", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Events.Add(new Event((int)reader["EventId"], (string)reader["EventName"], (DateTime)reader["EventDate"], (DateTime)reader["EventTime"], (String)reader["Location"], (String)reader["Description"], reader.GetBoolean("HasPayables"), (float)reader["AttendanceFineAmount"], (float)reader["EventFeeContribution"], true));
                            }
                        }
                    }
                    return Events;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving events: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
        
        public bool AddEvent(Event e)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                string query = "INSERT INTO system.event(";
                PropertyInfo[] properties = e.GetType().GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (i < properties.Length - 1)
                        query += properties[i].Name + ", ";
                    else
                        query += properties[i].Name + ") ";
                }
                query += "VALUES (";
                for (int i = 0; i < properties.Length; i++)
                {
                    if (i < properties.Length - 1)
                        query += "@" + properties[i].Name + ", ";
                    else
                        query += "@" + properties[i].Name + ")";
                }
                MySqlCommand command = new MySqlCommand(query, connection);

                foreach (PropertyInfo property in properties)
                {
                    object value = property.GetValue(e);
                    if (property.Name.Equals("EventTime"))
                        command.Parameters.AddWithValue("@" + property.Name, DateTime.Parse(e.EventTime));
                    else
                        command.Parameters.AddWithValue("@" + property.Name, value);
                }
                command.ExecuteNonQuery();
                RecordDefaultAttendace(e.EventId);
                return true;
            }
        }
     
        public bool UpdateEvent(Event e)
        {
            Events = GetAllEvents();
            if (!EventExists(e.EventId))
                throw new ArgumentException("Event does not exist");
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    float fines = GetEvent(e.EventId).AttendanceFineAmount;
                    String query = "UPDATE system.event SET ";
                    PropertyInfo[] properties = e.GetType().GetProperties();
                    for (int i = 0; i < properties.Length; i++)
                    {
                        query += properties[i].Name + " = @" + properties[i].Name;
                        if (i < properties.Length - 1)
                            query += ", ";
                    }
                    query += " WHERE EventId = @EventId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EventId", e.EventId);
                    foreach (PropertyInfo property in properties)
                    {
                        object value = property.GetValue(e);
                        if (property.Name.Equals("EventTime"))
                            command.Parameters.AddWithValue("@" + property.Name, DateTime.Parse(e.EventTime));
                        else if (!property.Name.Equals("EventId"))
                            command.Parameters.AddWithValue("@" + property.Name, value);
                    }
                    command.ExecuteNonQuery();
                    if (e.AttendanceFineAmount != fines)
                    {
                        AdddEventFineUserPayable(e.AttendanceFineAmount - fines);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while updating event: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public bool DeleteEvent(int eventId)
        {
            Events = GetAllEvents();
            if (!EventExists(eventId))
                throw new ArgumentException("Event does not exist");
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    SubtractEventFineUserPayable(GetEvent(eventId).AttendanceFineAmount, eventId);
                    String query = "DELETE FROM system.event WHERE EventId = @EventId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EventId", eventId);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while deleting event: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }

        public List<Event> GetMonthlyEvent()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Events.Clear();
                    DateTime currentDate = DateTime.Now;

                    string sql = $"SELECT * FROM system.event WHERE MONTH(EventDate) = {currentDate.Month} AND YEAR(EventDate) = {currentDate.Year}";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Events.Add(new Event(reader.GetInt32("EventId"), reader.GetString("EventName"), reader.GetDateTime("EventDate"), reader.GetDateTime("EventTime"), reader.GetString("Location"), reader.GetString("Description"), reader.GetBoolean("HasPayables"), reader.GetFloat("AttendanceFineAmount"), reader.GetFloat("EventFeeContribution"), true));
                        }
                    }
                    return Events;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving monthly events: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }

        public Event GetEvent(int eventId)
        {
            if (!EventExists(eventId))
                throw new ArgumentException("Event does not exist");
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.event WHERE EventId = @EventId", connection))
                    {
                        command.Parameters.AddWithValue("@EventId", eventId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return new Event((int)reader["EventId"], (string)reader["EventName"], (DateTime)reader["EventDate"], (DateTime)reader["EventTime"], (String)reader["Location"], (String)reader["Description"], reader.GetBoolean("HasPayables"), (float)reader["AttendanceFineAmount"], (float)reader["EventFeeContribution"], true);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving event: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
        
        public bool EventExists(int eventId)
        {
            Events = GetAllEvents();
            foreach (Event e in Events)
            {
                if (e.EventId == eventId)
                {
                    return true;
                }
            }
            return false;
        }

        // Event Attendance
        public List<EventAttendance> GetEventAttendances()
        {
            EventAttendances.Clear();
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.event_attendance", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EventAttendances.Add(new EventAttendance((int)reader["EventAttendanceId"], (string)reader["AttendanceStatus"], (string)reader["FK_UserId_EventAttendance"], (int)reader["FK_EventId_EventAttendance"]));
                            }
                        }
                    }
                    return EventAttendances;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving event attendances: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }

        public void RecordDefaultAttendace(int eventId)
        {
            if(!EventExists(eventId))
                throw new ArgumentException("Event does not exist");
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Users.Clear();
                    Users = GetAllUsers();

                    for (int i = 0; i < Users.Count; i++)
                    {
                        RecordAttendance(Users[i].UserId, eventId, "Absent");
                        AddUserPayable(Users[i].UserId, GetEvent(eventId).AttendanceFineAmount);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while recording default attendance: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        
        public bool RecordAttendance(String userId, int eventId, String status)
        {
            if (!EventExists(eventId) || !UserExists(userId))
                return false;
            if (EventAttendanceExists(eventId, userId))
            {
                if (UpdateAttendance(userId, eventId, status))
                    return true;
                return false;
            }
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO system.event_attendance(EventAttendanceId, AttendanceStatus, FK_UserId_EventAttendance, FK_EventId_EventAttendance) VALUES (@EventAttendanceId, @AttendanceStatus, @FK_UserId_EventAttendance, @FK_EventId_EventAttendance)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        List<EventAttendance> ea = GetEventAttendances();
                        int index = 1;
                        if(ea.Count > 0)
                            index = ea.ElementAt(ea.Count() - 1).EventAttendanceId + 1;
                        command.Parameters.AddWithValue("@EventAttendanceId", index);
                        command.Parameters.AddWithValue("@AttendanceStatus", status);
                        command.Parameters.AddWithValue("@FK_UserId_EventAttendance", userId);
                        command.Parameters.AddWithValue("@FK_EventId_EventAttendance", eventId);
                        command.ExecuteNonQuery();

                        if (status == "Present")
                            UpdateUserPayable(userId, GetEvent(eventId).AttendanceFineAmount);
                       
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while recording attendance: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public EventAttendance GetUserEventAttendance(int eventId, String userId)
        {
            if (!EventExists(eventId) || !UserExists(userId))
                return null;
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.event_attendance WHERE FK_EventId_EventAttendance = @FK_EventId_EventAttendance AND FK_UserId_EventAttendance = @FK_UserId_EventAttendance", connection))
                    {
                        command.Parameters.AddWithValue("@FK_EventId_EventAttendance", eventId);
                        command.Parameters.AddWithValue("@FK_UserId_EventAttendance", userId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                 return new EventAttendance((int)reader["EventAttendanceId"], (string)reader["AttendanceStatus"], (string)reader["FK_UserId_EventAttendance"], (int)reader["FK_EventId_EventAttendance"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving user's event attendance: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
        
        public bool UpdateAttendance(String userId, int eventId, String status)
        {
            String origStatus = GetUserEventAttendance(eventId, userId).AttendanceStatus;
            if (!EventExists(eventId) || !UserExists(userId) || !EventAttendanceExists(eventId, userId))
                return false;
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("UPDATE system.event_attendance SET AttendanceStatus = @AttendanceStatus WHERE FK_UserId_EventAttendance = @FK_UserId_EventAttendance AND FK_EventId_EventAttendance = @FK_EventId_EventAttendance", connection))
                    {
                        command.Parameters.AddWithValue("@AttendanceStatus", status);
                        command.Parameters.AddWithValue("@FK_UserId_EventAttendance", userId);
                        command.Parameters.AddWithValue("@FK_EventId_EventAttendance", eventId);
                        command.ExecuteNonQuery();
                    }
                    if(origStatus == "Absent" && status == "Present")
                            UpdateUserPayable(userId, GetEvent(eventId).AttendanceFineAmount);
                    else if(origStatus == "Present" && status == "Absent")
                            AddUserPayable(userId, GetEvent(eventId).AttendanceFineAmount); 
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while updating event attendance: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public List<EventAttendance> GetEventAttendances(int eventId)
        {
            if(!EventExists(eventId))
                throw new ArgumentException("Event does not exist");
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.event_attendance WHERE FK_EventId_EventAttendance = @FK_EventId_EventAttendance", connection))
                    {
                        command.Parameters.AddWithValue("@FK_EventId_EventAttendance", eventId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            EventAttendances.Clear();
                            while (reader.Read())
                            {
                                EventAttendances.Add(new EventAttendance((int)reader["EventAttendanceId"], (string)reader["AttendanceStatus"], (string)reader["FK_UserId_EventAttendance"], (int)reader["FK_EventId_EventAttendance"]));
                            }
                        }
                    }
                    return EventAttendances;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving event attendances: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
       
        public void AdddEventFineUserPayable(float eventFines)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("UPDATE system.user_payable AS up INNER JOIN system.event_attendance AS ea ON up.FK_UserId_UserPayable = ea.FK_UserId_EventAttendance SET up.RemainingBalance = up.RemainingBalance + @RemainingBalance WHERE ea.AttendanceStatus = 'Absent';", connection))
                    {
                        command.Parameters.AddWithValue("@RemainingBalance", eventFines);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding event fine to user payable: " + ex.Message);
                } 
                finally
                {
                    connection.Close();
                }
            }
        }
        
        public bool DeleteUserAllEventAttendance(String userI)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM system.event_attendance WHERE FK_UserId_EventAttendance = @FK_UserId_EventAttendance", connection))
                    {
                        command.Parameters.AddWithValue("@FK_UserId_EventAttendance", userI);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting user's event attendance: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public bool EventAttendanceExists(int eventId, string userId)
        {
            EventAttendances = GetEventAttendances();
            foreach (EventAttendance ea in EventAttendances)
            {
                if (ea.FK_EventId_EventAttendance == eventId && ea.FK_UserId_EventAttendance == userId)
                {
                    return true;
                }
            }
            return false;
        }

        // Payments
        public List<Payment> GetAllPayment()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.payment;", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Payments.Clear();
                            while (reader.Read())
                            {
                                Payments.Add(new Payment((int)reader["PaymentId"], (DateTime)reader["PaymentDate"], (float)reader["Amount"], (string)reader["Remarks"], (string)reader["FK_UserId_Payment"]));
                            }
                        }
                    }
                    return Payments;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving Payments: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
      
        public bool AddPayment(Payment p)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("INSERT INTO system.payment(PaymentId, PaymentDate, Amount, Remarks, FK_UserId_Payment) VALUES (@PaymentId, @PaymentDate, @Amount, @Remarks, @FK_UserId_Payment)", connection))
                    {
                        command.Parameters.AddWithValue("@PaymentId", p.PaymentId);
                        command.Parameters.AddWithValue("@PaymentDate", p.PaymentDate);
                        command.Parameters.AddWithValue("@Amount", p.Amount);
                        command.Parameters.AddWithValue("@Remarks", p.Remarks);
                        command.Parameters.AddWithValue("@FK_UserId_Payment", p.FK_UserId_Payment);
                        command.ExecuteNonQuery();
                        UpdateUserPayable(p.FK_UserId_Payment, p.Amount);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding payment: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                
            }
            return false;
        }
        
        public bool DeleteUserPayment(String userId)
        {
            if(!UserPaymentExists(userId))
                throw new ArgumentException("User does not have any payment");
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM system.payment WHERE FK_UserId_Payment = @FK_UserId_Payment", connection))
                    {
                        command.Parameters.AddWithValue("@FK_UserId_Payment", userId);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting user's payment: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public List<Payment> GetAllUserPayments(String userId)
        {
            if(!UserExists(userId))
                throw new ArgumentException("User does not exist");
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Payments.Clear();
                    String sql = "SELECT * FROM system.payment WHERE FK_UserId_Payment = @FK_UserId_Payment";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FK_UserId_Payment", userId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Payments.Add(new Payment((int)reader["PaymentId"], (DateTime)reader["PaymentDate"], (float)reader["Amount"], (string)reader["Remarks"], (string)reader["FK_UserId_Payment"]));
                            }
                        }
                        return Payments;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving user's payments: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
        
        public float GetSumUserPayments(String userId)
        {
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    float sum = 0;
                    string sql = "SELECT * FROM system.payment WHERE FK_UserId_Payment = @FK_UserId_Payment";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FK_UserId_Payment", userId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sum += (float)reader["Amount"];
                            }
                        }
                    }
                    return sum;
                }
                catch  
                {
                    return 0;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool UserPaymentExists(String userId)
        {
            Payments = GetAllPayment();
            foreach (Payment p in Payments)
            {
                if (p.FK_UserId_Payment == userId)
                {
                    return true;
                }
            }
            return false;
        }   
        
        // Regular Payables
        public bool AddRegularPayable(RegularPayable regularPayable)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO system.regular_payable(RegularPayableId, Name, Amount) VALUES (@RegularPayableId, @Name, @Amount)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RegularPayableId", regularPayable.RegularPayableId);
                        command.Parameters.AddWithValue("@Name", regularPayable.Name);
                        command.Parameters.AddWithValue("@Amount", regularPayable.Amount);

                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding RegularPayable: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
           
        }
        
        public List<RegularPayable> GetRegularPayables()
        {
            RegularPayable.Clear();

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT * FROM system.regular_payable;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                RegularPayable.Add(new RegularPayable((int)reader["RegularPayableId"], (string)reader["Name"], (float)reader["Amount"]));
                            }
                        }
                    }

                    return RegularPayable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving RegularPayable: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }

        public void UpdateRegularPayable(RegularPayable regularPayable)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                string query = "UPDATE system.regular_payable SET Name = @Name, Amount = @Amount WHERE RegularPayableId = @RegularPayableId";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RegularPayableId", regularPayable.RegularPayableId);
                    command.Parameters.AddWithValue("@Name", regularPayable.Name);
                    command.Parameters.AddWithValue("@Amount", regularPayable.Amount);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
      
        public RegularPayable GetRegularPayable(int id)
        {
            if (!RegularPayableExists(id))
                throw new ArgumentException("Regular Payable does not exist");

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT * FROM system.regular_payable WHERE RegularPayableId = @RegularPayablesId";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@RegularPayablesId", id);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            RegularPayable rp = null;

                            if (reader.Read())
                            {
                                rp = new RegularPayable((int)reader["RegularPayableId"], (string)reader["Name"], (float)reader["Amount"]);
                            }
                            return rp;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving RegularPayable: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;

        }

        public void DeleteRegularPayable(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    SubtractEventFineUserPayable(GetRegularPayable(id).Amount);
                    string query = "DELETE FROM system.regular_payable WHERE RegularPayableId = @RegularPayableId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RegularPayableId", id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting RegularPayable: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        
        public bool RegularPayableExists(int id)
        {
            RegularPayable = GetRegularPayables();
            foreach (RegularPayable rp in RegularPayable)
            {
                if (rp.RegularPayableId == id)
                {
                    return true;
                }
            }
            return false;
        }
        
        // User Payable
        public bool AddUserPayable(String userId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO system.user_payable(UserPayableId, RemainingBalance, FK_UserId_UserPayable) VALUES (@UserPayableId, @RemainingBalance, @FK_UserId_UserPayable)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        List<UserPayable> up = GetAllUserPayable();
                        int index = up[up.Count - 1].UserPayableId + 1;
                        float remainingBalance = GetSumEvents() + (GetSumRegularPayable() * 5);

                        command.Parameters.AddWithValue("@UserPayableId", index);
                        command.Parameters.AddWithValue("@RemainingBalance", remainingBalance);
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);

                        command.ExecuteNonQuery();
                    }

                    return true;
                }
                catch
                (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding UserPayable: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public List<UserPayable> GetAllUserPayable()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    UserPayables.Clear();
                    string sql = "SELECT * FROM system.user_payable;";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UserPayables.Add(new UserPayable((int)reader["UserPayableId"], (float)reader["RemainingBalance"], (string)reader["FK_UserId_UserPayable"]));
                    }
                    reader.Close();

                    return UserPayables;
                }
                catch
                (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving UserPayable: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
       
        public UserPayable GetUserPayable(string userId)
        {
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                string sql = "SELECT * FROM system.user_payable WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable LIMIT 1";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userPayableId = (int)reader["UserPayableId"];
                            float remainingBalance = (float)reader["RemainingBalance"];
                            string fkUserIdUserPayable = (string)reader["FK_UserId_UserPayable"];

                            return new UserPayable(userPayableId, remainingBalance, fkUserIdUserPayable);
                        }
                    }
                }
            }
            return null;
        }

        public float GetUserPayableBalance(string userId)
        {
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT RemainingBalance FROM system.user_payable WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable LIMIT 1";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                        try
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    return reader.GetFloat("RemainingBalance");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while retrieving UserPayable balance: " + ex.Message);
                        }
                    }
                    return 0;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void UpdateUserPayable(String userId, float Amount)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    float updatedAmount = 0;
                    string query = "UPDATE system.user_payable SET RemainingBalance = @updatedAmount WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    updatedAmount = GetUserPayableBalance(userId) - Amount;
                    if (updatedAmount < 0)
                        updatedAmount = 0;

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@updatedAmount", updatedAmount);
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (NullException)
                {
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating UserPayable: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
       
        public void AddUserPayable(String userId, float Amount)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    float updatedAmount = 0;
                    string query = "UPDATE system.user_payable SET RemainingBalance = @updatedAmount WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    updatedAmount = GetUserPayableBalance(userId) + Amount;
                    float max = GetSumEvents() + GetSumRegularPayable() * 5;
                    if (updatedAmount > max)
                        updatedAmount = max;

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@updatedAmount", updatedAmount);
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    return;
                }   
                finally
                {
                    connection.Close();
                }
            }
        }
       
        public float GetSumRemainingBalance()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    float sum = 0;
                    string query = "SELECT SUM(RemainingBalance) AS SumAmount FROM system.user_payable;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                sum = reader.GetFloat("SumAmount");
                        }
                    }
                    return sum;
                }
                catch
                {
                    return 0;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        
        public void LoadUserPayable(String userId)
        {
            if (!UserPayableExists(userId))
            {
                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    connection.Open();
                    try
                    {
                        string query = "INSERT INTO system.user_payable(UserPayableId, RemainingBalance, FK_UserId_UserPayable) SELECT @UserPayableId, @RemainingBalance, UserID FROM system.user WHERE UserID = @FK_UserId_UserPayable AND UserType NOT IN('Dormitory Adviser', 'Assistant Dormitory Adviser');";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        List<UserPayable> up = GetAllUserPayable();
                        int index = 1;
                        if (up.Count == 0)
                            index = 1;
                        else if (up.Count > 0)
                            index = up[GetAllUserPayable().Count - 1].UserPayableId + 1;
                        float remainingBalance = 0;
                        command.Parameters.AddWithValue("@UserPayableId", index);
                        remainingBalance = GetSumEvents() + (GetSumRegularPayable() * 5);
                        command.Parameters.AddWithValue("@RemainingBalance", remainingBalance);
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        return;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
                UpdateUserLoadPayable(userId, GetSumEvents() + (GetSumRegularPayable() * 5));
        }
        
        public float GetSumPresentAttendances(String userId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    float sum = 0;
                    string query = "SELECT SUM(AttendanceFineAmount) AS TotalEventFees FROM system.event WHERE EventId IN (SELECT FK_EventId_EventAttendance FROM system.event_attendance WHERE FK_UserId_EventAttendance = @FK_UserId_EventAttendance AND AttendanceStatus = 'Present');";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FK_UserId_EventAttendance", userId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                sum = reader.GetFloat("TotalEventFees");
                            }
                        }
                    }
                    return sum;
                }
                catch
                {
                    return 0;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        
        public void LoadUsersPayable()
        {
            Users.Clear();
            Users = GetAllUsersExcpetAdmin();
            foreach (User u in Users.ToList())
            {
                if (!UserPayableExists(u.UserId))
                {
                    using (MySqlConnection connection = new MySqlConnection(con))
                    {
                        connection.Open();
                        try
                        {
                            string query = "INSERT INTO system.user_payable(UserPayableId, RemainingBalance, FK_UserId_UserPayable) SELECT @UserPayableId, @RemainingBalance, UserID FROM system.user WHERE UserID = @FK_UserId_UserPayable AND UserType NOT IN('Dormitory Adviser', 'Assistant Dormitory Adviser');";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                List<UserPayable> up = GetAllUserPayable();
                                int index = 1;
                                if (up.Count > 0)
                                    index = up[GetAllUserPayable().Count - 1].UserPayableId + 1;
                                float remainingBalance = 0;
                                command.Parameters.AddWithValue("@UserPayableId", index);
                              
                                remainingBalance = GetSumEvents() + (GetSumRegularPayable() * 5) - GetSumUserPayments(u.UserId) - GetSumPresentAttendances(u.UserId);
                                if(remainingBalance < 0)
                                {
                                    remainingBalance = 0;
                                }
                                command.Parameters.AddWithValue("@RemainingBalance", remainingBalance);
                                command.Parameters.AddWithValue("@FK_UserId_UserPayable", u.UserId);
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (NullException)
                        {
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error while loading UserPayable: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
                else
                {
                    UpdateAddPayable(u.UserId);
                }
            }

        }
        
        public void UpdateAddPayable(string userId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "UPDATE system.user_payable SET RemainingBalance = @RemainingBalance WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    float balance = GetSumEvents() + (GetSumRegularPayable() * 5) - GetSumUserPayments(userId) - GetSumPresentAttendances(userId); 

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RemainingBalance", balance);
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (NullException)
                {
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating UserPayable: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        
        public void UpdateUserLoadPayable(String userId, float updatedAmount)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "UPDATE system.user_payable SET RemainingBalance = @updatedAmount WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@updatedAmount", updatedAmount);
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (NullException)
                {
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred updating the UserPayable: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        
        public bool DeletUserPayable(String userId)
        {
            if (!UserPayableExists(userId))
                return false;
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "DELETE FROM system.user_payable WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the UserPayable: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
        
        public bool UserPayableExists(String userId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    UserPayables = GetAllUserPayable();
                    foreach (UserPayable up in UserPayables)
                    {
                        if (up.FK_UserId_UserPayable == userId)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception ex)
                {
                     MessageBox.Show("An error occurred while checking if UserPayable exists: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
       
        // Operations
        public float GetSumEvents()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    float sum = 0;
                    string sql = "SELECT SUM(AttendanceFineAmount) AS TotalEventFees FROM system.event;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        try
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    sum = reader.GetFloat("TotalEventFees");
                                }
                            }
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                    return sum;
                }
                catch
                {
                    return 0;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        
        public float GetSumRegularPayable()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    float sum = 0;
                    string sql = "SELECT SUM(Amount) FROM system.regular_payable;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                sum = reader.GetFloat(0);
                            }
                        }
                    }
                    return sum;
                }
                catch
                {
                    return 0;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void SubtractEventFineUserPayable(float fines)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "UPDATE system.user_payable AS up INNER JOIN system.event_attendance AS ea ON up.FK_UserId_UserPayable = ea.FK_UserId_EventAttendance SET up.RemainingBalance = up.RemainingBalance - @RemainingBalance WHERE ea.AttendanceStatus = 'Absent'; ";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RemainingBalance", fines);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void SubtractEventFineUserPayable(float fines, int eventId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "UPDATE system.user_payable AS up INNER JOIN system.event_attendance AS ea ON up.FK_UserId_UserPayable = ea.FK_UserId_EventAttendance SET up.RemainingBalance = up.RemainingBalance - @RemainingBalance WHERE ea.AttendanceStatus = 'Absent' AND ea.FK_EventId_EventAttendance = @eventId; ";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RemainingBalance", fines);
                    command.Parameters.AddWithValue("@eventId", eventId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<User> GetPaidUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Users.Clear();
                    List<User> u = new List<User>();
                    string sql = "SELECT * FROM system.user_payable WHERE RemainingBalance = 0 AND FK_UserId_UserPayable NOT IN (SELECT UserId FROM system.user  WHERE UserType IN ('Dormitory Adviser', 'Assistant Dormitory Adviser'));";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                u.Add(GetUser((string)reader["FK_UserId_UserPayable"]));
                            }
                        }
                    }
                    return u;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        
        public List<User> GetPendingUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    Users.Clear();
                    List<User> u = new List<User>();
                    string sql = "SELECT * FROM system.user_payable WHERE RemainingBalance > 0 AND FK_UserId_UserPayable NOT IN (SELECT UserId FROM system.user WHERE UserType IN ('Dormitory Adviser', 'Assistant Dormitory Adviser'));";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                u.Add(GetUser((string)reader["FK_UserId_UserPayable"]));
                            }
                        }
                    }
                    return u;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
