using System.Data.SqlClient;
using System.Data;
using System;

public partial class DataTasks
{

    public static bool AddTask(string Title, string data, int userD, int CotogD, int replayD, string reminderData, int priorityD)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"INSERT INTO Tasks (TITLE,DATAVALUE,USERID,CATEGORIZEID,REPEATID,
        LISTID,RemindData,PriorityID,Checked,Step,Note,FilePass)VALUES(@Title, @data,
        @userD,@CotogD,@replayD,@LISTID,@RemindData,@PriorityID,@Checked,@Step,@Note,@FilePass)";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@Title", Title);
        command.Parameters.AddWithValue("@data", data);
        command.Parameters.AddWithValue("@userD", userD);
        command.Parameters.AddWithValue("@CotogD", CotogD);
        command.Parameters.AddWithValue("@replayD", replayD);
        command.Parameters.AddWithValue("@LISTID", System.DBNull.Value);
        command.Parameters.AddWithValue("@RemindData", reminderData);
        command.Parameters.AddWithValue("@PriorityID", priorityD);
        command.Parameters.AddWithValue("@Checked", 0);
        command.Parameters.AddWithValue("@Step", System.DBNull.Value);
        command.Parameters.AddWithValue("@Note", System.DBNull.Value);
        command.Parameters.AddWithValue("@FilePass", System.DBNull.Value);      
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

    public static bool DeleteTask(string Title)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"DELETE FROM Tasks WHERE TITLE = @Title ";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@Title", Title);
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
        int CotogD, int replayD, int ListD, string reminderData, int priorityD,int Checked,
        string Step,string Note,string FilePass)

    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"UPDATE Tasks SET TITLE = @Title,DATAVALUE = @data,
                   USERID = @userD ,CATEGORIZEID =  @CotogD,REPEATID = @replayD ,
                   LISTID =  @LISTID, RemindData = @RemindData ,PriorityID = @PriorityID,
                   Checked=@Checked,Step = @Step,Note = @Note,FilePass=@FilePass
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
        command.Parameters.AddWithValue("@Checked", Checked);
        int Rows = 0;
        try
        {
            if (ListD == -1)
            {
                command.Parameters.AddWithValue("@LISTID", System.DBNull.Value);
            }
            if(Step == "")
                command.Parameters.AddWithValue("@Step", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Step", Step);
            if(Note == "")
                command.Parameters.AddWithValue("@Note", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Note", Note);
            if(FilePass == "")
                command.Parameters.AddWithValue("@FilePass", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@FilePass", FilePass);

            connection.Open();
            Rows = command.ExecuteNonQuery();
        }
        catch { }
        finally { connection.Close(); }
        return Rows > 0;
    }

    public static string GetTaskPriority(int TaskID)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT Priority FROM TasksData WHERE TASKID = @TaskID ";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@TaskID", TaskID);
        string Priority = "";
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) { Priority = (string)reader[0]; }
        }
        catch { }
        finally { connection.Close(); }
        return Priority;
    }

    public static string GetTaskRemindData(int TaskID)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT RemindData FROM Tasks WHERE TASKID = @TaskID ";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@TaskID", TaskID);
        string Priority = "";
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) { Priority = (string)reader[0]; }
        }
        catch { }
        finally { connection.Close(); }
        return Priority;
    }

    public static bool UpdateTaskRemindData(int TaskID, string RemindData)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"UPDATE Tasks SET RemindData=@RemindData WHERE TASKID = @TaskID ";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@TaskID", TaskID);
        command.Parameters.AddWithValue("@priority", RemindData);
        int row = command.ExecuteNonQuery();
        try
        {
            connection.Open();
            row = command.ExecuteNonQuery();
        }
        catch { }
        finally { connection.Close(); }
        return row > 0;
    }


    public static bool UpdateTaskPriority(int TaskID,string priority)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"UPDATE TasksData SET Priority=@priority WHERE TASKID = @TaskID ";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@TaskID", TaskID);
        command.Parameters.AddWithValue("@priority", priority);
        int row = command.ExecuteNonQuery();
        try
        {
            connection.Open();
            row = command.ExecuteNonQuery();
        }
        catch { }
        finally { connection.Close(); }
        return row > 0;
    }

    public static string GetTaskReplay(int TaskID)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT REPLAY FROM TasksData WHERE TASKID = @TaskID ";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@TaskID", TaskID);
        string Priority = "";
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) { Priority = (string)reader[0]; }
        }
        catch { }
        finally { connection.Close(); }
        return Priority;
    }

    public static bool UpdateTaskReplay(int TaskID, string Replay)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"UPDATE TasksData SET REPLAY=@Replay WHERE TASKID = @TaskID ";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@TaskID", TaskID);
        command.Parameters.AddWithValue("@Replay", Replay);
        int row = 0;
        try
        {
   
            connection.Open();
            row = command.ExecuteNonQuery();
        }
        catch { }
        finally { connection.Close(); }
        return row > 0;
    }

    public static string GetTaskNote(int TaskID)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT Note FROM TasksData WHERE TASKID = @TaskID ";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@TaskID", TaskID);
        string Note = "";
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) 
            {
                if(reader[0] != System.DBNull.Value)
                    Note = (string)reader[0]; 
            }
        }
        catch { }
        finally { connection.Close(); }
        return Note;
    }

    public static string GetTaskFilePass(int TaskID)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT FilePass FROM TasksData WHERE TASKID = @TaskID ";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@TaskID", TaskID);
        string FilePass = "";
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader[0] != System.DBNull.Value)
                    FilePass = (string)reader[0];
            }
        }
        catch { }
        finally { connection.Close(); }
        return FilePass;
    }


    public static string GetTaskStep(int TaskID)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT Step FROM TasksData WHERE TASKID = @TaskID ";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@TaskID", TaskID);
        string Step = "";
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader[0] != System.DBNull.Value)
                    Step = (string)reader[0];
            }
        }
        catch { }
        finally { connection.Close(); }
        return Step;
    }


    public static int GetTaskIDByTitle(string Title)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT TASKID FROM TasksData WHERE TITLE = @Title ";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@Title", Title);
        int ID = 0;
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read()) { ID = (int)reader[0]; }
        }
        catch (SqlException ex) { Console.WriteLine("Error : " + ex); }
        finally { connection.Close(); }
        return ID;
    }


    private static DataTable GetAllTasks(int USERID, string AddQuery)
    {
        DataTable dt = new DataTable();
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT * FROM TasksData WHERE USERID =@USERID AND Priority = @AddQuery";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@USERID", USERID);
        command.Parameters.AddWithValue("@AddQuery", AddQuery);
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


    public static DataTable GetImportantTasks(int USERID)
    {
        return GetAllTasks(USERID, "Important");
    }


    public static DataTable GetAssignedToMeTasks(int USERID)
    {
        return GetAllTasks(USERID, "AssignedToMe");
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

    public static bool GetTaskCheckValueByTitle(string Title) 
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT Checked FROM Tasks WHERE TITLE = @Title";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@Title", Title);
        int value = 0;
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                value = (int)reader[0];
            }
        }
        catch { }
        finally { connection.Close(); }
        return value != 0;
    }

    public static bool UpdateTasksCheckValue(string Title , byte check) 
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"UPDATE Checked FROM Tasks SET Checked = check WHERE TITLE = @Title";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@Title", Title);
        command.Parameters.AddWithValue("@check",check);
        int value = 0;
        try
        {
            connection.Open();
            value = command.ExecuteNonQuery();
        }
        catch { }
        finally { connection.Close(); }
        return value > 0;
    }

}


