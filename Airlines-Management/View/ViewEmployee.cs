using Airlines_Management.Controller;
using Airlines_Management.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airlines_Management.View
{
    public class ViewEmployee
    {

        private User user;
        private ControllerBooking controllerbooking;
        private ControllerEnquiry controllerenquiry;
        private ControllerUser controlleruser;

        public ViewEmployee(User user)
        {
            this.user = user;

            controllerbooking = new ControllerBooking();
            controllerenquiry = new ControllerEnquiry();
            controlleruser = new ControllerUser();
        }

        public void menu()
        {
            Console.WriteLine("Press 1 to");
            Console.WriteLine("Press 2 to ");
            Console.WriteLine("Press 3 to ");
            Console.WriteLine("Press 4 to  ");
            Console.WriteLine("Press 5 to ");
            Console.WriteLine("Press 6 to ");
            Console.WriteLine("Press 7 to ");


        }

        public void play()
        {
            bool running = true;
            while (running == true)
            {
                menu();

                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:


                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:


                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                }
            }
        }
    }
}
