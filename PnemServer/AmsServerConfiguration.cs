

using Opc.Ua;
using System.Runtime.Serialization;

namespace AmsOpcUaServer
{
    [DataContract(Namespace = "http://nortura.no/AmsInformationModel/")]
    public class AmsServerConfiguration
    {
        public AmsServerConfiguration() 
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
        }

        public static async Task<ApplicationConfiguration> LoadApplicationConfiguration(bool silent)
        {
            string filePath = ApplicationConfiguration.GetFilePathFromAppConfig("AmsServer");

            return await LoadApplicationConfiguration(filePath, silent).ConfigureAwait(false);
        }

        public static async Task<ApplicationConfiguration> LoadApplicationConfiguration(string filePath, bool silent)
        {
            ApplicationConfiguration configuration = null;

            try
            {
                configuration = await LoadAppConfig(
                    silent, filePath, ApplicationType.Server, null, true, null)
                    .ConfigureAwait(false);
            }
            catch (Exception) when (silent)
            {
            }

            if (configuration == null)
            {
                throw ServiceResultException.Create(StatusCodes.BadConfigurationError, "Could not load configuration file.");
            }

            return configuration;
        }

        public static async Task<ApplicationConfiguration> LoadAppConfig(
    bool silent,
    string filePath,
    ApplicationType applicationType,
    Type configurationType,
    bool applyTraceSettings,
    ICertificatePasswordProvider certificatePasswordProvider = null)
        {
            Utils.LogInfo("Loading application configuration file. {0}", filePath);

            try
            {
                // load the configuration file.
                ApplicationConfiguration configuration = await ApplicationConfiguration.Load(
                    new System.IO.FileInfo(filePath),
                    applicationType,
                    configurationType,
                    applyTraceSettings,
                    certificatePasswordProvider)
                    .ConfigureAwait(false);

                if (configuration == null)
                {
                    return null;
                }

                return configuration;
            }
            catch (Exception e)
            {
                Utils.LogError(e, "Could not load configuration file. {0}", filePath);

                return null;
            }
        }
    }
}
