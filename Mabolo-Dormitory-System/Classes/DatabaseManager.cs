using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;


namespace Mabolo_Dormitory_System.Classes
{
    public class DatabaseManager
    {
        MySqlConnection Connection;
        public List<User> Users { get; private set; }
        public List<Department> Departments { get; private set; }
        public List<Room> Rooms { get; private set; }
        public List<EventAttendance> EventAttendances { get; private set; }
        public List<Event> Events { get; private set; }
        public List<Payment> Payments { get; private set; }
        public List<RoomAllocation> RoomAllocations { get; private set; }
        public List<RegularPayable> RegularPayable { get; private set; }
        public List<UserPayable> UserPayables { get; private set; }

        public DatabaseManager()
        {
            EstablishConnection();
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

        public bool EstablishConnection()
        {
            if (Connection?.State != ConnectionState.Open)
            {
                string con = "server=127.0.0.1;port=3306;uid=root;pwd=Laurente1234.";
                Connection = new MySqlConnection(con);
                try
                {
                    Connection.Open();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error opening connection: " + e.Message);
                    return false;
                }
            }
            return true;
        }

        // Sign In Account
        public bool CheckAdminEmailExists(String email)
        {
            if (EstablishConnection())
            {
                String sql = "SELECT * FROM system.account WHERE Email = @Email";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@Email", email);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return true;
                }
                reader.Close();
                
                return false;
            }
            return false;
        }
        
        public bool AdminPassReset(String email, String password)
        {
            if (EstablishConnection())
            {
                String query = "UPDATE system.account SET Password = @Password WHERE Email = @Email";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.ExecuteNonQuery();
                
                return true;
            }
            return false;
        }
        
        public List<User> GetUsersTypeWithoutRoom(String userType)
        {
            if (EstablishConnection())
            {
                Users.Clear();
                String sql = "SELECT * FROM system.user WHERE UserType = @UserType AND UserId NOT IN (SELECT FK_UserId_RoomAllocation FROM system.room_allocation)";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@UserType", userType);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
                }
                reader.Close();
                return Users;
            }
            return null;
        }
        
        public String GetUserNameOfAdmin(String email)
        {
            if (EstablishConnection())
            {
                String sql = "SELECT * FROM system.account WHERE Email = @Email";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@Email", email);
                MySqlDataReader reader = command.ExecuteReader();
                String name = "";
                while (reader.Read())
                {
                    name = (string)reader["UserName"];

                }
                reader.Close();
                
                return name;
            }
            return "";
        }

        public Account GetAccount(String email)
        {
            if(EstablishConnection())
            {
                String sql = "SELECT * FROM system.account WHERE Email = @Email";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@Email", email);
                MySqlDataReader reader = command.ExecuteReader();
                Account account = null;
                while (reader.Read())
                {
                    account = new Account((string)reader["Email"], (string)reader["UserName"], (string)reader["Password"], (DateTime)reader["Birthday"], (string)reader["FirstName"], (string)reader["LastName"], (byte[])reader["ImageData"]);
                }
                reader.Close();
                
                return account;
            }
            return null;
        }
      
