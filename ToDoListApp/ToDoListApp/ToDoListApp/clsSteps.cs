
using System.Data;

public class clsStep
{

    public static bool AddStep(string title, int taskID, string date)
    {
        if (DataSteps.AddSteps(title, taskID, date))
            return true;
        return false;
    }

    public static string GetStep(int taskID)
    {
        return DataSteps.GetStep(taskID);
    }

}
