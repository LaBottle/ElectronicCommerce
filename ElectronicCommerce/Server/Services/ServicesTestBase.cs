namespace ElectronicCommerce.Server.Services;

public static class ServicesTestBase {
    private const string ConnectionString =
        "server=localhost\\sqlexpress;database=electronic_commerce;trusted_connection=true;";

    private static DataContext db = null!;

    public static DataContext DataContext {
        get {
            if (db == null!) {
                db = new DataContext(
                    new DbContextOptionsBuilder<DataContext>()
                       .UseSqlServer(ConnectionString).Options);
            }

            return db;
        }
    } 
}