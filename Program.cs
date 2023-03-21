namespace ClassMetotdemoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.name = "Mustafa";
            musteri1.surname = "Ceylan";
            musteri1.ID = 555;
            musteri1.age = 18;

            Musteri musteri2 = new Musteri();

            musteri2.name = "Elif";
            musteri2.surname = "Koç";
            musteri2.ID = 666;
            musteri2.age = 30;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşterinin İsmi:"+musteri.name);
                Console.WriteLine("Müşterinin Soyismi:"+musteri.surname);
                Console.WriteLine("Müşterinin ID'si:"+musteri.ID);
                Console.WriteLine("Müşterinin yaşı:"+musteri.age);
                Console.WriteLine("***************");
            }


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekleme(musteri1);
            musteriManager.Ekleme(musteri2);
            Console.WriteLine("***************");

            musteriManager.Çıkarma(musteri1);
            musteriManager.Çıkarma(musteri2);
            Console.WriteLine("*****************");

            musteriManager.Listeleme(musteri1);
            musteriManager.Listeleme(musteri2);


            Console.ReadLine();
        }
    }
}