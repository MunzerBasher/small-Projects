

public class Common
{

  
    private static string connectionString = "Server=.;Database=ToDoListAppDB;User" +
               " Id=sa;Password=sa123456;";

    public static string ConnectionString()
    {
        return connectionString;
    }

}