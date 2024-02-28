using ConsultFlow.Core.Domain.Entities.IdentityProviders;

namespace ConsultFlow.Core.Domain.Entities.LoginMethod
{
    public abstract class LoginMethod
    {
        public LoginType Type { get; private set; }
        public bool IsConfirmed { get; private set; }
        public DateTime? ConfirmedAt { get; private set; }

        protected LoginMethod(LoginType type, bool isConfirmed, DateTime? confirmedAt)
        {
            Type = type;
            IsConfirmed = isConfirmed;
            ConfirmedAt = confirmedAt;
        }

        public void ConfirmLoginMethod() { }
    }

    public class EmailLogin : LoginMethod
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public EmailLogin(LoginType type, bool isConfirmed, DateTime? confirmedAt, string email, string password) : base (type, isConfirmed, confirmedAt)
        {
            Email = email;
            Password = password;
        }

        public void ChangePassword() { }
    }

    public class PhoneLogin : LoginMethod {
        public string PhoneNumber { get; private set; }
        public string ConfirmationCode { get; private set; }

        public PhoneLogin(LoginType type, bool isConfirmed, DateTime? confirmedAt, string phoneNumber, string confirmationCode) : base(type, isConfirmed, confirmedAt)
        {
            PhoneNumber = phoneNumber;
            ConfirmationCode = confirmationCode;
        }

        public void SendConfirmationCode() { }
    }

    public class ExternalLogin: LoginMethod {
        public IdentityProvider IdentityProvider { get; private set; }

        public ExternalLogin(LoginType type, bool isConfirmed, DateTime? confirmedAt, IdentityProvider identityProvider) : base(type, isConfirmed, confirmedAt)
        {
            IdentityProvider = identityProvider;
        }

        public void RedirectToProvider() { }
    }
}
