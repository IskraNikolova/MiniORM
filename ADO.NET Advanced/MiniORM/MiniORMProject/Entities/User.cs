namespace MiniORMProject.Entities
{
    using System;
    using Attributes;

    [Entity(TableName = "Users")]
    public class User
    {
        [Id]
        private int id;

        [Column(ColumnName = "Username")]
        private string username;

        [Column(ColumnName = "Password")]
        private string password;

        [Column(ColumnName = "Age")]
        private int age;

        [Column(ColumnName = "RegistrationDate")]
        private DateTime registrationDate;

        public User(string username, string password, int age, DateTime registrationDate)
        {
            this.Username = username;
            this.Password = password;
            this.Age = age;
            this.RegistrationDate = registrationDate;
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
