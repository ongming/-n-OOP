using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Parking_Management_System_sourse
{
    public abstract class Person
    {
        private string id;
        private string firstname;
        private string lastname;
        private int age;
        private string phonenumber;
        private string password;
        private string username;
        public Person(string id,string firstname, string lastname, int age, string phonenumber, string username, string password)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.phonenumber = phonenumber;
            this.password = password;
            this.username = username;
        }
        public string Id { get { return id; } set { id = value; } }
        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Phonenumber { get { return phonenumber; } set { phonenumber = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Username { get { return username; } set { username = value; } }
        public abstract void addID(string id);
    }
}