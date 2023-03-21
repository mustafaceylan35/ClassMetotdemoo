using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotdemoo
{
    internal class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri Bilgileri:"+"İsim:"+musteri.name+" Soyisim:"+musteri.surname+" ID:"+musteri.ID+" Yaş:"+musteri.age);
        

        }

        public void Çıkarma(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri Bilgileri:" + "İsim:" + musteri.name + " Soyisim:" + musteri.surname + " ID:" + musteri.ID + " Yaş:" + musteri.age);



        } 
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Listelenen Müşteri Bilgileri:"+"İsim:"+musteri.name+" Soyisim:"+musteri.surname+" ID:"+musteri.ID+" Yaş:"+musteri.age);
        }
           
    }
}
