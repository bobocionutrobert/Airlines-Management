using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines_Management.Model
{
    public class Passager : User
    {

        private int idpassager;
        private string mobile;
        private string username;
        private string password;

        

        public Passager(int idpassager, string mobile,string username,string password,int id,string type,string name,string email,string address):base(id,"Passager",name,email,address)
        {
            this.idpassager = idpassager;
            this.mobile = mobile;
            this.username = username;
            this.password = password;
                
        }

        public Passager(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.idpassager = Int32.Parse(prop[5]);
            this.mobile = prop[6];
            this.username = prop[7];
            this.password = prop[8];
        }
        public Passager()
        {

        }

        public int Idpassager
        {
            get { return this.idpassager; }
            set { this.idpassager = value; }
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
            return base.ToString() + "," + this.idpassager+","+this.mobile+","+this.username+","+this.password;
        }
    }
}
