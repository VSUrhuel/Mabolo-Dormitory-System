using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        
        public DatabaseManager()
        {
            EstablishConnection();
            Users = new List<User>();
            Departments = new List<Department>();
            Rooms = new List<Room>();
            EventAttendances = new List<EventAttendance>();
            Events = new List<Event>();
            Payments = new List<Payment>();
            RoomAllocations = new List<RoomAllocation>();
        }
        public bool EstablishConnection()
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
                MessageBox.Show(e.Message);
                return false;
            }

        }

        // Users
        public List<User> GetAllUsers()
        {
            Users.Clear();
            if(EstablishConnection())
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
        public List<User> GetTypeOfUser(String type)
        {
            if (type != "Regular Dormer" && type != "Big Brod" && type != "Dorm Adviser" && type != "Student Assistant" && type != "Assistant Dorm Adviser")
                throw new ArgumentException("Invalid User Type");
            Users.Clear();
            if (EstablishConnection())
            {
                string sql = "SELECT * FROM system.user WHERE UserType = @UserType;";
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                cmd.Parameters.AddWithValue("@UserType", type);
                MySqlDataReader reader = cmd.ExecuteReader();            
                while (reader.Read())
                {
                    Users.Add(new User((string)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"], (DateTime)reader["Birthday"], (string)reader["Email"], (string)reader["PhoneNumber"], (string)reader["Address"], (string)reader["UserStatus"], (string)reader["UserType"], (int)reader["FK_DepartmentId"]));
                    
                }
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
                
                foreach (PropertyInfo property in properties )
                {
                    object value = property.GetValue(user);
                    command.Parameters.AddWithValue("@" + property.Name, value);
                }
                command.ExecuteNonQuery();
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
        public bool DeleteUser(String userId)
        {
            Users = GetAllUsers();
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            if(EstablishConnection())
            {
                String query = "DELETE FROM system.user WHERE UserId = @UserId";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted");
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
        public bool UserAllocated(String userId)
        {
            RoomAllocations = GetAllRoomAllocations();
            foreach(RoomAllocation ra in RoomAllocations)
            {
                if (ra.FK_UserId_RoomAllocation == userId)
                    return true;
            }
            return false;
        }

        // Rooms
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
                return Rooms;
            }
            return null;
        }
        public List<User> GetUsersInRoom(int roomId)
        {
            if(EstablishConnection())
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
        public bool AddUserInRoom(int roomId, String userId)
        {
            if(roomId < 0 || roomId > 9)
                throw new ArgumentException("Invalid Room Id");
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            if(UserAllocated(userId))
                return false;
            Rooms = GetAllRooms();
            if (!Rooms[roomId - 1].CanIncreaseOccupancy(1) || UserAllocated(userId))
                return false;
            if (EstablishConnection())
            {
                string query = "INSERT INTO system.room_allocation(RoomAllocationId, StartDate, EndDate, FK_RoomId_RoomAllocation, FK_UserId_RoomAllocation) VALUES (@RoomAllocationId, @StartDate, @EndDate, @FK_RoomId_RoomAllocation, @FK_UserId_RoomAllocation)";
                MySqlCommand command = new MySqlCommand(query, Connection);
                List<RoomAllocation> ra = GetAllRoomAllocations();
                int index = ra.Count + 1;
                command.Parameters.AddWithValue("@RoomAllocationId", index);
                command.Parameters.AddWithValue("@StartDate", DateTime.Now);
                command.Parameters.AddWithValue("@EndDate", DateTime.Now.AddMonths(1));
                command.Parameters.AddWithValue("@FK_RoomId_RoomAllocation", roomId);
                command.Parameters.AddWithValue("@FK_UserId_RoomAllocation", userId);
                UpdateRoomSize(roomId, Rooms[roomId - 1].CurrNumOfOccupants);
               
                command.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        public bool UserHasRoom(String userId)
        {
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            if (EstablishConnection())
            {
                String sql = "SELECT * FROM system.room_allocation WHERE FK_UserId_RoomAllocation = @FK_UserId_RoomAllocation";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@FK_UserId_RoomAllocation", userId);
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
        public bool UpdateUserRoom(int prevRoomId, int newRoomId, String userId)
        {
            if ((prevRoomId < 0 || prevRoomId > 9) || (newRoomId < 0 || newRoomId > 9))
                throw new ArgumentException("Invalid Room Id");
            Rooms = GetAllRooms();
            if (!Rooms[newRoomId - 1].CanIncreaseOccupancy(1) || !UserAllocated(userId))
                return false;
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
                MessageBox.Show(userId + " moved to Room " + newRoomId);
                return true;
            }
            return false;
        }
        
        public bool RemoveUserInRoom(int roomId, String userId)
        {
            if (!UserAllocated(userId) || (roomId < 0 || roomId > 9))
                return false;
            if (EstablishConnection())
            {
                String query = "DELETE FROM system.room_allocation WHERE FK_RoomId_RoomAllocation = @FK_RoomId_RoomAllocation AND FK_UserId_RoomAllocation = @FK_UserId_RoomAllocation";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@FK_RoomId_RoomAllocation", roomId);
                command.Parameters.AddWithValue("@FK_UserId_RoomAllocation", userId);
                command.ExecuteNonQuery();
                return true;
            }
            return false;
        }

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
                        Events.Add(new Event((int)reader["EventId"], (string)reader["EventName"], (DateTime)reader["EventDate"], (DateTime)reader["EventTime"], (String)reader["Location"], (String)reader["Description"], reader.GetBoolean("HasPayables"), (float)reader["AttendanceFineAmount"], (float)reader["EventFeeContribution"]));
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
                    command.Parameters.AddWithValue("@" + property.Name, value);
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Added Sucessfully");
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
                    if (!property.Name.Equals("EventId"))
                        command.Parameters.AddWithValue("@" + property.Name, value);
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Updated");
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
                String query = "DELETE FROM system.event WHERE EventId = @EventId";
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@EventId", eventId);
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted");
            }
            return false;
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

        // Department
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
        // Event Attendance
        public List<EventAttendance> GetEventAttendances()
        {
            EventAttendances.Clear();
            if (EstablishConnection())
            {
                string sql = "SELECT * FROM system.event_attendance;";
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EventAttendances.Add(new EventAttendance((int)reader["EventAttendanceId"], (string)reader["AttendanceStatus"], (string)reader["FK_UserId_EventAttendance"], (int)reader["FK_EventId_EventAttendance"]));
                }
                reader.Close();
                return EventAttendances;
            }
            return null;
        }
        public bool RecordAttendance(String userId, int eventId)
        {
            if (!EventExists(eventId) || !UserExists(userId) || EventAttendanceExists(eventId, userId))
                return false;
            if (EstablishConnection())
            {
                string query = "INSERT INTO system.event_attendance(EventAttendanceId, AttendanceStatus, FK_UserId_EventAttendance, FK_EventId_EventAttendance) VALUES (@EventAttendanceId, @AttendanceStatus, @FK_UserId_EventAttendance, @FK_EventId_EventAttendance)";
                MySqlCommand command = new MySqlCommand(query, Connection);
                List<EventAttendance> ea = GetEventAttendances();
                int index = ea.Count + 1;
                command.Parameters.AddWithValue("@EventAttendanceId", index);
                command.Parameters.AddWithValue("@AttendanceStatus", "Present");
                command.Parameters.AddWithValue("@FK_UserId_EventAttendance", userId);
                command.Parameters.AddWithValue("@FK_EventId_EventAttendance", eventId);
                command.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        public List<EventAttendance> GetEventAttendancesOfUser(String userId)
        {
            if (!UserExists(userId))
                throw new ArgumentException("User does not exist");
            if (EstablishConnection())
            {
                EventAttendances.Clear();
                String sql = "SELECT * FROM system.event_attendance WHERE FK_UserId_EventAttendance = @FK_UserId_EventAttendance";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@FK_UserId_EventAttendance", userId);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EventAttendances.Add(new EventAttendance((int)reader["EventAttendanceId"], (string)reader["AttendanceStatus"], (string)reader["FK_UserId_EventAttendance"], (int)reader["FK_EventId_EventAttendance"]));
                }
                reader.Close();
                return EventAttendances;
            }
            return null;
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
        public List<User> GetPaymentEventRecord(int id)
        {
            if(EstablishConnection())
            {
                Users.Clear();
                String sql = "SELECT* FROM system.user u INNER JOIN system.payment t ON u.UserId = t.FK_UserId_Payment WHERE t.FK_EventId_Payment = @FK_EventId_Payment;";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@FK_EventId_Payment", id);
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
        public List<User> GetAllPaymentRecord()
        {
            if (EstablishConnection())
            {
                Users.Clear();
                String sql = "SELECT* FROM system.user u INNER JOIN system.payment t ON u.UserId = t.FK_UserId_Payment";
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
        public List<Payment> GetPayments()
        {
            Payments.Clear();
            if (EstablishConnection())
            {
                string sql = "SELECT * FROM system.payment;";
                MySqlCommand cmd = new MySqlCommand(sql, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Payments.Add(new Payment((int)reader["PaymentId"], (DateTime)reader["PaymentDate"], (float)reader["Amount"], (string)reader["PaymentStatus"], (string)reader["FK_UserId_Payment"], (int)reader["FK_EventId_Payment"]));
                }
                reader.Close();
                return Payments;
            }
            return null;
        }
        public bool AddPayment(int EventId, string userId, float amount)
        {
            if (EstablishConnection())
            {
                Events.Clear();
                Events = GetAllEvents();
                if (!EventExists(EventId))
                    throw new ArgumentException("Event does not exist");
                Users.Clear();
                Users = GetAllUsers();
                if (!UserExists(userId))
                    throw new ArgumentException("User does not exist");
                string query = "INSERT INTO system.payment(PaymentId, PaymentDate, Amount, PaymentStatus, FK_EventId_Payment, FK_UserId_Payment) VALUES (@PaymentId, @PaymentDate, @Amount, @PaymentStatus, @FK_EventId_Payment, @FK_UserId_Payment)";
                MySqlCommand command = new MySqlCommand(query, Connection);
                List<User> u = GetAllPaymentRecord();
                int index = u.Count + 1;
                command.Parameters.AddWithValue("@PaymentId", index);
                command.Parameters.AddWithValue("@FK_EventId_Payment", EventId+1);
                command.Parameters.AddWithValue("@FK_UserId_Payment", userId);
                command.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                command.Parameters.AddWithValue("@Amount", amount);
                if (amount >= (Convert.ToInt16(Events[EventId-1].EventFeeContribution) + Convert.ToInt16(Events[EventId-1].AttendanceFineAmount)))
                    command.Parameters.AddWithValue("@PaymentStatus", "Paid");
                else
                    command.Parameters.AddWithValue("@PaymentStatus", "Pending");
                command.ExecuteNonQuery();
                return true;
                
            }
            return false;
        }
        public bool UpdatePayment(int EventId, string userId, float amount)
        {
            Payments = GetPayments();
            if (!PaymentExists(EventId, userId))
                throw new ArgumentException("Payment does not exist");
            if (EstablishConnection())
            {
                String query = "UPDATE system.payment SET ";
                PropertyInfo[] properties = Payments[EventId - 1].GetType().GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (properties[i].Name.Equals("FK_UserId_EventAttendance"))
                        continue;
                    query += properties[i].Name + " = @" + properties[i].Name;
                    if (i < properties.Length - 1)
                        query += ", ";
                }
                query += " WHERE FK_EventId_Payment = @FK_EventId_Payment AND FK_UserId_Payment = @FK_UserId_Payment";
                MessageBox.Show(query);
                MySqlCommand command = new MySqlCommand(query, Connection);
                command.Parameters.AddWithValue("@FK_EventId_Payment", EventId);
                command.Parameters.AddWithValue("@FK_UserId_Payment", userId);
                Events = GetAllEvents();
                amount += Payments[EventId-1].Amount;
                foreach (PropertyInfo property in properties)
                {
                    object value = property.GetValue(Payments[EventId-1]);
                    if (property.Name.Equals("Amount"))
                        command.Parameters.AddWithValue("@" + property.Name, amount);
                    else if(property.Name.Equals("PaymentStatus"))
                    {
                        if (amount >= (Convert.ToInt16(Events[EventId-1].EventFeeContribution) + Convert.ToInt16(Events[EventId-1].AttendanceFineAmount)))
                            command.Parameters.AddWithValue("@" + property.Name, "Paid");
                        else
                            command.Parameters.AddWithValue("@" + property.Name, "Pending");
                    }
                    else if (!property.Name.Equals("FK_EventId_Payment") && !property.Name.Equals("FK_UserId_Payment"))
                        command.Parameters.AddWithValue("@" + property.Name, value);    
                }
                MessageBox.Show(command.ToString());
                command.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        public List<Payment> GetUserPayments(String userId)
        {
            if(!UserExists(userId))
                throw new ArgumentException("User does not exist");
            if(EstablishConnection())
            {
                Payments.Clear();
                String sql = "SELECT * FROM system.payment WHERE FK_UserId_Payment = @FK_UserId_Payment";
                MySqlCommand command = new MySqlCommand(sql, Connection);
                command.Parameters.AddWithValue("@FK_UserId_Payment", userId);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Payments.Add(new Payment((int)reader["PaymentId"], (DateTime)reader["PaymentDate"], (float)reader["Amount"], (string)reader["PaymentStatus"], (string)reader["FK_UserId_Payment"], (int)reader["FK_EventId_Payment"]));
                }
                reader.Close();
                return Payments;
            }
            return null;
        }
        public bool PaymentExists(int EventId, string userId)
        {
            foreach (Payment p in Payments)
            {
                if (p.FK_EventId_Payment == EventId && p.FK_UserId_EventAttendance == userId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
