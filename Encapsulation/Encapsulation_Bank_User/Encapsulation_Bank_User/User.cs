using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation_Bank_User
{
    public class User
    {
        public Guid Id { get => Guid.NewGuid(); }
        public string UserName { get; set; }
        private DateTime _createTime=DateTime.Now;
        public DateTime CreateTime 
        {
            get { return _createTime; }
            set { _createTime = value; }
        }
        private double _balance;
        public double Balance 
        {
            get => _balance;
            set
            {
                if (value<0)
                {
                    MessageBox.Show("The balance can not be negative");
                }
                else
                {
                    _balance = value;
                }
            }
        }

    }
}
