using Opc.Ua;
using Opc.Ua.Configuration;

namespace AmsOpcUaServer
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            ApplicationInstance app = new ApplicationInstance();
            app.ApplicationType = ApplicationType.Server;
            app.ConfigSectionName = "AmsServer";

            try
            {
                app.LoadApplicationConfiguration(false).Wait();
                app.CheckApplicationInstanceCertificate(false, 0).Wait();
                app.Start(new AmsServer()).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("Server started");
            Console.WriteLine("Server available at endpoint: "  + app.Server.GetEndpoints()[0].EndpointUrl);
            Console.WriteLine("\nPress any key to stop");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Stopping server");
            app.Stop();
            app.Server.Dispose();

            Console.WriteLine("Server shut down");
        }
    }
}