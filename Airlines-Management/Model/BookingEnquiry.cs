using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines_Management.Model
{
    public class BookingEnquiry : Enquiry
    {

        private int bookingid;
        private int price;
        private string date;

        public BookingEnquiry(int bookingid, int price, string date, int id, string type, string description, string title) : base(id, "Booking", description, title)
        {
            this.bookingid = bookingid;
            this.price = price;
            this.date = date;
        }

        public BookingEnquiry(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.bookingid = Int32.Parse(prop[4]);
            this.price = Int32.Parse(prop[5]);
            this.date = prop[6];
        }

        public int Bookingid
        {
            get { return this.bookingid; }
            set { this.bookingid = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public override string ToString()
        {

            return base.ToString() + "," + this.bookingid + "," + this.price + "," + this.date;

        }
    }
}
