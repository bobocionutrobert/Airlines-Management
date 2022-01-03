using Airlines_Management.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Airlines_Management.Controller
{
    public class ControllerEnquiry
    {

        private List<Enquiry> enquiries;

        public ControllerEnquiry()
        {
            enquiries = new List<Enquiry>();


        }

        public int positionById(int id)
        {
            for (int i = 0; i < enquiries.Count; i++)
            {
                if (enquiries[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public Enquiry enquiry(int id)
        {
            foreach (Enquiry enquiry in enquiries)
            {
                if (enquiry.Id == id)
                {
                    return enquiry;
                }
            }
            return null;
        }

        public bool addEnquiry(Enquiry enquiry)
        {
            int poz = positionById(enquiry.Id);

            if (poz != -1)
            {
                return false;
            }
            else
            {
                enquiries.Add(enquiry);
                return true;
            }
        }

        public bool deleteEnquiry(int id)
        {
            int poz = positionById(id);

            if (poz == 1)
            {
                return false;
            }
            else
            {

                enquiries.RemoveAt(poz);
                return true;
            }
        }

        public void updateType(int id, string type)
        {
            foreach(Enquiry enquiry in enquiries)
            {
                if(enquiry.Id == id)
                {
                    enquiry.Type = type;
                }
            }
        }

        public void updateDescription(int id, string description)
        {
            foreach (Enquiry enquiry in enquiries)
            {
                if (enquiry.Id == id)
                {
                    enquiry.Description = description;
                }
            }
        }

        public void updateTitle(int id, string title)
        {
            foreach (Enquiry enquiry in enquiries)
            {
                if (enquiry.Id == id)
                {
                    enquiry.Title = title;
                }
            }
        }

        public void updateBookingDate(int id, string date)
        {
            foreach (Enquiry enquiry in enquiries)
            {
                if (enquiry.Id == id)
                {
                    BookingEnquiry booking = enquiry as BookingEnquiry;
                    booking.Date = date;
                }
            }
        }

        public void updateBookingPrice(int id, int price)
        {
            foreach (Enquiry enquiry in enquiries)
            {
                if (enquiry.Id == id)
                {
                    BookingEnquiry booking = enquiry as BookingEnquiry;
                    booking.Price = price;
                }
            }
        }

        public void updateAirlinesPrice(int id, string date)
        {
            foreach (Enquiry enquiry in enquiries)
            {
                if (enquiry.Id == id)
                {
                    AirlinesEnquiry airlines = enquiry as AirlinesEnquiry;
                    airlines.Date = date;

                }
            }
        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Airlines-Management\Airlines-Management\Resources\enquiries.txt");


            string line = "";


            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                if (prop[1].Equals("Booking"))
                {
                    this.enquiries.Add(new BookingEnquiry(line));

                }
                else
                {
                    this.enquiries.Add(new AirlinesEnquiry(line));
                }
            }
            read.Close();
        }

        public override string ToString()
        {
            string text = "";

            this.enquiries.ForEach((enqiury) =>
            {

                text += enqiury.ToString() + "\n";


            });

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Airlines-Management\Airlines-Management\Resources\enquiries.txt");
            write.WriteLine(ToString());
            write.Close();
        }
    }
}