public partial class DataUsers
{

    public int FindUser(string username, string password)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT * FROM  Users WHERE 
                    FIRSTNAME = @username AND USERPASSWORD = @password";
        SqlCommand command = new SqlCommand(Query, connection);
        int UserID = 0;
        try
        {
            connection.Open();
            object ID = command.ExecuteScalar();
            if(ID != null && int.TryParse(ID.ToString(),out int M))
            {
                UserID = M;
            }
        }
        catch { }
        finally { connection.Close(); }
        return UserID;
    }

}


public partial class DataRepeat
{
    public static DataTable GetAllRepeats()
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT TITLE FROM  REPLAY";
        SqlCommand command = new SqlCommand(Query, connection);
        DataTable dt = new DataTable();
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows) 
            {
                dt.Load(reader);
            }
        }
        catch { }
        finally { connection.Close(); }
        return dt;
    }


    public static int  GetRepeatIndex(string Title)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = "SELECT REPLAYID FROM REPLAY WHERE TITLE =@Title";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@Title", Title);
        int Index = 0;
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            { Index = (int)reader[0]; }
        }
        catch { }
        finally { connection.Close(); }
        return Index;
    }
}


public partial class DataPriority
{

    public static DataTable GetAllPriorities()
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT TITLE FROM  Priorities";
        SqlCommand command = new SqlCommand(Query, connection);
        DataTable dt = new DataTable();
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


    public static int GetPriorityIndex(string Title)
    {
        SqlConnection connection = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT PriorityID FROM Priorities WHERE TITLE =@Title";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@Title", Title);
        int Index = 0;
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            { Index = (int)reader[0]; }
        }
        catch { }
        finally { connection.Close(); }
        return Index;
    }
}


