using Pulumi;
using Pulumi.AzureNative.DataReplication;

namespace Kinderworx.ComponentResources.Keyvault
{
    /// <summary>
    ///
    /// </summary>
    public class Keyvault : Pulumi.ComponentResource
    {
        public Keyvault(string type, string name, ComponentResourceOptions? options = null) : base(type, name, options)
        {
            VaultArgs vaultArgs = new VaultArgs();
            vaultArgs.VaultName = "";
            vaultArgs.ResourceGroupName

            Pulumi.AzureNative.KeyVault.Vault keyVault
                = new Pulumi.AzureNative.KeyVault.Vault("", vaultArgs,
                );

        }

        public Keyvault(string type, string name, ResourceArgs? args, ComponentResourceOptions? options = null, bool remote = false) : base(type, name, args, options, remote)
        {
        }
    }
}
