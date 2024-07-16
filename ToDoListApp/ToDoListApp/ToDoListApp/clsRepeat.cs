
using System.Data;

public class clsRepeats
{

    public static DataTable GetAllRepeats()
    {
        return DataRepeat.GetAllRepeats();
    }

    public static int GetRepeatIndex(string Title)
    {
        return DataRepeat.GetRepeatIndex(Title);
    }

}