using ConsultFlow.Core.Domain.Entities.IdentityProviders;

namespace ConsultFlow.Core.Domain.Entities.LoginMethod
{
    public abstract class LoginMethod
    {
        public string LoginType { get; private set; }
        public bool IsConfirmed { get; private set; }
        public DateTime? ConfirmedAt { get; private set; }

        protected LoginMethod(string loginType, bool isConfirmed, DateTime? confirmedAt)
        {
            LoginType = loginType;
            IsConfirmed = isConfirmed;
            ConfirmedAt = confirmedAt;
        }

        public void ConfirmLoginMethod() { }
    }

    public class EmailLogin : LoginMethod
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public EmailLogin(string loginType, bool isConfirmed, DateTime? confirmedAt, string email, string password) : base (loginType, isConfirmed, confirmedAt)
        {
            Email = email;
            Password = password;
        }

        public void ChangePassword() { }
    }

    public class PhoneLogin : LoginMethod {
        public string PhoneNumber { get; private set; }
        public string ConfirmationCode { get; private set; }

        public PhoneLogin(string loginType, bool isConfirmed, DateTime? confirmedAt, string phoneNumber, string confirmationCode) : base(loginType, isConfirmed, confirmedAt)
        {
            PhoneNumber = phoneNumber;
            ConfirmationCode = confirmationCode;
        }

        public void SendConfirmationCode() { }
    }

    public class ExternalLogin: LoginMethod {
        public IdentityProvider IdentityProvider { get; private set; }

        public ExternalLogin(string loginType, bool isConfirmed, DateTime? confirmedAt, IdentityProvider identityProvider) : base(loginType, isConfirmed, confirmedAt)
        {
            IdentityProvider = identityProvider;
        }

        public void RedirectToProvider() { }
    }
}
