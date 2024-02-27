using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WinFormsApp1.MVVM.Model;

namespace WinFormsApp1.MVVM.ViewModel.Helpers
{
    public class DataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        // CREATE operation for Users table
        public void CreateUser(User u)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", u.Email);
                    command.Parameters.AddWithValue("@Password", u.Password);
                    command.Parameters.AddWithValue("@Role", u.Role);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Schedule> GetSchedulesByUserId(int userId)
        {
            List<Schedule> schedules = new List<Schedule>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Schedule.*, Masters.MasterName, Services.ServiceName, Services.Price " +
                               "FROM Schedule " +
                               "JOIN Masters ON Schedule.MasterId = Masters.MasterId " +
                               "JOIN Services ON Schedule.ServiceId = Services.ServiceId " +
                               "WHERE Schedule.UserId = @UserId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Schedule schedule = new Schedule
                            {
                                ScheduleId = Convert.ToInt32(reader["ScheduleId"]),
                                MasterId = Convert.ToInt32(reader["MasterId"]),
                                ServiceId = Convert.ToInt32(reader["ServiceId"]),
                                Date = Convert.ToDateTime(reader["Date"]),
                                Time = TimeSpan.Parse(reader["Time"].ToString()),
                                UserId = Convert.ToInt32(reader["UserId"]), // Add UserId property to the Schedule class
                                Master = new Master { MasterId = Convert.ToInt32(reader["MasterId"]), MasterName = reader["MasterName"].ToString() },
                                Service = new Service { ServiceId = Convert.ToInt32(reader["ServiceId"]), ServiceName = reader["ServiceName"].ToString(), Price = Convert.ToDecimal(reader["Price"]) }
                            };

                            schedules.Add(schedule);
                        }
                    }
                }
            }

            return schedules;
        }

        public User GetUserById(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE UserId = @UserId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User
                            {
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Email = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = reader["Role"].ToString()
                            };

                            return user;
                        }
                    }
                }

                return null; // Возвращаем null, если объект не найден
            }
        }

        // READ operation for Users table
        public ObservableCollection<User> GetUsers()
        {
            ObservableCollection<User> users = new ObservableCollection<User>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Email = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = reader["Role"].ToString()
                            };

                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }

        // UPDATE operation for Users table
        public void UpdateUser(User user)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Users SET Username = @NewUsername, Password = @NewPassword, Role = @NewRole WHERE UserId = @UserId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", user.UserId);
                    command.Parameters.AddWithValue("@NewUsername", user.Email);
                    command.Parameters.AddWithValue("@NewPassword", user.Password);
                    command.Parameters.AddWithValue("@NewRole", user.Role);

                    command.ExecuteNonQuery();
                }
            }
        }

        // DELETE operation for Users table
        public void DeleteUser(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Users WHERE UserId = @UserId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void CreateService(Service s)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Services (ServiceName, Price) VALUES (@ServiceName, @Price)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ServiceName", s.ServiceName);
                    command.Parameters.AddWithValue("@Price", s.Price);

                    command.ExecuteNonQuery();
                }
            }
        }

        // READ operation for Services table
        public ObservableCollection<Service> GetServices()
        {
            ObservableCollection<Service> services = new ObservableCollection<Service>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Services";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Service service = new Service
                            {
                                ServiceId = Convert.ToInt32(reader["ServiceId"]),
                                ServiceName = reader["ServiceName"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"])
                            };

                            services.Add(service);
                        }
                    }
                }
            }

            return services;
        }

        // UPDATE operation for Services table
        public void UpdateService(Service service)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Services SET ServiceName = @NewServiceName, Price = @NewPrice WHERE ServiceId = @ServiceId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ServiceId", service.ServiceId);
                    command.Parameters.AddWithValue("@NewServiceName", service.ServiceName);
                    command.Parameters.AddWithValue("@NewPrice", service.Price);

                    command.ExecuteNonQuery();
                }
            }
        }

        // DELETE operation for Services table
        public void DeleteService(int serviceId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Services WHERE ServiceId = @ServiceId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ServiceId", serviceId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Возникла ошибка: {e.Message}");
                throw;
            }
        }
        public void CreateMaster(Master m)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Masters (MasterName) VALUES (@MasterName)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MasterName", m.MasterName);

                    command.ExecuteNonQuery();
                }
            }
        }

        // READ operation for Masters table
        public ObservableCollection<Master> GetMasters()
        {
            ObservableCollection<Master> masters = new ObservableCollection<Master>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Masters";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Master master = new Master
                            {
                                MasterId = Convert.ToInt32(reader["MasterId"]),
                                MasterName = reader["MasterName"].ToString()
                            };

                            masters.Add(master);
                        }
                    }
                }
            }

            return masters;
        }

        // UPDATE operation for Masters table
        public void UpdateMaster(Master master)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Masters SET MasterName = @NewMasterName WHERE MasterId = @MasterId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MasterId", master.MasterId);
                    command.Parameters.AddWithValue("@NewMasterName", master.MasterName);

                    command.ExecuteNonQuery();
                }
            }
        }

        // DELETE operation for Masters table
        public void DeleteMaster(int masterId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Masters WHERE MasterId = @MasterId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MasterId", masterId);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"Возникла ошибка: {e.Message}");
                        throw;
                    }

                }
            }
        }
        public void CreateSchedule(Schedule s)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Schedule (MasterId, ServiceId, Date, Time, UserId) VALUES (@MasterId, @ServiceId, @Date, @Time, @UserId)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MasterId", s.MasterId);
                    command.Parameters.AddWithValue("@ServiceId", s.ServiceId);
                    command.Parameters.AddWithValue("@Date", s.Date);
                    command.Parameters.AddWithValue("@Time", s.Time);
                    command.Parameters.AddWithValue("@UserId", s.UserId);

                    command.ExecuteNonQuery();
                }
            }
        }

        // READ operation for Schedule table with Master and Service details
        public ObservableCollection<Schedule> GetSchedules()
        {
            ObservableCollection<Schedule> schedules = new ObservableCollection<Schedule>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Schedule.*, Masters.MasterName, Services.ServiceName, Services.Price " +
                               "FROM Schedule " +
                               "JOIN Masters ON Schedule.MasterId = Masters.MasterId " +
                               "JOIN Services ON Schedule.ServiceId = Services.ServiceId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Schedule schedule = new Schedule
                            {
                                ScheduleId = Convert.ToInt32(reader["ScheduleId"]),
                                MasterId = Convert.ToInt32(reader["MasterId"]),
                                UserId = Convert.ToInt32(reader["UserId"]),
                                ServiceId = Convert.ToInt32(reader["ServiceId"]),
                                Date = Convert.ToDateTime(reader["Date"]),
                                Time = TimeSpan.Parse(reader["Time"].ToString()),
                                Master = new Master { MasterId = Convert.ToInt32(reader["MasterId"]), MasterName = reader["MasterName"].ToString() },
                                Service = new Service { ServiceId = Convert.ToInt32(reader["ServiceId"]), ServiceName = reader["ServiceName"].ToString(), Price = Convert.ToDecimal(reader["Price"]) }
                            };

                            schedules.Add(schedule);
                        }
                    }
                }
            }

            return schedules;
        }

        // UPDATE operation for Schedule table
        public void UpdateSchedule(Schedule schedule)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Schedule SET MasterId = @NewMasterId, ServiceId = @NewServiceId, Date = @NewDate, Time = @NewTime, UserId = @NewUserId WHERE ScheduleId = @ScheduleId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ScheduleId", schedule.ScheduleId);
                    command.Parameters.AddWithValue("@NewMasterId", schedule.MasterId);
                    command.Parameters.AddWithValue("@NewServiceId", schedule.ServiceId);
                    command.Parameters.AddWithValue("@NewDate", schedule.Date);
                    command.Parameters.AddWithValue("@NewTime", schedule.Time);
                    command.Parameters.AddWithValue("@NewUserId", schedule.UserId);

                    command.ExecuteNonQuery();
                }
            }
        }

        // DELETE operation for Schedule table
        public void DeleteSchedule(int scheduleId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Schedule WHERE ScheduleId = @ScheduleId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ScheduleId", scheduleId);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
