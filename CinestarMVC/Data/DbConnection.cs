using Microsoft.Data.SqlClient;

public class DbConnection

{
    private static DbConnection? _instance;
    private readonly string _connectionString;

    private DbConnection()
    {
        _connectionString = "Server=tcp:serverbiayo.database.windows.net,1433;Initial Catalog=CineStar;Persist Security Info=False;User ID=admin_senati;Password=123BJB.com;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }

    public static DbConnection? Instance => _instance ?? (_instance = new DbConnection());

    public SQLConnection GetConnection() => new SQLConnection(_connectionString);  
}