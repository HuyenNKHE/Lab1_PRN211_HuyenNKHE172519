using System;

namespace BusinessObject
{
    public class MemberObject
    {
        // Define data members
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        // Example of business rule: Password should have a minimum length
        private const int MinPasswordLength = 6;

        // Method to validate password
        public static bool ValidatePassword(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= MinPasswordLength;
        }

        // Add more business rules as needed
    }
}
