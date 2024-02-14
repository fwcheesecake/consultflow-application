﻿namespace ConsultFlow.Core.Domain.Entities.User
{
    public class User
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName { get => FirstName +  LastName; }

        private readonly List<LoginMethod.LoginMethod> loginMethods;

        public void Login() { }

        public void AddLoginMethod() { }

        public void RemoveLoginMethod() { }
    }
}
