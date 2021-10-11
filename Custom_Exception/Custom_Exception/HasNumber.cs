using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Exception
{
    //bu sınıfta kullanıcıdan alınan değerde sayısal bir değer var mı yok mu diyeexepşın oluşturuplog.txt dosyasına kaydedeces.
    public class HasNumber:ApplicationException//yazacağımız custom exception bu sınıftan miras almalı.bu kalıtımdan sonra bizim yazacağımız bu sınıf da bir exc gibi davranacak
    {
        public string  Text { get; set; }
        public HasNumber()
        {

        }
        public HasNumber(string parametre)
        {
            this.Text = parametre;
            GetException();
        }

        public override string Message => "Metin içerisinde sayısal değer ulunmaz..!";
        private void GetException()
        {
            //burada aldığımız excleri not defterine kaydedeceğiz
            string folderUrl = Application.StartupPath + @"\log.txt";
            //projenin bulunduğu dosyanın altına "log.txt" dosyasını yaratmmak için bu yapıyı kullandık.application.startuppath uygulama runtimede iken ilk kez exception alıındıpında bu exceptio kayıt etmek için log.txt yaratılacak.bunun yanında ihtiyaç duyduğumuzda ise bize yolunu verecek.tekrar tekrar oluşşturmayyacak yani

            DateTime exceptionTime = DateTime.Now;//hatanın alındığı sisteöm saaati
            string message = this.Message;//alınan gatanın c#daki gömülü hata mesajını yukarıda override etmemizle bise dönüp log.txtye yazılacak hali.
            string text = this.Text;//hata alınan metin yani kullanıcının girdiği yanlış değerin olduğu kısım

            //log.txt dosyasına yazdırma işlemini stremwriter sınıfının writeline() methodu ile yerine getireceğiz.lakin bu metot bizim senaryomuza göre sadece stringbuilder nesnesi üzerinden değer kabul eder.

            StreamWriter streamWriter = new StreamWriter(folderUrl,true,Encoding.UTF8);
            StringBuilder sp = new StringBuilder();
            sp.Append(text);
            sp.Append("|");
            sp.Append(message);
            sp.Append("|");
            sp.Append(exceptionTime);
            streamWriter.WriteLine(sp.ToString());
            streamWriter.Close();
        }

    }
}
