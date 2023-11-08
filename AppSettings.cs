namespace AppDocuments;

public class AppSettings
{
    private static string DatabaseName = "database.db";
    private static string DatabaseDirectory = FileSystem.Current.AppDataDirectory;
    public static string DatabasePath = Path.Combine(DatabaseDirectory, DatabaseName);
}
