using System;
using System.IO;
using System.Windows.Forms;

namespace Custom_Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SendMail sendMail = new SendMail();
        public void CheckText(string text)//kullanıcıdan geleck parametre
        {
            foreach (char item in text)//döngü ile gelen parametreyi karakter karakter dolaşıyoruz sayı var mı diye
            {
                if (char.IsDigit(item))//gelen değerlerden biri digit ise if devrreye girecek
                {
                    throw new HasNumber(text);//custome hatamızı fırlatacağız
                }
            }
        }
        public void WriteListVeriGirisi()
        {
            listView1.Items.Clear();
            StreamReader streamReader = new StreamReader(Application.StartupPath + @"\log.txt");
            string[] exceptions = streamReader.ReadToEnd().Split(new string[] { "\r\n" },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in exceptions)
            {
                string[] degerler = item.Split('|');
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = degerler[0];
                listViewItem.SubItems.Add(degerler[1]);
                listViewItem.SubItems.Add(degerler[2]);

                listView1.Items.Add(listViewItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            streamReader.Close();

        }
        private void BtnVeriGirisi_Click(object sender, EventArgs e)
        {
            try
            {
                CheckText(txtVeriGirisi.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtVeriGirisi,ex.Message);
                sendMail.SendErrorMail();
                WriteListVeriGirisi();
            }
        }
    }
}
