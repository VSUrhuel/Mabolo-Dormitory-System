using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


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
        public Account Account { get; private set; }

        private String con;
        public DatabaseManager()
        {
            string server = Environment.GetEnvironmentVariable("MYSQL_SERVER");
            string uid = Environment.GetEnvironmentVariable("MYSQL_USERNAME");
            string pwd = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");

            this.con = $"server={server};port=3306;uid={uid};pwd={pwd}";
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
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE FK_UserId_Account = (SELECT UserId FROM system.user WHERE Email = @email)", connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
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
                    MessageBox.Show("There was an error while checking admin email:" + ex.Message);
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
                    List<string> userIds = new List<string>();
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE FK_UserId_Account = (SELECT UserId FROM system.user WHERE Email = @Email)", connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                userIds.Add(reader["FK_UserId_Account"].ToString());
                            }
                        }
                    }

                    foreach (string userId in userIds)
                    {
                        String query = "UPDATE system.account SET Password = @Password WHERE FK_UserId_Account = @UserId";
                        using (MySqlCommand command2 = new MySqlCommand(query, connection))
                        {
                            command2.Parameters.AddWithValue("@UserId", userId);
                            command2.Parameters.AddWithValue("@Password", password);
                            command2.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while resetting password: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }


        public Account GetAccount(String email)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE FK_UserId_Account = (SELECT UserId FROM system.user WHERE Email = @email)", connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Account account = null;
                            while (reader.Read())
                            {
                                byte[] imageData = null;
                                if (reader["ImageData"] != DBNull.Value)
                                {
                                    imageData = (byte[])reader["ImageData"];
                                }
                                else
                                {
                                    SetPicture(email);
                                }

                                account = new Account((int)reader["AccountId"], (string)reader["UserName"], (string)reader["Password"], (string)reader["FK_UserId_Account"], imageData);
                            }
                            return account;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving account: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }

        public void SetPicture(string email)
        {
            byte[] imageData = File.ReadAllBytes("C:\\Users\\LENOVO\\source\\repos\\Mabolo-Dormitory-System\\Mabolo-Dormitory-System\\Resources\\profile.png");

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();

                string query = "UPDATE system.account SET ImageData = @ImageData WHERE FK_UserId_Account = (SELECT UserId FROM system.user WHERE Email = @Email)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@ImageData", imageData);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool UpdateAccount(String email, String userName, String password, DateTime birthday, String firstName, String lastName, byte[] imageDate)
        {
            MySqlConnection connection = new MySqlConnection(con);
            
            using (MySqlConnection cnn = new MySqlConnection(con))
            {
                cnn.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE FK_UserId_Account = (SELECT UserId FROM system.user WHERE Email = @email)", cnn))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["ImageData"] != DBNull.Value)
                                {
                                    String query = "UPDATE system.account SET UserName = @UserName, Password = @Password, ImageData = @ImageData WHERE FK_UserId_Account = (SELECT UserId FROM system.user WHERE Email = @email)";
                                    MySqlCommand command2 = new MySqlCommand(query, connection);
                                    connection.Open();
                                    command2.Parameters.AddWithValue("@email", email);
                                    command2.Parameters.AddWithValue("@UserName", userName);
                                    command2.Parameters.AddWithValue("@Password", password);

                                    User u = GetUser((string)reader["FK_UserId_Account"]);
                                    UpdateUser(new User(u.UserId, firstName, lastName, birthday, u.Email, u.PhoneNumber, u.Address, u.AvailWiFi, u.HasLaptop, u.HasPrinter, u.UserStatus, u.UserType, u.FK_DepartmentId));

                                    command2.Parameters.AddWithValue("@ImageData", imageDate);
                                    command2.ExecuteNonQuery();
                                    return true;
                                }
                                else
                                {
                                    String query = "INSERT INTO system.account(ImageData) VALUES (@ImageData) WHERE FK_UserId_Account = (SELECT UserId FROM system.user WHERE Email = @email)";
                                    connection.Open();
                                    MySqlCommand command2 = new MySqlCommand(query, connection);
                                    command2.Parameters.AddWithValue("@email", email);
                                    command2.Parameters.AddWithValue("@ImageData", imageDate);
                                    command2.ExecuteNonQuery();
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an errwor while updating account: " + ex.Message);
                    return false;
                }
                finally
                {
                    cnn.Close();
                    connection.Close();
                }
            }
            return false;
        }
       
        public bool AccountExist(String email, String password)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.account WHERE Password = @Password AND FK_UserId_Account = (SELECT UserId FROM system.user WHERE Email = @email)", connection))
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
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while checking account: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
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
                                Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (int)reader["AvailWiFi"], (int)reader["HasLaptop"], (int)reader["HasPrinter"],(string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
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
                                Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (int)reader["AvailWiFi"], (int)reader["HasLaptop"], (int)reader["HasPrinter"],(string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
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
            if(EmailExists(user.Email))
            {
                MessageBox.Show("Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO system.user(UserId, FirstName, LastName, Birthday, Email, PhoneNumber, Address, AvailWiFi, HasLaptop, HasPrinter, UserStatus, UserType, FK_DepartmentId) VALUES (@UserId, @FirstName, @LastName, @Birthday, @Email, @PhoneNumber, @Address, @AvailWiFi,  @HasLaptop, @HasPrinter, @UserStatus, @UserType, @DepartmentId)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", user.UserId);
                        command.Parameters.AddWithValue("@FirstName", user.FirstName);
                        command.Parameters.AddWithValue("@LastName", user.LastName);
                        command.Parameters.AddWithValue("@Birthday", user.Birthday);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                        command.Parameters.AddWithValue("@Address", user.Address);
                        command.Parameters.AddWithValue("@AvailWiFi", user.AvailWiFi);
                        command.Parameters.AddWithValue("HasLaptop", user.HasLaptop);
                        command.Parameters.AddWithValue("HasPrinter", user.HasPrinter);
                        command.Parameters.AddWithValue("@UserStatus", user.UserStatus);
                        command.Parameters.AddWithValue("@UserType", user.UserType);
                        command.Parameters.AddWithValue("@DepartmentId", user.FK_DepartmentId);


                        command.ExecuteNonQuery();
                    }
                    if(user.UserType != "Dormitory Adviser" && user.UserType != "Assistant Dormitory Adviser")
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
            if(EmailExists(user.Email) && GetUser(user.UserId).Email != user.Email)
            {
                MessageBox.Show("Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            User u = GetUser(user.UserId);
            int prevAvailWiFi = u.AvailWiFi;

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                string query = "UPDATE system.user SET FirstName = @FirstName, LastName = @LastName, Birthday = @Birthday, Email = @Email, PhoneNumber = @PhoneNumber, Address = @Address, AvailWiFi = @AvailWiFi, HasLaptop = @HasLaptop, HasPrinter = @HasPrinter,UserStatus = @UserStatus, UserType = @UserType, FK_DepartmentId = @DepartmentId WHERE UserId = @UserId";
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
                        command.Parameters.AddWithValue("AvailWiFi", user.AvailWiFi);
                        command.Parameters.AddWithValue("HasLaptop", user.HasLaptop);
                        command.Parameters.AddWithValue("HasPrinter", user.HasPrinter);
                        command.Parameters.AddWithValue("@UserStatus", user.UserStatus);
                        command.Parameters.AddWithValue("@UserType", user.UserType);
                        command.Parameters.AddWithValue("@DepartmentId", user.FK_DepartmentId);

                        command.ExecuteNonQuery();
                        if (user.AvailWiFi == 1)
                        {
                            AddUserPayable(user.UserId, (300 * 5));
                            return true;
                        }
                        else if (user.AvailWiFi == 0 && prevAvailWiFi == 1)
                            UpdateUserPayable(user.UserId, (300 * 5)); 
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
                                user = new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (int)reader["AvailWiFi"], (int)reader["HasLaptop"], (int)reader["HasPrinter"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]);
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
                                Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (int)reader["AvailWiFi"], (int)reader["HasLaptop"], (int)reader["HasPrinter"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
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
                    if(GetUser(userId).UserType != "Dormitory Adviser" && GetUser(userId).UserType != "Assistant Dormitory Adviser")
                    {
                        DeleteUserRoomAllocation(userId);
                        DeletUserPayable(userId);
                        DeleteUserPayment(userId);
                        DeleteUserAllEventAttendance(userId);
                    }
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
      
        public bool EmailExists(String email)
        {
            Users = GetAllUsers();
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    return true;
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
                                Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (int)reader["AvailWiFi"], (int)reader["HasLaptop"], (int)reader["HasPrinter"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
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
                        int ctr = 0;
                        command.Parameters.AddWithValue("@RoomId", roomId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ctr++;
                            }
                        }
                        if(ctr == 1 && roomId != 4)
                            return true;
                        else if(ctr == 2 && roomId == 4)
                            return true;
                        else
                            return false;
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
                            UpdateUserPayable(userId, GetEvent(eventId).AttendanceFineAmount, true);
                       
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

        public UserPayable GetUserPayable(String UserId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.user_payable WHERE FK_UserId_UserPayable = @UserId", connection))
                    {
                        command.Parameters.AddWithValue("@UserId", UserId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            UserPayable user = null;
                            while (reader.Read())
                            {
                                user = new UserPayable((int)reader["UserPayableId"], (float)reader["TotalPayable"], (float)reader["RemainingBalance"], (String)reader["FK_UserId_UserPayable"]);
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
        public bool AddPayment(Payment p)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("INSERT INTO system.payment(PaymentId, PaymentDate, Amount, Remarks, FK_UserId_Payment) VALUES (@PaymentId, @PaymentDate, @Amount, @Remarks, @FK_UserId_Payment)", connection))
                    {
                        UserPayable u = GetUserPayable(p.FK_UserId_Payment);
                        float amountVal = 0;
                        if (u.RemainingBalance < p.Amount)
                            amountVal = u.RemainingBalance;
                        else
                            amountVal = p.Amount;
                        command.Parameters.AddWithValue("@PaymentId", p.PaymentId);
                        command.Parameters.AddWithValue("@PaymentDate", p.PaymentDate);
                        command.Parameters.AddWithValue("@Amount", amountVal);
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
            if (!UserPaymentExists(userId))
                return false;
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
       
        // User Payable
        public bool AddUserPayable(String userId)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO system.user_payable(UserPayableId, TotalPayable, RemainingBalance,  FK_UserId_UserPayable) VALUES (@UserPayableId, @TotalPayable, @RemainingBalance, @FK_UserId_UserPayable)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        List<UserPayable> up = GetAllUserPayable();
                        int index = up[up.Count - 1].UserPayableId + 1;
                        float totalPayable = GetSumEvents() + (270 * 5);
                        float remainingBalance;

                        User u = GetUser(userId);
                        if(u.AvailWiFi == 1)
                            totalPayable += (300 * 5);
                        if (u.HasLaptop == 1)
                            totalPayable += (30 * 5);
                        if (u.HasPrinter == 1)
                            totalPayable += (30 * 5);
                        remainingBalance = totalPayable;

                        command.Parameters.AddWithValue("@UserPayableId", index);
                        command.Parameters.AddWithValue("@TotalPayable", totalPayable);
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
                        UserPayables.Add(new UserPayable((int)reader["UserPayableId"], (float)reader["TotalPayable"], (float)reader["RemainingBalance"], (string)reader["FK_UserId_UserPayable"]));
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

        public float GetTotalPayable(string userId)
        {
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    string sql = "SELECT TotalPayable FROM system.user_payable WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable LIMIT 1";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                        try
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    if(reader.GetFloat("TotalPayable") <= 0)
                                    {
                                        float pay = GetSumEvents() + (270 * 5);
                                        if(GetUser(userId).AvailWiFi == 1)
                                            pay += (300 * 5);
                                        if (GetUser(userId).HasLaptop == 1)
                                            pay += (30 * 5);
                                        if (GetUser(userId).HasPrinter == 1)
                                            pay += (30 * 5);
                                        return pay;

                                    }
                                    return reader.GetFloat("TotalPayable");
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
        public void UpdateUserPayable(String userId, float Amount, bool data)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    float updatedAmount = 0;
                    string query = "UPDATE system.user_payable SET RemainingBalance = @updatedAmount, TotalPayable = @totalPayable WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    updatedAmount = GetUserPayableBalance(userId) - Amount;
                    if (updatedAmount < 0)
                        updatedAmount = 0;

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@updatedAmount", updatedAmount);
                        command.Parameters.AddWithValue("@totalPayable", GetTotalPayable(userId)-Amount);
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
                    float updatedAmount = 0, updatedTotal = 0;
                    string query = "UPDATE system.user_payable SET RemainingBalance = @updatedAmount, TotalPayable = @totalPayable WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    updatedAmount = GetUserPayableBalance(userId) + Amount;
                    updatedTotal = GetTotalPayable(userId) + Amount;
                    if(updatedAmount == 0)
                        updatedAmount = Amount;
                    

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@updatedAmount", updatedAmount);
                        command.Parameters.AddWithValue("@totalPayable", updatedTotal);
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

        public float GetAllSumPresentAttendances()
        {
            try
            {
                float sum = 0;
                EventAttendances.Clear();
                EventAttendances = GetEventAttendances();
                foreach(EventAttendance ea in EventAttendances)
                {
                    if (ea.AttendanceStatus == "Present")
                    {
                        sum += GetEvent(ea.FK_EventId_EventAttendance).AttendanceFineAmount;
                    }
                }
                return sum;
            }
            catch
            {
                return 0;
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
                            string query = "INSERT INTO system.user_payable(UserPayableId, TotalPayable, RemainingBalance, FK_UserId_UserPayable) SELECT @UserPayableId, @TotalPayable, @RemainingBalance, UserID FROM system.user WHERE UserID = @FK_UserId_UserPayable AND UserType NOT IN('Dormitory Adviser', 'Assistant Dormitory Adviser');";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                List<UserPayable> up = GetAllUserPayable();
                                int index = 1;
                                if (up.Count > 0)
                                    index = up[GetAllUserPayable().Count - 1].UserPayableId + 1;
                                float remainingBalance = 0;
                                command.Parameters.AddWithValue("@UserPayableId", index);
                              
                                remainingBalance = GetTotalPayable(u.UserId);
                                if(remainingBalance < 0)
                                {
                                    remainingBalance = 0;
                                }
                                command.Parameters.AddWithValue("@RemainingBalance", remainingBalance);
                                command.Parameters.AddWithValue("@TotalPayable", GetTotalPayable(u.UserId));
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
                    string query = "UPDATE system.user_payable SET RemainingBalance = @RemainingBalance, TotalPayable = @TotalPayable WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    float balance = GetSumEvents() + (270 * 5) - GetSumUserPayments(userId) - GetSumPresentAttendances(userId);
                    float totalPayable = GetTotalPayable(userId);
                    if (GetUser(userId).AvailWiFi == 1)
                    {
                        balance += (300 * 5);
                    }
                    if (GetUser(userId).HasLaptop == 1)
                    {
                        balance += (30 * 5);
                    }
                    if (GetUser(userId).HasPrinter == 1)
                    {
                        balance += (30 * 5);
                    }
                    if (balance < 0)
                        balance = 0;
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RemainingBalance", balance);
                        command.Parameters.AddWithValue("@TotalPayable", totalPayable);
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

        public float GetAllSumPayments()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    float sum = 0;
                    string sql = "SELECT SUM(Amount) FROM system.payment;";

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

        public float GetSumTotalPayable()
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                try
                {
                    float sum = 0;
                    string sql = "SELECT SUM(TotalPayable) FROM system.user_payable;";

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
