using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_Implementaton
{
    public class User
    {
        public string Name { get; set; }
        public string  Surname { get; set; }
        public int Age { get; set; }
        public string  Adress { get; set; }

        public User()
        {
            MessageBox.Show("Here is an user..!");

        }

        public User(int age)
        {
            this.Age = age;
            if (age<18)
            {
                MessageBox.Show("You can not register..!");

            }
            else
            {
                MessageBox.Show("You registered successfuly..!");

            }
            
        }
        public User(string name, string surname,int age, string adress)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Adress = adress;
            MessageBox.Show($"Name :{name}\n Surname :{surname}\n Age :{age}\n Adress :{adress} ");
        }
    }
    
}
