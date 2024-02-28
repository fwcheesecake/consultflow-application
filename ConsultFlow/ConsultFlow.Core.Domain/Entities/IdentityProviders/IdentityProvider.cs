namespace ConsultFlow.Core.Domain.Entities.IdentityProviders
{
    public class IdentityProvider
    {
        public Guid Id { get; private set; }
        public IdentityProviderType Type {  get; private set; }
        public string Name { get; private set; }

        public IdentityProvider(Guid id, IdentityProviderType type, string name)
        {
            Id = id;
            Type = type;
            Name = name;
        }
    }
}
