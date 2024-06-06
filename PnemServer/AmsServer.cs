

using Opc.Ua;
using Opc.Ua.Server;

namespace AmsOpcUaServer
{
    public partial class AmsServer : StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the Node Managers");
            List<INodeManager> nodeManagers = new List<INodeManager>();
            nodeManagers.Add(new AmsNodeManager(server, configuration));

            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }

        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties();

            properties.ManufacturerName = "Nortura";
            properties.ProductName = "AMS Example Server";
            properties.ProductUri = "http://nortura.no/AmsInformationModel/";
            properties.SoftwareVersion = Utils.GetAssemblySoftwareVersion();
            properties.BuildNumber = Utils.GetAssemblyBuildNumber();
            properties.BuildDate = Utils.GetAssemblyTimestamp();

            // TBD - All applications have software certificates that need to added to the properties.
            return properties;
        }
    }
}
