using System;

namespace cubetimer.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Firstname))
                {
                    throw new ArgumentNullException(nameof(Firstname));
                }

                if (string.IsNullOrWhiteSpace(Lastname))
                {
                    throw new ArgumentNullException(nameof(Lastname));
                }

                return $"{Firstname} {Lastname}";
            }
        }
        
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
    }
}