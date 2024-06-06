

using Opc.Ua;
using Opc.Ua.Server;
using Opc.Ua.PnEm;

namespace AmsOpcUaServer
{
    public class AmsNodeManager : CustomNodeManager2
    {
        private AmsServerConfiguration _configuration;
        private uint _nodeIdCounter;
        private System.Threading.Timer _simulationTimer;

        public AmsNodeManager (IServerInternal server, ApplicationConfiguration configuration)
            : base (server, configuration)
        {
            SystemContext.NodeIdFactory = this;
            var namespaceUrls = new string[1];
            namespaceUrls[0] = "http://nortura.no/amspnemmodel/";
            SetNamespaces(namespaceUrls);

            _configuration = configuration.ParseExtension<AmsServerConfiguration>();

            if (_configuration == null)
                _configuration = new AmsServerConfiguration();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if(_simulationTimer != null)
                {
                    Utils.SilentDispose(_simulationTimer);
                    _simulationTimer = null;
                }
            }
        }

        public override NodeId New(ISystemContext context, NodeState node)
        {
            return new NodeId(++_nodeIdCounter, NamespaceIndexes[0]);
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "Model\\nortura.no.amspnemmodel.PredefinedNodes.uanodes",
                typeof(AmsNodeManager).GetType().Assembly,
                true);
            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            LoadPredefinedNodes(SystemContext, externalReferences);

            //Init state for el meter
            
            BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(nortura.no.amspnemmodel.Objects.EnergyManagement, NamespaceIndexes[0]), typeof(BaseObjectState));

            var folder = new FolderTypeState();
            folder.Create(SystemContext, passiveNode);

            IList<IReference> references = null;

            if(!externalReferences.TryGetValue(Opc.Ua.ObjectIds.ObjectsFolder, out references))
            {
                externalReferences[Opc.Ua.ObjectIds.ObjectsFolder] = references = new List<IReference>();
            }
            
            _simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);
        }

        public override void DeleteAddressSpace()
        {
            lock (Lock)
            {
                base.DeleteAddressSpace();
            }
        }

        protected override NodeHandle GetManagerHandle(ServerSystemContext context, NodeId nodeId, IDictionary<NodeId, NodeState> cache)
        {
            lock (Lock)
            {
                if (!IsNodeIdInNamespace(nodeId))
                    return null;

                if(PredefinedNodes != null)
                {
                    NodeState node = null;

                    if(PredefinedNodes.TryGetValue(nodeId, out node))
                    {
                        NodeHandle handle = new NodeHandle();

                        handle.NodeId = nodeId;
                        handle.Validated = true;
                        handle.Node = node;

                        return handle;
                    }
                }

                return null;
            }

        }

        protected override NodeState ValidateNode(ServerSystemContext context, NodeHandle handle, IDictionary<NodeId, NodeState> cache)
        {
            if (handle == null)
                return null;

            if (handle.Validated)
                return handle.Node;

            return null;
        }

        private void DoSimulation(object state)
        {
            //Console.WriteLine("Simulating");
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error during simulation: " + ex.ToString());
            }
        }
    }
}
