using System;

namespace WpfApp1.Models
{
    class User
    {
        private String Name;
        private String Surname;
        private DateTime Birth;

        public User(string name, string surname, DateTime birth)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Birth = birth;
        }
    }
}
