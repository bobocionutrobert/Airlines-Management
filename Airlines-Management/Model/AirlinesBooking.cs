using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines_Management.Model
{
    public class AirlinesBooking : Enquiry
    {
        private int idbooking;
        private int passagerid;

        public AirlinesBooking(int idbooking,int passagerid, int id,string type,string description,string title) : base(id, "AirlinesBooking", description, title)
        {
            this.idbooking = idbooking;
            this.passagerid = passagerid;
        }

        public AirlinesBooking(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.idbooking = Int32.Parse(prop[4]);
            this.passagerid = Int32.Parse(prop[5]);
        }

        public int Idbooking
        {
            get { return this.idbooking; }
            set { this.idbooking = value; }
        }

        public int Passagerid
        {
            get { return this.passagerid; }
            set { this.passagerid = value; }
        }

        public override string ToString()
        {

            return base.ToString() + "," + this.idbooking + "," + this.passagerid;

        }
    }
}