public partial class DataNodes
{
    public static bool AddNode(string Title, int TaskID, string FilePass=" ")
    {
        SqlConnection conn = new SqlConnection(Common.ConnectionString());
        string Query = @"INSERT INTO Notes (TITLE,TASKID,FILEPASS)
                    VALUES(@Title,@TaskID,@FilePass)";
        SqlCommand cmd = new SqlCommand(Query, conn);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("@TaskID", TaskID);
        cmd.Parameters.AddWithValue("FilePass", FilePass);
        int rows = 0;
        try
        {
            conn.Open();
            rows = cmd.ExecuteNonQuery();
        }
        catch { }
        finally { conn.Close(); }
        return rows > 0;
    }

    public static string GetNode(int TaskID) 
    {
        SqlConnection conn = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT TITLE FROM Notes WHERE TASKID = @TaskID";
        SqlCommand cmd = new SqlCommand(Query, conn);
        cmd.Parameters.AddWithValue("@TaskID", TaskID);
        string note = "";
        try
        {
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read()) { note = (string)reader["TITLE"]; }
        }
        catch { }
        finally { conn.Close(); }
        return note;
    }

    public static string GetFilePass(int TaskID)
    {
        SqlConnection conn = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT FILEPASS FROM Notes WHERE TASKID = @TaskID";
        SqlCommand cmd = new SqlCommand(Query, conn);
        cmd.Parameters.AddWithValue("@TaskID", TaskID);
        string note = "";
        try
        {
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) { note = (string)reader["TITLE"]; }
        }
        catch { }
        finally { conn.Close(); }
        return note;
    }

    public static bool UpdateFilePass(int TaskID, string FilePass)
    {
        SqlConnection conn = new SqlConnection(Common.ConnectionString());
        string Query = @"UPDATE Notes SET  FILEPASS  = @FilePass WHERE TASKID = @TaskID";
        SqlCommand cmd = new SqlCommand(Query, conn);
        cmd.Parameters.AddWithValue("@TaskID", TaskID);
        cmd.Parameters.AddWithValue("@FilePass", FilePass);
        int rows = 0;   
        try
        {
            conn.Open();
            rows = cmd.ExecuteNonQuery();
        }
        catch { }
        finally { conn.Close(); }
        return rows > 0;
    }

    public static bool UpdateNode(int TaskID, string Node)
    {
        SqlConnection conn = new SqlConnection(Common.ConnectionString());
        string Query = @"UPDATE Notes SET  TITLE  = @Node WHERE TASKID = @TaskID";
        SqlCommand cmd = new SqlCommand(Query, conn);
        cmd.Parameters.AddWithValue("@TaskID", TaskID);
        cmd.Parameters.AddWithValue("@Node", Node);
        int rows = 0;
        try
        {
            conn.Open();
            rows = cmd.ExecuteNonQuery();
        }
        catch { }
        finally { conn.Close(); }
        return rows > 0;
    }

}


public partial class DataSteps
{

    public static bool AddSteps(string Title, int TaskID, string Date)
    {
        SqlConnection conn = new SqlConnection(Common.ConnectionString());
        string Query = @"INSERT INTO Steps (TITLE,DATAVALUE,TASKID)
                    VALUES(@Title,@Date,@TaskID)";
        SqlCommand cmd = new SqlCommand(Query, conn);
        cmd.Parameters.AddWithValue("@Title", Title);
        cmd.Parameters.AddWithValue("Date", Date);
        cmd.Parameters.AddWithValue("@TaskID", TaskID);
        int rows = 0;
        try
        {
            conn.Open();
            rows = cmd.ExecuteNonQuery();
        }
        catch { }
        finally { conn.Close(); }
        return rows > 0;
    }

    public static string GetStep(int TaskID)
    {
        SqlConnection conn = new SqlConnection(Common.ConnectionString());
        string Query = @"SELECT TITLE FROM  Steps  WHERE TASKID = @TaskID";
        SqlCommand cmd = new SqlCommand(Query, conn);
        cmd.Parameters.AddWithValue("@TaskID", TaskID);
        string note = "";
        try
        {
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read()) { note = (string)reader["TITLE"]; }
        }
        catch { }
        finally { conn.Close(); }
        return note;
    }


    public static bool UpdateStep(int TaskID, string Step)
    {
        SqlConnection conn = new SqlConnection(Common.ConnectionString());
        string Query = @"UPDATE Steps SET  TITLE  = @Step WHERE TASKID = @TaskID";
        SqlCommand cmd = new SqlCommand(Query, conn);
        cmd.Parameters.AddWithValue("@TaskID", TaskID);
        cmd.Parameters.AddWithValue("@Step", Step);
        int rows = 0;
        try
        {
            conn.Open();
            rows = cmd.ExecuteNonQuery();
        }
        catch { }
        finally { conn.Close(); }
        return rows > 0;
    }
}
