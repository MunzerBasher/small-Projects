
using System.Data;

public class clsPriorities
{
    public static DataTable GetAllPriorities()
    {
        return DataPriority.GetAllPriorities();

    }

    public static int GetPriorityIndex(string Title)
    {
        return DataPriority.GetPriorityIndex(Title);
    }

}