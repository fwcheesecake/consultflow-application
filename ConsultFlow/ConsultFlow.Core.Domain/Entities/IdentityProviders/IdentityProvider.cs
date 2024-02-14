namespace ConsultFlow.Core.Domain.Entities.IdentityProviders
{
    public class IdentityProvider
    {
        public string Id { get; private set; }
        public IdentityProviderType Type {  get; private set; }
        public string Name { get; private set; }

        public IdentityProvider(string id, IdentityProviderType type, string name)
        {
            Id = id;
            Type = type;
            Name = name;
        }
    }
}
