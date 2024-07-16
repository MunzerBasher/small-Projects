

public class clsNode
{


    public static bool AddNode(string title,int taskID,string date)
    {
        if(DataNodes.AddNode(title,taskID,date))   
            return true;
        return false;
    }

    public static string GetNode(int taskID)
    {
        return DataNodes.GetNode(taskID);
    }

    public static string GetFilePass(int  taskID)
    {
        return DataNodes.GetFilePass(taskID);
    }

    public static bool UpdateNote(int taskID,string note)
    {
        return DataNodes.UpdateNode(taskID,note);
    }

    public static bool updateFilePass(int taskID,string pass)
    {
        return DataNodes.UpdateFilePass(taskID,pass);
    }


}
