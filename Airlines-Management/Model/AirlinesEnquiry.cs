using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines_Management.Model
{
    public class AirlinesEnquiry : Enquiry
    {
        private int airlinesid;
        private string route;
        private string date;

        public AirlinesEnquiry(int airlinesid,string route,string date, int id, string type, string description, string title) : base(id, "Airlines", description, title)
        {
            this.airlinesid = airlinesid;
            this.route = route;
            this.date = date;
        }

        public AirlinesEnquiry(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.airlinesid = Int32.Parse(prop[4]);
            this.route = prop[5];
            this.date = prop[6];
        }

        public int Airlinesid
        {
            get { return this.airlinesid; }
            set { this.airlinesid = value; }
        }

        public string Route
        {
            get { return this.route; }
            set { this.route = value; }
        }

        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public override string ToString()
        {

            return base.ToString() + "," + this.airlinesid + "," + this.route + "," + this.date;

        }
    }
}