        public void UpdateAccount(String email, String userName, String password, DateTime birthday, String firstName, String lastName, byte[] imageDate)
        {
            if (EstablishConnection())
            {
                String query = "UPDATE system.account SET UserName = @UserName, Password = @Password, Birthday = @Birthday, FirstName = @FirstName, LastName = @LastName, ImageData = @ImageData WHERE Email = @Email";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Birthday", birthday);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@ImageData", imageDate);
                command.ExecuteNonQuery();
                
            }
        }
       
        public bool AccountExist(String email, String password)
        {
            if (EstablishConnection())
            {
                String sql = "SELECT * FROM system.account WHERE Email = @Email AND Password = @Password";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return true;
                }
                reader.Close();
                
                return false;
            }
            return false;
        }

        public void AddPicture(String email, byte[] image)
        {
            if (EstablishConnection())
            {
                String query = "UPDATE system.account SET ImageData = @ImageData WHERE Email = @Email";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@ImageData", image);
                command.ExecuteNonQuery();
                
            }
        }
        
        // Users
        public List<User> GetAllUsersExcpetAdmin()
        {
            if (EstablishConnection())
            {
                Users.Clear();
                String sql = "SELECT * FROM system.user WHERE UserType NOT IN ('Dormitory Adviser', 'Assistant Dormitory Adviser');";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
                }
                reader.Close();
                return Users;
            }
            return null;
        }
       
        public List<User> GetAllUsers()
        {
            Users.Clear();
            if (EstablishConnection())
            {
                string sql = "SELECT * FROM system.user;";
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));

                }
                reader.Close();
                
                return Users;
            }
            return null;
        }
        
        public bool AddUser(User user)
        {
            if (EstablishConnection())
            {
                string query = "INSERT INTO system.user(";
                PropertyInfo[] properties = user.GetType().GetProperties();
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
                MySqlCommand command = new MySqlCommand(query, Connection);

                foreach (PropertyInfo property in properties)
                {
                    object value = property.GetValue(user);
                    command.Parameters.AddWithValue("@" + property.Name, value);
                }
                command.ExecuteNonQuery();
                AddUserPayable(user.UserId);
                
                return true;
            }
            return false;
        }

        public bool UpdateUser(User user)
        {
            Users = GetAllUsers();
            if (!UserExists(user.UserId))
                throw new ArgumentException("User does not exist");
            if (EstablishConnection())
            {
                String query = "UPDATE system.user SET ";
                PropertyInfo[] properties = user.GetType().GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    query += properties[i].Name + " = @" + properties[i].Name;
                    if (i < properties.Length - 1)
                        query += ", ";
                }
                query += " WHERE UserId = @UserId";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@UserId", user.UserId);
                foreach (PropertyInfo property in properties)
                {
                    object value = property.GetValue(user);
                    if (!property.Name.Equals("UserId"))
                        command.Parameters.AddWithValue("@" + property.Name, value);
                }
                command.ExecuteNonQuery();
                
                return true;
            }
            return false;
        }
        
        public User GetUser(String userId)
        {
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            if (EstablishConnection())
            {
                String sql = "SELECT * FROM system.user WHERE UserId = @UserId";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@UserId", userId);
                MySqlDataReader reader = command.ExecuteReader();
                User user = null;
                while (reader.Read())
                {
                    user = new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]);
                }
                reader.Close();
                
                return user;
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
            if (EstablishConnection())
            {
                DeleteUserRoomAllocation(userId);
                DeletUserPayable(userId);
                DeleteUserPayment(userId);
                DeleteUserAllEventAttendance(userId);
                String query = "DELETE FROM system.user WHERE UserId = @UserId";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.ExecuteNonQuery();
                
            }
            return false;
        }
      
        public bool UserExists(string userId)
        {
            Users = GetAllUsers();
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
            if (EstablishConnection())
            {
                string sql = "SELECT * FROM system.room_allocation;";
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RoomAllocations.Add(new RoomAllocation((int)reader["RoomAllocationId"], (DateTime)reader["StartDate"], (DateTime)reader["EndDate"], (int)reader["FK_RoomId_RoomAllocation"], (string)reader["FK_UserId_RoomAllocation"], true));
                }
                reader.Close();
                
                return RoomAllocations;
            }
            return null;
        }
      
        public bool DeleteUserRoomAllocation(String userId)
        {
            if (UserAllocated(userId) && EstablishConnection())
            {
                Room r = GetUserRoom(userId);
                r.DecreaseOccupants(1);
                MessageBox.Show(r.CurrNumOfOccupants.ToString());
                UpdateRoomSize(r.RoomId, r.CurrNumOfOccupants);
                String query = "DELETE FROM system.room_allocation WHERE FK_UserId_RoomAllocation = @FK_UserId_RoomAllocation";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@FK_UserId_RoomAllocation", userId);
                command.ExecuteNonQuery();
                
                return true;
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
            if (EstablishConnection())
            {
                String sql = "SELECT * FROM system.room WHERE RoomId = @RoomId";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@RoomId", roomId);
                MySqlDataReader reader = command.ExecuteReader();
                Room room = null;
                while (reader.Read())
                {
                    room = new Room((int)reader["RoomId"], (int)reader["LevelNumber"], (int)reader["MaximumCapacity"], (int)reader["CurrNumOfOccupants"]);
                }
                reader.Close(); 
                
                return room;
            }
            return null;
        }

        public List<Room> GetAllRooms()
        {
            Rooms.Clear();
            if (EstablishConnection())
            {
                string sql = "SELECT * FROM system.room;";
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Rooms.Add(new Room((int)reader["RoomId"], (int)reader["LevelNumber"], (int)reader["MaximumCapacity"], (int)reader["CurrNumOfOccupants"]));
                }
                reader.Close();
                return Rooms;
            }
            return null;
        }
        
        public List<User> GetUsersInRoom(int roomId)
        {
            if (EstablishConnection())
            {
                Users.Clear();
                String sql = "SELECT* FROM system.user u INNER JOIN system.room_allocation t ON u.UserId = t.FK_UserId_RoomAllocation WHERE t.FK_RoomId_RoomAllocation = @RoomId;";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@RoomId", roomId);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
                }
                reader.Close();
                return Users;
            }
            return null;
        }
        
        public void UpdateRoomSize(int roomId, int n)
        {
            if (EstablishConnection())
            {
                String query = "UPDATE system.room SET CurrNumOfOccupants = @n WHERE RoomId = @RoomId";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@RoomId", roomId);
                command.Parameters.AddWithValue("@n", n);
                command.ExecuteNonQuery();
                
            }
        }
      
        public bool RoomHasBigBrod(int roomId)
        {
            if (EstablishConnection())
            {
                String sql = "SELECT * FROM system.user u INNER JOIN system.room_allocation t ON u.UserId = t.FK_UserId_RoomAllocation WHERE t.FK_RoomId_RoomAllocation = @RoomId AND UserType = 'Big Brod';";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@RoomId", roomId);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    return true;
                }
                reader.Close();
                return false;
            }
            return false;
        }
        
        public int CountBigBrod(int roomId)
        {
            if(EstablishConnection())
            {
                String query = "SELECT * FROM system.user u INNER JOIN system.room_allocation t ON u.UserId = t.FK_UserId_RoomAllocation WHERE t.FK_RoomId_RoomAllocation = @RoomId AND UserType = 'Big Brod';";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@RoomId", roomId);
                MySqlDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                reader.Close();
                return count;
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
                MessageBox.Show(userId + " already had a room.\nClick the edit button if you want to change its room.");
                return false;
            }
            Rooms = GetAllRooms();
            if (!Rooms[roomId - 1].CanIncreaseOccupancy(1) || UserAllocated(userId))
            {
                MessageBox.Show("Room is full.");
                return false;
            }
            if (EstablishConnection())
            {
                string query = "INSERT INTO system.room_allocation(RoomAllocationId, StartDate, EndDate, FK_RoomId_RoomAllocation, FK_UserId_RoomAllocation) VALUES (@RoomAllocationId, @StartDate, @EndDate, @FK_RoomId_RoomAllocation, @FK_UserId_RoomAllocation)";
                MySqlCommand command = new MySqlCommand(query, Connection);
                List<RoomAllocation> ra = GetAllRoomAllocations();
                int index = ra[ra.Count-1].RoomAllocationId + 1;
                command.Parameters.AddWithValue("@RoomAllocationId", index);
                command.Parameters.AddWithValue("@StartDate", DateTime.Now);
                command.Parameters.AddWithValue("@EndDate", DateTime.Now.AddMonths(1));
                command.Parameters.AddWithValue("@FK_RoomId_RoomAllocation", roomId);
                command.Parameters.AddWithValue("@FK_UserId_RoomAllocation", userId);

                command.ExecuteNonQuery();
                UpdateRoomSize(roomId, Rooms[roomId - 1].CurrNumOfOccupants);
                
                return true;
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
                MessageBox.Show("Room is already full");
                return false;
            }
            if(!UserAllocated(userId))
            {
                MessageBox.Show(userId + " does not have a room yet.");
                return false;
            }
            if(CountBigBrod(newRoomId) == 1 && GetUser(userId).UserType == "Big Brod" && newRoomId != 4)
            {
                MessageBox.Show("This room already has a Big Brod assigned.");
                return false;
            }
            if(newRoomId == 4 && CountBigBrod(newRoomId) > 1 && GetUser(userId).UserType == "Big Brod")
            {
                MessageBox.Show("Room 4 already has 2 Big Brods.");
                return false;
            }

            if (EstablishConnection())
            {
                String query = "UPDATE system.room_allocation SET FK_RoomId_RoomAllocation = @FK_RoomId_RoomAllocation WHERE FK_UserId_RoomAllocation = @FK_UserId_RoomAllocation";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@FK_RoomId_RoomAllocation", newRoomId);
                command.Parameters.AddWithValue("@FK_UserId_RoomAllocation", userId);
                command.ExecuteNonQuery();
                Rooms[prevRoomId - 1].DecreaseOccupants(1);
                UpdateRoomSize(prevRoomId, Rooms[prevRoomId - 1].CurrNumOfOccupants);
                UpdateRoomSize(newRoomId, Rooms[newRoomId - 1].CurrNumOfOccupants);
                
                return true;
            }
            return false;
        }

        // Department
        public List<Department> GetAllDepartments()
        {
            Departments.Clear();
            if (EstablishConnection())
            {
                string sql = "SELECT * FROM system.department;";
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Departments.Add(new Department((int)reader["DepartmentId"], (string)reader["DepartmentName"], (string)reader["CollegeName"]));
                }
                reader.Close();
                
                return Departments;
            }
            return null;
        }

        public Department GetUserDepartment(String userId)
        {
            Department d = null;
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            if (EstablishConnection())
            {
                String sql = "SELECT * FROM system.department WHERE DepartmentId = (SELECT FK_DepartmentId FROM system.user WHERE UserId = @UserId)";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@UserId", userId);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    d = new Department((int)reader["DepartmentId"], (string)reader["DepartmentName"], (string)reader["CollegeName"]);
                }
                reader.Close();
                
                return d;
            }
            return null;
        }

        public Room GetUserRoom(String userId)
        {
            Room r = null;
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            if (EstablishConnection())
            {
                String sql = "SELECT * FROM system.room WHERE RoomId = (SELECT FK_RoomId_RoomAllocation FROM system.room_allocation WHERE FK_UserId_RoomAllocation = @FK_UserId_RoomAllocation)";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@FK_UserId_RoomAllocation", userId);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    r = new Room((int)reader["RoomId"], (int)reader["LevelNumber"], (int)reader["MaximumCapacity"], (int)reader["CurrNumOfOccupants"]);

                }
                reader.Close();
                
                return r;
            }
            return null;
        }

        // Events
        public int GetLastEventId()
        {
            if(EstablishConnection())
            {
                String sql = "SELECT MAX(EventId) FROM system.event";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                MySqlDataReader reader = command.ExecuteReader();
                int id = 0;
                while (reader.Read())
                {
                    id = (int)reader["MAX(EventId)"];
                }
                reader.Close();
                
                return id;
            }
            return -1;
        }
        
        public List<Event> GetAllEvents()
        {
            if (EstablishConnection())
            {
                Events.Clear();
                if (EstablishConnection())
                {
                    string sql = "SELECT * FROM system.event;";
                    MySqlCommand cmd = new MySqlCommand(sql, Connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Events.Add(new Event((int)reader["EventId"], (string)reader["EventName"], (DateTime)reader["EventDate"], (DateTime)reader["EventTime"], (String)reader["Location"], (String)reader["Description"], reader.GetBoolean("HasPayables"), (float)reader["AttendanceFineAmount"], (float)reader["EventFeeContribution"], true));
                    }
                    reader.Close();
                    
                    return Events;
                }
                return null;
            }
            return null;
        }
        
        public bool AddEvent(Event e)
        {
            if (EstablishConnection())
            {
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
                MySqlCommand command = new MySqlCommand(query, Connection);

                foreach (PropertyInfo property in properties)
                {
                    object value = property.GetValue(e);
                    if (property.Name.Equals("EventTime"))
                        command.Parameters.AddWithValue("@" + property.Name, DateTime.Parse(e.EventTime));
                    else
                        command.Parameters.AddWithValue("@" + property.Name, value);
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Added Sucessfully");
                AdddEventFineUserPayable(e.AttendanceFineAmount);
                
                return true;
            }
            return false;
        }
     
        public bool UpdateEvent(Event e)
        {
            Events = GetAllEvents();
            if (!EventExists(e.EventId))
                throw new ArgumentException("Event does not exist");
            if (EstablishConnection())
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
                MySqlCommand command = new MySqlCommand(query, Connection);
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
                if(e.AttendanceFineAmount != fines)
                {
                    AdddEventFineUserPayable(e.AttendanceFineAmount - fines);
                }
                
                return true;
            }
            return false;
        }
        
        public bool DeleteEvent(int eventId)
        {
            Events = GetAllEvents();
            if (!EventExists(eventId))
                throw new ArgumentException("Event does not exist");
            if (EstablishConnection())
            {
                SubtractEventFineUserPayable(GetEvent(eventId).AttendanceFineAmount);
                String query = "DELETE FROM system.event WHERE EventId = @EventId";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@EventId", eventId);
                command.ExecuteNonQuery();
                
            }
            return false;
        }

        public List<Event> GetMonthlyEvent()
        {
            if (EstablishConnection())
            {
                Events.Clear();
                DateTime currentDate = DateTime.Now;

                string sql = $"SELECT * FROM system.event WHERE MONTH(EventDate) = {currentDate.Month} AND YEAR(EventDate) = {currentDate.Year}";

                using (MySqlCommand cmd = new MySqlCommand(sql, Connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Events.Add(new Event(reader.GetInt32("EventId"), reader.GetString("EventName"), reader.GetDateTime("EventDate"), reader.GetDateTime("EventTime"), reader.GetString("Location"), reader.GetString("Description"), reader.GetBoolean("HasPayables"), reader.GetFloat("AttendanceFineAmount"), reader.GetFloat("EventFeeContribution"), true)); 
                    }
                }
                
                return Events;
            }
            return null;
        }

        public Event GetEvent(int eventId)
        {
            if (!EventExists(eventId))
                throw new ArgumentException("Event does not exist");
            if (EstablishConnection())
            {
                String sql = "SELECT * FROM system.event WHERE EventId = @EventId";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@EventId", eventId);
                MySqlDataReader reader = command.ExecuteReader();
                Event e = null;
                while (reader.Read())
                {
                    e = new Event((int)reader["EventId"], (string)reader["EventName"], (DateTime)reader["EventDate"], (DateTime)reader["EventTime"], (String)reader["Location"], (String)reader["Description"], reader.GetBoolean("HasPayables"), (float)reader["AttendanceFineAmount"], (float)reader["EventFeeContribution"], true);
                }
                reader.Close();
                
                return e;
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
            if (EstablishConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.event_attendance", Connection))
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
                catch
                {
                    MessageBox.Show("There was an error while retrieving event attendances");
                }
            }
            return null;
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
            if (EstablishConnection())
            {
                try
                {
                    string query = "INSERT INTO system.event_attendance(EventAttendanceId, AttendanceStatus, FK_UserId_EventAttendance, FK_EventId_EventAttendance) VALUES (@EventAttendanceId, @AttendanceStatus, @FK_UserId_EventAttendance, @FK_EventId_EventAttendance)";
                    using (MySqlCommand command = new MySqlCommand(query, Connection))
                    {
                        List<EventAttendance> ea = GetEventAttendances();
                        int index = ea.ElementAt(ea.Count() - 1).EventAttendanceId + 1;
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
                catch
                {
                    MessageBox.Show("There was an error while recording attendance");
                }
            }
            return false;
        }
        
        public EventAttendance GetUserEventAttendance(int eventId, String userId)
        {
            if (!EventExists(eventId) || !UserExists(userId))
                return null;
            if (EstablishConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.event_attendance WHERE FK_EventId_EventAttendance = @FK_EventId_EventAttendance AND FK_UserId_EventAttendance = @FK_UserId_EventAttendance", Connection))
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
                catch
                {
                    MessageBox.Show("There was an error while retrieving user's event attendance");
                }
            }
            return null;
        }
        
        public bool UpdateAttendance(String userId, int eventId, String status)
        {
            String origStatus = GetUserEventAttendance(eventId, userId).AttendanceStatus;
            if (!EventExists(eventId) || !UserExists(userId) || !EventAttendanceExists(eventId, userId))
                return false;
            if (EstablishConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.event_attendance WHERE FK_UserId_EventAttendance = @FK_UserId_EventAttendance AND FK_EventId_EventAttendance = @FK_EventId_EventAttendance", Connection))
                    {
                        command.Parameters.AddWithValue("@FK_UserId_EventAttendance", userId);
                        command.Parameters.AddWithValue("@FK_EventId_EventAttendance", eventId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EventAttendances.Add(new EventAttendance((int)reader["EventAttendanceId"], (string)reader["AttendanceStatus"], (string)reader["FK_UserId_EventAttendance"], (int)reader["FK_EventId_EventAttendance"]));
                            }
                        }
                    }
                    return true;
                }
                catch
                {
                    MessageBox.Show("There was an error while updating event attendance");
                }
            }
            return false;
        }
        
        public List<EventAttendance> GetEventAttendances(int eventId)
        {
            if(!EventExists(eventId))
                throw new ArgumentException("Event does not exist");
            if (EstablishConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.event_attendance WHERE FK_EventId_EventAttendance = @FK_EventId_EventAttendance", Connection))
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
                catch
                {
                    MessageBox.Show("There was an error while retrieving event attendances");
                }
            }
            return null;
        }
       
        public void AdddEventFineUserPayable(float eventFines)
        {
            if(EstablishConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("UPDATE system.user_payable SET RemainingBalance = RemainingBalance - @RemainingBalance", Connection))
                    {
                        command.Parameters.AddWithValue("@RemainingBalance", eventFines);
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    MessageBox.Show("An error occurred while adding event fine to user payable");
                } 
            }
        }
        
        public bool DeleteUserAllEventAttendance(String userI)
        {
            if(EstablishConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM system.event_attendance WHERE FK_UserId_EventAttendance = @FK_UserId_EventAttendance", Connection))
                    {
                        command.Parameters.AddWithValue("@FK_UserId_EventAttendance", userI);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch
                {
                    MessageBox.Show("An error occurred while deleting user's event attendance");
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
            if(EstablishConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM system.payment;", Connection))
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
                }
                catch
                {
                    MessageBox.Show("An error occurred while retrieving Payments");
                }
                return Payments;
            }
            return null;
        }
      
        public bool AddPayment(Payment p)
        {
            if (EstablishConnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand("INSERT INTO system.payment(PaymentId, PaymentDate, Amount, Remarks, FK_UserId_Payment) VALUES (@PaymentId, @PaymentDate, @Amount, @Remarks, @FK_UserId_Payment)", Connection))
                    {
                        command.Parameters.AddWithValue("@PaymentId", p.PaymentId);
                        command.Parameters.AddWithValue("@PaymentDate", p.PaymentDate);
                        command.Parameters.AddWithValue("@Amount", p.Amount);
                        command.Parameters.AddWithValue("@Remarks", p.Remarks);
                        command.Parameters.AddWithValue("@FK_UserId_Payment", p.FK_UserId_Payment);
                        command.ExecuteNonQuery();
                        UpdateUserPayable(p.FK_UserId_Payment, p.Amount);
                    }
                }
                catch
                {                     
                    MessageBox.Show("An error occurred while adding payment");
                }
                return true;
            }
            return false;
        }
        
        public bool DeleteUserPayment(String userId)
        {
            if(EstablishConnection() && UserPaymentExists(userId))
            {
                using (MySqlCommand command = new MySqlCommand("DELETE FROM system.payment WHERE FK_UserId_Payment = @FK_UserId_Payment", Connection))
                {
                    command.Parameters.AddWithValue("@FK_UserId_Payment", userId);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            return false;
        }
        
        public List<Payment> GetAllUserPayments(String userId)
        {
            if(!UserExists(userId))
                throw new ArgumentException("User does not exist");
            if (EstablishConnection())
            {
                try
                {
                    Payments.Clear();
                    String sql = "SELECT * FROM system.payment WHERE FK_UserId_Payment = @FK_UserId_Payment";
                    using (MySqlCommand command = new MySqlCommand(sql, Connection))
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
                catch
                {
                    MessageBox.Show("An error occurred while retrieving Payments");
                }
            }
            return null;
        }
        
        public float GetSumUserPayments(String userId)
        {
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");

            if (EstablishConnection())
            {
                float sum = 0;
                string sql = "SELECT * FROM system.payment WHERE FK_UserId_Payment = @FK_UserId_Payment";

                using (MySqlCommand command = new MySqlCommand(sql, Connection))
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
            return 0;
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
            if (EstablishConnection())
            {
                string query = "INSERT INTO system.regular_payable(RegularPayableId, Name, Amount) VALUES (@RegularPayableId, @Name, @Amount)";

                using (MySqlCommand command = new MySqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@RegularPayableId", regularPayable.RegularPayableId);
                    command.Parameters.AddWithValue("@Name", regularPayable.Name);
                    command.Parameters.AddWithValue("@Amount", regularPayable.Amount);

                    command.ExecuteNonQuery();
                }
                return true;
            }
            return false;
            /*if(EstablishConnection())
            {
                string query = "INSERT INTO system.regular_payable(";
                PropertyInfo[] properties = regularPayable.GetType().GetProperties();
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
                MySqlCommand command = new MySqlCommand(query, Connection);

                foreach (PropertyInfo property in properties)
                {
                    object value = property.GetValue(regularPayable);
                    command.Parameters.AddWithValue("@" + property.Name, value);
                }
                command.ExecuteNonQuery();
                AdddEventFineUserPayable(regularPayable.Amount);
                
                return true;
            }
            return false;*/
        }
        
        public List<RegularPayable> GetRegularPayables()
        {
            RegularPayable.Clear();

            if (EstablishConnection())
            {
                try
                {
                    string sql = "SELECT * FROM system.regular_payable;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, Connection))
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
            }
            return null;
        }

        public void UpdateRegularPayable(RegularPayable regularPayable)
        {
            if (EstablishConnection())
            {
                string query = "UPDATE system.regular_payable SET Name = @Name, Amount = @Amount WHERE RegularPayableId = @RegularPayableId";
                using (MySqlCommand command = new MySqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@RegularPayableId", regularPayable.RegularPayableId);
                    command.Parameters.AddWithValue("@Name", regularPayable.Name);
                    command.Parameters.AddWithValue("@Amount", regularPayable.Amount);

                    command.ExecuteNonQuery();
                }
            }
        }
      
        public RegularPayable GetRegularPayable(int id)
        {
            if (!RegularPayableExists(id))
                throw new ArgumentException("Regular Payable does not exist");

            if (EstablishConnection())
            {
                try
                {
                    string sql = "SELECT * FROM system.regular_payable WHERE RegularPayableId = @RegularPayablesId";
                    using (MySqlCommand command = new MySqlCommand(sql, Connection))
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
            }
            return null;

        }

        public void DeleteRegularPayable(int id)
        {
            if (EstablishConnection())
            {
                try
                {
                    SubtractEventFineUserPayable(GetRegularPayable(id).Amount);
                    string query = "DELETE FROM system.regular_payable WHERE RegularPayableId = @RegularPayableId";

                    using (MySqlCommand command = new MySqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@RegularPayableId", id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting RegularPayable: " + ex.Message);
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
            if (EstablishConnection())
            {
                string query = "INSERT INTO system.user_payable(UserPayableId, RemainingBalance, FK_UserId_UserPayable) VALUES (@UserPayableId, @RemainingBalance, @FK_UserId_UserPayable)";

                using (MySqlCommand command = new MySqlCommand(query, Connection))
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

            return false;

            /*if (EstablishConnection())
            {
                string query = "INSERT INTO system.user_payable(";
                PropertyInfo[] properties = typeof(UserPayable).GetProperties();
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
                MySqlCommand command = new MySqlCommand(query, Connection);
                List<UserPayable> up = GetAllUserPayable();
                int index = up[up.Count-1].UserPayableId + 1;
                float remainingBalance = 0;
                command.Parameters.AddWithValue("@UserPayableId", index);
                remainingBalance = GetSumEvents() + (GetSumRegularPayable() * 5);
                command.Parameters.AddWithValue("@RemainingBalance", remainingBalance);
                command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                command.ExecuteNonQuery();
                
                return true;
            }
            return false;*/
        }
        
        public List<UserPayable> GetAllUserPayable()
        {
            if(EstablishConnection())
            {
                UserPayables.Clear();
                string sql = "SELECT * FROM system.user_payable;";
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserPayables.Add(new UserPayable((int)reader["UserPayableId"], (float)reader["RemainingBalance"], (string)reader["FK_UserId_UserPayable"]));
                }
                reader.Close();
                
                return UserPayables;
            }
            return null;
        }
       
        public UserPayable GetUserPayable(string userId)
        {
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");

            if (!EstablishConnection())
                return null;

            string sql = "SELECT * FROM system.user_payable WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable LIMIT 1";
            using (MySqlCommand command = new MySqlCommand(sql, Connection))
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
            return null;
        }

        public float GetUserPayableBalance(string userId)
        {
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");

            if (!EstablishConnection())
                return 0;

            string sql = "SELECT RemainingBalance FROM system.user_payable WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable LIMIT 1";
            using (MySqlCommand command = new MySqlCommand(sql, Connection))
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

        public void UpdateUserPayable(String userId, float Amount)
        {
            if (EstablishConnection())
            {
                try
                {
                    float updatedAmount = 0;
                    string query = "UPDATE system.user_payable SET RemainingBalance = @updatedAmount WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    updatedAmount = GetUserPayable(userId).RemainingBalance - Amount;
                    if (updatedAmount < 0)
                        updatedAmount = 0;

                    using (MySqlCommand command = new MySqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@updatedAmount", updatedAmount);
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating UserPayable: " + ex.Message);
                }
            }
        }
       
        public void AddUserPayable(String userId, float Amount)
        {
            if (EstablishConnection())
            {
                try
                {
                    float updatedAmount = 0;
                    string query = "UPDATE system.user_payable SET RemainingBalance = @updatedAmount WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    updatedAmount = GetUserPayable(userId).RemainingBalance + Amount;

                    using (MySqlCommand command = new MySqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@updatedAmount", updatedAmount);
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding UserPayable: " + ex.Message);
                }
            }
        }
       
        public float GetSumRemainingBalance()
        {
            if (EstablishConnection())
            {
                float sum = 0;
                string query = "SELECT SUM(RemainingBalance) AS SumAmount FROM system.user_payable;";

                using (MySqlCommand command = new MySqlCommand(query, Connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            sum = reader.GetFloat("SumAmount"); 
                    }
                }
                return sum;
            }
            return 0;
        }
        
        public void LoadUserPayable(String userId)
        {
            if (!UserPayableExists(userId))
            {
                if (EstablishConnection())
                {
                    string query = "INSERT INTO system.user_payable(UserPayableId, RemainingBalance, FK_UserId_UserPayable) SELECT @UserPayableId, @RemainingBalance, UserID FROM system.user WHERE UserID = @FK_UserId_UserPayable AND UserType NOT IN('Dormitory Adviser', 'Assistant Dormitory Adviser');";

                    MySqlCommand command = new MySqlCommand(query, Connection);
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
            }
            else
                UpdateUserLoadPayable(userId, GetSumEvents() + (GetSumRegularPayable() * 5));
        }
        
        public void LoadUsersPayable()
        {
            Users.Clear();
            Users = GetAllUsersExcpetAdmin();
            foreach (User u in Users.ToList())
            {
                if (!UserPayableExists(u.UserId))
                {
                    if (EstablishConnection())
                    {
                        try
                        {
                            string query = "INSERT INTO system.user_payable(UserPayableId, RemainingBalance, FK_UserId_UserPayable) SELECT @UserPayableId, @RemainingBalance, UserID FROM system.user WHERE UserID = @FK_UserId_UserPayable AND UserType NOT IN('Dormitory Adviser', 'Assistant Dormitory Adviser');";

                            using (MySqlCommand command = new MySqlCommand(query, Connection))
                            {
                                List<UserPayable> up = GetAllUserPayable();
                                int index = 1;
                                if (up.Count > 0)
                                    index = up[GetAllUserPayable().Count - 1].UserPayableId + 1;
                                float remainingBalance = 0;
                                command.Parameters.AddWithValue("@UserPayableId", index);
                                remainingBalance = GetSumEvents() + (GetSumRegularPayable() * 5) - GetSumUserPayments(u.UserId);
                                command.Parameters.AddWithValue("@RemainingBalance", remainingBalance);
                                command.Parameters.AddWithValue("@FK_UserId_UserPayable", u.UserId);
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while loading UserPayable: " + ex.Message);
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
            if (EstablishConnection())
            {
                try
                {
                    string query = "UPDATE system.user_payable SET RemainingBalance = @RemainingBalance WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    float balance = GetSumEvents() + (GetSumRegularPayable() * 5) - GetSumUserPayments(userId);

                    using (MySqlCommand command = new MySqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@RemainingBalance", balance);
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the UserPayable: " + ex.Message);
                }
            }
        }
        
        public void UpdateUserLoadPayable(String userId, float updatedAmount)
        {
            if (EstablishConnection())
            {
                try
                {
                    string query = "UPDATE system.user_payable SET RemainingBalance = @updatedAmount WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    using (MySqlCommand command = new MySqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@updatedAmount", updatedAmount);
                        command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the UserPayable: " + ex.Message);
                }
            }
        }
        
        public bool DeletUserPayable(String userId)
        {
            if (EstablishConnection() && UserPayableExists(userId))
            {
                try
                {
                    string query = "DELETE FROM system.user_payable WHERE FK_UserId_UserPayable = @FK_UserId_UserPayable";
                    MySqlCommand command = new MySqlCommand(query, Connection);
                    command.Parameters.AddWithValue("@FK_UserId_UserPayable", userId);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the UserPayable: " + ex.Message);
                }
            }
            return false;
        }
        
        public bool UserPayableExists(String userId)
        {
            if(EstablishConnection())
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
            return false;
        }
       
        // Operations
        public float GetSumEvents()
        {
            if (EstablishConnection())
            {
                float sum = 0;
                string sql = "SELECT SUM(AttendanceFineAmount) AS TotalEventFees FROM system.event;";

                using (MySqlCommand cmd = new MySqlCommand(sql, Connection))
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while reading data: " + ex.Message);
                    }
                }
                return sum;
            }
            return 0;
        }
        
        public float GetSumRegularPayable()
        {
            if (EstablishConnection())
            {
                float sum = 0;
                string sql = "SELECT SUM(Amount) FROM system.regular_payable;";

                using (MySqlCommand cmd = new MySqlCommand(sql, Connection))
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
            return 0;
        }

        public void SubtractEventFineUserPayable(float fines)
        {
            if (EstablishConnection())
            {
                try
                {
                    string query = "UPDATE system.user_payable SET RemainingBalance = RemainingBalance - @RemainingBalance";
                    MySqlCommand command = new MySqlCommand(query, Connection);
                    command.Parameters.AddWithValue("@RemainingBalance", fines);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        public List<User> GetPaidUsers()
        {
            if (EstablishConnection())
            {
                Users.Clear();
                List<User> u = new List<User>();
                string sql = "SELECT * FROM system.user_payable WHERE RemainingBalance = 0 AND FK_UserId_UserPayable NOT IN (SELECT UserId FROM system.user  WHERE UserType IN ('Dormitory Adviser', 'Assistant Dormitory Adviser'));";

                using (MySqlCommand cmd = new MySqlCommand(sql, Connection))
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
            return null;
        }
        
        public List<User> GetPendingUsers()
        {
            if (EstablishConnection())
            {
                Users.Clear();
                List<User> u = new List<User>();
                string sql = "SELECT * FROM system.user_payable WHERE RemainingBalance > 0 AND FK_UserId_UserPayable NOT IN (SELECT UserId FROM system.user WHERE UserType IN ('Dormitory Adviser', 'Assistant Dormitory Adviser'));";

                using (MySqlCommand cmd = new MySqlCommand(sql, Connection))
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
            return null;
        }
    }
}
