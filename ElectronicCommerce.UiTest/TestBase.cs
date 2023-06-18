namespace ElectronicCommerce.UiTest;

public static class TestBase {
    private static EdgeDriver driver = null!;
    private static EdgeDriverService service = null!;

    public static EdgeDriver Driver {
        get {
            if (driver == null!) {
                driver = new EdgeDriver(Service);
                driver.Url = "https://localhost:7159/";
                Thread.Sleep(3000);
            }
            return driver;
        }
    }

    public static EdgeDriverService Service {
        get {
            if (service == null!) {
                service = EdgeDriverService.CreateDefaultService();
                service.UseVerboseLogging = true;
            }

            return service;
        }
    }
    
}