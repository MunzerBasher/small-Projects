using System.Data;

public class clsTask
{

    public int ID { get; set; }
    public string Title { get; set; }
    public string Data { get; set; }
    public int UserID { get; set; }
    public int CotogID { get; set; }
    public int ReplayID { get; set; }
    public int ListID { get; set; }
    public string ReminderData { get; set; }
    public int PriorityID { get; set; }

    public clsTask(string Title, string data, int userD,
        int CotogD, int replayD, int ListD, string reminderData, int priorityD)

    {
        this.Title = Title;
        this.Data = data;
        this.UserID = userD;
        this.ReminderData = reminderData;
        this.PriorityID = priorityD;
        this.CotogID = CotogD;
        this.ReplayID = replayD;
        this.ListID = ListD;
    }

    private clsTask(int TaskID, string Title, string data, int userD,
        int CotogD, int replayD, int ListD, string reminderData, int priorityD)

    {
        this.ID = TaskID;
        this.Title = Title;
        this.Data = data;
        this.UserID = userD;
        this.ReminderData = reminderData;
        this.PriorityID = priorityD;
        this.CotogID = CotogD;
        this.ReplayID = replayD;
        this.ListID = ListD;

    }


    public static bool AddTask(string Title, string data, int userD,
        int CotogD, int replayD, string reminderData, int priorityD)
    {
        if (DataTasks.AddTask(Title, data, userD, CotogD, replayD, reminderData, priorityD))
            return true;
        return false;
    }


    public static bool DeleteTask(int TaskID)
    {
        if (DataTasks.DeleteTask(TaskID))
            return true;
        return false;
    }
    public static bool DeleteTask(string Title)
    {
        if (DataTasks.DeleteTask(Title))
            return true;
        return false;
    }


    public static bool UpdateTask(int TaskID, string Title, string data, int userD,
        int CotogD, int replayD, int ListD, string reminderData, int priorityD, int Checked,
        string Step, string Note, string FilePass)
    {
        if (DataTasks.UpdateTask(TaskID, Title, data, userD, CotogD, replayD, ListD, 
            reminderData, priorityD, Checked, Step, Note, FilePass))
            return true;
        return false;
    }

    public static DataTable GetAllTasks(int UserID)
    {
        return DataTasks.GetAllTasks(UserID);
    }

    public static DataTable GetAllTitles(int user)
    {
        return DataTasks.GetAllTasksTitle(user);
    }

    public static DataTable GetImportantTasks(int USERID)
    {
        return DataTasks.GetImportantTasks(USERID);
    }

    public static DataTable GetPlannedTasks(int USERID)
    {
        return DataTasks.GetPlannedTasks(USERID);

    }

    public static DataTable GetMyDayTasks(int USERID)
    {
        return DataTasks.GetMyDayTasks(USERID);
    }

    public static DataTable GetAssignedToMeTasks(int USERID)
    {
        return DataTasks.GetAssignedToMeTasks(USERID);

    }

    public static bool GetTaskCheckValueByTitle(string title)
    {
        return DataTasks.GetTaskCheckValueByTitle(title);
    }


    public static bool UpdateTasksCheckValue(string title, byte value)
    {
        return DataTasks.UpdateTasksCheckValue(title,value);
    }

    public static int GetTaskIDByTitle(string title) 
    {
        return DataTasks.GetTaskIDByTitle(title);
    }


    public static string GetTaskPriority(int TaskID)
    {
        return DataTasks.GetTaskPriority(TaskID);
    }

    public static bool UpdateTaskPriority(int TaskID, string priority)
    {
        return DataTasks.UpdateTaskPriority(TaskID, priority); 
    }


    public static string GetTaskReplay(int TaskID)
    {
        return DataTasks.GetTaskReplay(TaskID);
    }

    public static string GetTaskNote(int TaskID)
    {
        return DataTasks.GetTaskNote(TaskID);
    }

    public static string GetTaskFilePass(int TaskID)
    {
        return DataTasks.GetTaskFilePass(TaskID);
    }

    public static string GetTaskStep(int TaskID)
    {
        return DataTasks.GetTaskStep(TaskID);
    }

    public static bool UpdateTaskReplay(int TaskID, string Replay)
    {
        return DataTasks.UpdateTaskReplay(TaskID, Replay);
    }

    public static string GetTaskRemindData(int TaskID)
    {
        return DataTasks.GetTaskRemindData(TaskID);
    }

    public static bool UpdateTaskRemindData(int TaskID,string date)
    {
        return DataTasks.UpdateTaskRemindData(TaskID,date);
    }


}
