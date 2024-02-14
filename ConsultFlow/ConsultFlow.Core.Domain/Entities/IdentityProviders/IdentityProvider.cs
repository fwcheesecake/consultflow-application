namespace ConsultFlow.Core.Domain.Entities.IdentityProviders
{
    public class IdentityProvider
    {
        public string ProviderId { get; private set; }
        public string Provider {  get; private set; }
        public string ProviderName { get; private set; }

        public IdentityProvider(string providerId, string provider, string providerName)
        {
            ProviderId = providerId;
            Provider = provider;
            ProviderName = providerName;
        }
    }
}
