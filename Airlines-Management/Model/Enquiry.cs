using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines_Management.Model
{
    public class Enquiry
    {
        private int id;
        private string type;
        private string description;
        private string title;

        public Enquiry(int id, string type, string description, string title)
        {
            this.id = id;
            this.type = type;
            this.description = description;
            this.title = title;
        }

        public Enquiry(string props)
        {
            string[] prop = props.Split(",");

            this.id = Int32.Parse(prop[0]);
            this.type = prop[1];
            this.description = prop[2];
            this.title = prop[3];
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

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public override string ToString()
        {

            return this.id + "," + this.type + "," + this.description + "," + this.title;

        }


        public override bool Equals(object obj)
        {

            Enquiry enquiry = obj as Enquiry;


            return this.id == enquiry.id;
        }
    }
}
