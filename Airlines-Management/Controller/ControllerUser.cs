using Airlines_Management.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Airlines_Management.Controller
{
    public class ControllerUser
    {
        private List<User> users;

        public ControllerUser()
        {
            users = new List<User>();
            load();
        }


        public int positionById(int id)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public User user(int id)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public bool addUser(User user)
        {
            int poz = positionById(user.Id);

            if (poz != -1)
            {
                return false;
            }
            else
            {
                users.Add(user);
                return true;
            }
        }

        public bool deleteUser(int userid)
        {
            int poz = positionById(userid);

            if (poz == 1)
            {
                return false;
            }
            else
            {

                users.RemoveAt(poz);
                return true;
            }
        }

        public void updateType(int id, string type)
        {

            foreach(User user in users)
            {
                if(user.Id == id)
                {
                    user.Type = type;
                }
            }

        }

        public void updateName(int id, string name)
        {

            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.Name = name;
                }
            }

        }

        public void updateAddress(int id, string address)
        {

            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.Address = address;
                }
            }

        }

        public void updateEmail(int id, string email)
        {

            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.Email = email;
                }
            }

        }

        public void updatePassagerMobile(int id, string mobile)
        {
            foreach(User user in users)
            {
                if(user.Id == id)
                {
                    Passager passager = user as Passager;
                    passager.Mobile = mobile;
                }
            }
        }

        public void updatePassagerUsername(int id, string username)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Passager passager = user as Passager;
                    passager.Username = username;
                }
            }
        }

        public void updatePassagerPassword(int id, string password)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Passager passager = user as Passager;
                    passager.Password = password;
                }
            }
        }


        public void updateEmployeeMobile(int id, string mobile)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Employee employee = user as Employee;

                    employee.Mobile = mobile;
                }
            }
        }

        public void updateEmployeeUsername(int id, string username)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Employee employee = user as Employee;

                    employee.Username = username;
                }
            }
        }

        public void updateEmployeePassword(int id, string password)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    Employee employee = user as Employee;

                    employee.Password = password;
                }
            }
        }




        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Airlines-Management\Airlines-Management\Resources\users.txt");


            string line = "";


            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                if (prop[1].Equals("Passager"))
                {
                    this.users.Add(new Passager(line));

                }
                else
                {
                    this.users.Add(new Employee(line));
                }
            }
            read.Close();
        }

        public override string ToString()
        {
            string text = "";

            this.users.ForEach((user) =>
            {

                text += user.ToString() + "\n";


            });

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Airlines-Management\Airlines-Management\Resources\users.txt");
            write.WriteLine(ToString());
            write.Close();
        }
    }
}
