using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines_Management.Model
{
    public class User
    {

        private int id;
        private string type;
        private string name;
        private string email;
        private string address;
        
        public User(int id,string type,string name,string email,string address)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.email = email;
            this.address = address;
        }

        public User()
        {

        }

        public User(string props)
        {
            string[] prop = props.Split(",");
            this.id = Int32.Parse(prop[0]);
            this.type = prop[1];
            this.name = prop[2];
            this.email = prop[3];
            this.address = prop[4];
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        
        }

        public override string ToString()
        {

            return this.id + "," + this.type + "," + this.name + "," + this.email + "," + this.address;

        }


        public override bool Equals(object obj)
        {

            User user = obj as User;


            return this.id == user.id;
        }
    }
}
