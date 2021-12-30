using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines_Management.Model
{
    public class Employee : User
    {
        private int idemployee;
        private string mobile;
        private string username;
        private string password;

        public Employee(int idemployee, string mobile, string username, string password, int id, string type, string name, string email, string address) : base(id, "Passager", name, email, address)
        {
            this.idemployee = idemployee;
            this.mobile = mobile;
            this.username = username;
            this.password = password;

        }

        public Employee(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.idemployee = Int32.Parse(prop[5]);
            this.mobile = prop[6];
            this.username = prop[7];
            this.password = prop[8];
        }
        public Employee()
        {

        }

        public int Idemployee
        {
            get { return this.idemployee; }
            set { this.idemployee = value; }
        }

        public string Mobile
        {
            get { return this.mobile; }
            set { this.mobile = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.idemployee + "," + this.mobile + "," + this.username + "," + this.password;
        }
    }
}
