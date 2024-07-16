
using System.Data.SqlClient;
using System.Data;
using System;

namespace DataLayer
{

    public partial class clsTasks
    {

        public static bool AddTask(string Title, string data, int userD, int CotogD, int replayD, string reminderData, int priorityD)
        {
            SqlConnection connection = new SqlConnection(Common.ConnectionString());
            string Query = @"INSERT INTO Tasks (TITLE,DATAVALUE,USERID,CATEGORIZEID,REPEATID,LISTID,
             RemindData,PriorityID)VALUES(@Title, @data,@userD,@CotogD,@replayD,@LISTID,@RemindData,@PriorityID)";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@data", data);
            command.Parameters.AddWithValue("@userD", userD);
            command.Parameters.AddWithValue("@CotogD", CotogD);
            command.Parameters.AddWithValue("@replayD", replayD);
            command.Parameters.AddWithValue("@LISTID", System.DBNull.Value);
            command.Parameters.AddWithValue("@RemindData", reminderData);
            command.Parameters.AddWithValue("@PriorityID", priorityD);
            int Rows = 0;
            try
            {
                connection.Open();
                Rows = command.ExecuteNonQuery();
            }
            catch (SqlException ex) { Console.WriteLine("Error : " + ex); }
            finally { connection.Close(); }
            return Rows > 0;
        }

        public static bool DeleteTask(int TaskID)
        {
            SqlConnection connection = new SqlConnection(Common.ConnectionString());
            string Query = @"DELETE FROM Tasks WHERE TASKID = @TaskID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TaskID", TaskID);
            int Rows = 0;
            try
            {
                connection.Open();
                Rows = command.ExecuteNonQuery();
            }
            catch (SqlException ex) { Console.WriteLine("Error : " + ex); }
            finally { connection.Close(); }
            return Rows > 0;
        }

        public static bool UpdateTask(int TaskID, string Title, string data, int userD,
            int CotogD, int replayD, int ListD, string reminderData, int priorityD)

        {
            SqlConnection connection = new SqlConnection(Common.ConnectionString());
            string Query = @"UPDATE Tasks SET TITLE = @Title,DATAVALUE = @data,
                   USERID = @userD ,CATEGORIZEID =  @CotogD,REPEATID = @replayD ,
                   LISTID =  @LISTID, RemindData = @RemindData ,PriorityID = @PriorityID
                    WHERE TASKID = @TaskID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TaskID", TaskID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@data", data);
            command.Parameters.AddWithValue("@userD", userD);
            command.Parameters.AddWithValue("@CotogD", CotogD);
            command.Parameters.AddWithValue("@replayD", replayD);
            command.Parameters.AddWithValue("@LISTID", ListD);
            command.Parameters.AddWithValue("@RemindData", reminderData);
            command.Parameters.AddWithValue("@PriorityID", priorityD);
            int Rows = 0;
            try
            {
                if (ListD == -1)
                {
                    command.Parameters.AddWithValue("@LISTID", System.DBNull.Value);
                }

                connection.Open();
                Rows = command.ExecuteNonQuery();
            }
            catch (SqlException ex) { Console.WriteLine("Error : " + ex); }
            finally { connection.Close(); }
            return Rows > 0;
        }

        private static DataTable GetAllTasks(int USERID, string AddQuery)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Common.ConnectionString());
            string Query = @"SELECT * FROM TasksData WHERE USERID = @USERID";
            // = @USERID AND AND Priority = @AddQuery
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@USERID", USERID);
            // command.Parameters.AddWithValue("@AddQuery", AddQuery);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }


        public static DataTable GetAllTasks(int USERID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Common.ConnectionString());
            string Query = @"SELECT * FROM TasksData WHERE  USERID = @USERID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@USERID", USERID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex) { Console.WriteLine("Error " + ex); }
            finally { connection.Close(); }
            return dt;
        }

        public static int CountTasks(int userID)
        {
            SqlConnection connection = new SqlConnection(Common.ConnectionString());
            string Query = "SELECT count(*) FROM TasksData WHERE USERID = @userID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@userID", userID);
            int number = 0;
            try
            {
                connection.Open();
                object reader = command.ExecuteScalar();
                if (reader != null) { number = (int)reader; }
            }
            catch { }
            finally { connection.Close(); }
            return number;
        }

        public static DataTable GetAllTasksTitle(int USERID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Common.ConnectionString());
            string Query = @"SELECT TITLE FROM TasksData WHERE USERID = @USERID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@USERID", USERID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }

        //public static string[] GetTasksTitle(int USERID)
        //{
        //    string[] dt = new string[CountTasks(USERID)];
        //    SqlConnection connection = new SqlConnection(Common.ConnectionString());
        //    string Query = @"SELECT TITLE FROM TasksData WHERE USERID = @USERID";
        //    SqlCommand command = new SqlCommand(Query, connection);
        //    command.Parameters.AddWithValue("@TaskID", USERID);
        //    try
        //    {
        //        int index = 0;
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            dt[index] = (string)reader[0];
        //        }
        //    }
        //    catch { }
        //    finally { connection.Close(); }
        //    return dt;
        //}


        public static DataTable GetImportantTasks(int USERID)
        {
            return GetAllTasks(USERID, "Important");
        }


        public static DataTable GetNormalTasks(int USERID)
        {
            return GetAllTasks(USERID, "Normal");
        }


        public static DataTable GetPlannedTasks(int USERID)
        {
            return GetAllTasks(USERID, "Planned");
        }



        public static DataTable GetMyDayTasks(int USERID)
        {
            return GetAllTasks(USERID, "MyDay");
        }

        public static DataTable FindTask(int TaskID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Common.ConnectionString());
            string Query = @"SELECT * FROM TasksData WHERE TASKID = @TaskID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TaskID", TaskID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }

        public static DataTable GetTaskByTitle(string Title)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Common.ConnectionString());
            string Query = @"SELECT * FROM TasksData WHERE TITLE = @Title";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Title", Title);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }



    }





}









