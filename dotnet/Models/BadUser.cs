using System;

namespace dotnet.Models
{
    public class BadUser
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdateAt { get; set; }
        
        public BadUser(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email is incorrect.");
            }
            if(Email == email)
            {
                return;
            }

            Email = email;
            Update();
        }
        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password is incorrect.");
            }
            if(Password == password)
            {
                return;
            }

            Password = password;
            Update();
        }

        private void Update()
        {
            UpdateAt = DateTime.Now;
        }
    }
}