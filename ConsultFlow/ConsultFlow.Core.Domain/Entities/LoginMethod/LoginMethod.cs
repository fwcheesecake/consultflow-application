using ConsultFlow.Core.Domain.Entities.IdentityProviders;

namespace ConsultFlow.Core.Domain.Entities.LoginMethod
{
    public class LoginMethod
    {
        public string LoginType { get; private set; }
        public string IsConfirmed { get; private set; }
        public string ConfirmedAt { get; private set; }

        public void ConfirmLoginMethod() { }
    }

    public class EmailLogin : LoginMethod
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public void ChangePassword() { }
    }

    public class PhoneLogin : LoginMethod {
        public string PhoneNumber { get; private set; }
        public string ConfirmationCode { get; private set; }

        public void SendConfirmationCode() { }
    }

    public class ExternalLogin: LoginMethod {
        public IdentityProvider IdentityProvider { get; private set; }

        public void RedirectToProvider() { }
    }
}
