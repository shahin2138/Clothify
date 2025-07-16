using System;

namespace Cazior
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public Guid? EmailVerificationToken { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
