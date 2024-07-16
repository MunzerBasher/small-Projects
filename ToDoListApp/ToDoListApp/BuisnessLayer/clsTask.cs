using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
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
            if (clsTasks.AddTask(Title, data, userD, CotogD, replayD, reminderData, priorityD))
                return true;
            return false;
        }


        public static bool DeleteTask(int TaskID)
        {
            if (clsTasks.DeleteTask(TaskID))
                return true;
            return false;
        }


        public static bool UpdateTask(int TaskID, string Title, string data, int userD,
            int CotogD, int replayD, int ListD, string reminderData, int priorityD)
        {
            if (clsTasks.UpdateTask(TaskID, Title, data, userD, CotogD, replayD, ListD, reminderData, priorityD))
                return true;
            return false;
        }

        public static DataTable GetAllTasks(int UserID)
        {
            return clsTasks.GetAllTasks(UserID);    
        }

        public static DataTable GetAllTitles(int user)
        {
            return clsTasks.GetAllTasksTitle(user);
        }
    }
}

