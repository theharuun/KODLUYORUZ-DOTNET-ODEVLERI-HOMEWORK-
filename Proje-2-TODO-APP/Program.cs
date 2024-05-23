using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2_TODO_APP
{
    //https://github.com/CNevzat/Patika.dev/blob/main/.NET-Core-Yeni-Baslayanlar/Proje_2_Console_ToDo_Uygulaması/Board.cs
    internal class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("******************");
            Console.WriteLine(""
                + "1- Board Listeleme \n"
                + "2- Board'a Kart Ekleme \n"
                + "3- Board'dan Kart Silme \n"
                + "4- Kart Taşıma \n"
                );
            Console.WriteLine("******************");
        }


        public enum buyukluk
                {
                 XS=1,
                 S,
                 M,
                 L,
                XL
                }
        public enum tur
        {
            TODO=1,
            IN_PROGRESS,
            DONE
        }
        public class takimUyesi{
            public string uyeAdi { get; set; }
            public int uyeId { get; set; }

            public takimUyesi(int uyeId, string uyeAdi )
            {
                this.uyeAdi = uyeAdi;
                this.uyeId = uyeId;
            }
        }

        public class Kart
        {
            public string Baslik { get; set; }
            public string Icerik { get; set; }
            public tur Tur { get; set; }
            public buyukluk Boyut { get; set; }
            public takimUyesi Uye { get; set; }

            public Kart(string baslik, string icerik, tur tur,buyukluk boyut,takimUyesi uye)
            {
                this .Baslik = baslik;
                this .Icerik = icerik;
                this .Tur = tur;
                this.Boyut= boyut;
                this.Uye = uye;
            }
        }

        public class Board
        {
            private List<Kart> Karts { get; set; }
            private List<takimUyesi> Uyeler { get; set; }

           public Board()
            {
                Uyeler = new List<takimUyesi>()
                {
                   new takimUyesi(1,"harun"),
                   new takimUyesi(2,"omer"),
                   new takimUyesi(3,"samet"),
                   new takimUyesi(4,"ezgi")

                };
            

                Karts = new List<Kart>()
                {

                    new Kart("yazilim1","Patika",tur.TODO,buyukluk.XS,Uyeler[0]),
                    new Kart("yazilim2","FrontEnd",tur.IN_PROGRESS,buyukluk.L,Uyeler[1]),
                    new Kart("yazilim3","BackEnd",tur.IN_PROGRESS,buyukluk.L,Uyeler[2]),


                };
            }

            public void KartEkle()
            {

                bool secimIsValid = false;
                Console.WriteLine("*** KART EKLEME ***");
                Console.Write("Başlık Giriniz: ");
                string title = Console.ReadLine();
                Console.Write("İçerik Giriniz: ");
                string content = Console.ReadLine();
                Console.Write("Büyüklük Giriniz: ");
                int size = int.Parse(Console.ReadLine());
                Console.Write("Atama yapmak istediğiniz kişinin ID'sini giriniz: ");
                int id = int.Parse(Console.ReadLine());
                takimUyesi teamMember = IdyeGoreGetir(id);

                while (!secimIsValid) //Secimin kontrolünün sağlanması
                {
                    Console.Write("Tür Giriniz -> 1- ToDo 2- In Progress 3- Done	 : ");
                    int secim = int.Parse(Console.ReadLine());
                    if (secim == 1)
                    {
                        Kart card = new Kart(title, content, (tur)secim, (buyukluk)size, teamMember);
                        Karts.Add(card);
                        secimIsValid = true;
                    }
                    else if (secim == 2)
                    {
                        Kart card = new Kart(title, content, (tur)secim, (buyukluk)size, teamMember);
                        Karts.Add(card);
                        secimIsValid = true;
                    }
                    else if (secim == 3)
                    {
                        Kart card = new Kart(title, content, (tur)secim, (buyukluk)size, teamMember);
                        Karts.Add(card);
                        secimIsValid = true;
                    }
                    else { Console.WriteLine("Hatalı Seçim Yaptınız"); }
                }
            }
            public takimUyesi IdyeGoreGetir(int id)
            {
                return Uyeler.Find(x => x.uyeId == id);
            }
            public Kart basligaGoreGetir(string title)
            {
                return Karts.Find(x => x.Baslik == title);
            }
            public void List()
            {
                Console.WriteLine("*** LİST ***");
                Console.WriteLine("TODO Line");
               kartTipineGoreListele(tur.TODO);
                Console.WriteLine("*******");
                Console.WriteLine("INPROGRESS Line");
               kartTipineGoreListele(tur.IN_PROGRESS);
                Console.WriteLine("*******");
                Console.WriteLine("DONE Line");
               kartTipineGoreListele(tur.DONE);
            }
            public void kartTipineGoreListele(tur type)
            {
                int i = 1;
                foreach (var item in Karts)
                {
                    if (item.Tur == type)
                    {
                        Console.WriteLine("Başlık: " + item.Baslik);
                        Console.WriteLine("İçerik: " + item.Icerik);
                        Console.WriteLine("Atanan Kişi: " + item.Uye.uyeAdi);
                        Console.WriteLine("Size: " + item.Boyut);
                        Console.WriteLine("-");
                        i++;
                    }
                }
            }
            public void KartSil()
            {
                Console.WriteLine("*** KART SİLME ***");
                Console.WriteLine("***********************");
                Console.Write("Silmek istediğiniz kartın başlığını giriniz: ");
                Kart silinecek = basligaGoreGetir(Console.ReadLine());

                if (silinecek != null) {Karts.Remove(silinecek); Console.WriteLine("Kart başarıyla silindi"); }
                else
                { Console.WriteLine("Kart Bulunamadı"); }
            }
            public void KartTasi()
            {
                Console.WriteLine("*** KART TAŞIMA ***");
                Console.Write("Taşımak istediğiniz kartın başlığını yazınız: ");
                string title = Console.ReadLine();
                Kart tasinacak =basligaGoreGetir(title);

                if (tasinacak != null)
                {
                    Console.WriteLine("Aradığınız kart bulundu");
                    Console.WriteLine("Kart Bilgileri: " +
                        "Baslık:" + tasinacak.Baslik +
                        " İçerik:" + tasinacak.Icerik +
                        " Atanan Kişi:" + tasinacak.Uye.uyeAdi +
                        " Büyüklük:" + tasinacak.Boyut);

                    Console.WriteLine("Taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) INPROGRESS (3) DONE");
                    int lineSecim = int.Parse(Console.ReadLine());
                    if (lineSecim == 1)
                    {
                        tasinacak.Tur = tur.TODO;
                        List();
                    }
                    else if (lineSecim == 2)
                    {
                        tasinacak.Tur = tur.IN_PROGRESS;
                        List();
                    }
                    else if (lineSecim == 3)
                    {
                        tasinacak.Tur = tur.DONE;
                        List();
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız kart bulunamadı\n" +
                        "Lütfen bir seçim yapınız.\n" +
                        "İşlemi sonlandırmak için : (1)\n" +
                        "Yeniden denemek için     : (2)");
                    int secim = int.Parse(Console.ReadLine());
                    if (secim == 1)
                    {
                        //Menu Çağrılcak
                    }
                    else if (secim == 2)
                    {
                        KartTasi();
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim yaptınız");
                    }
                }
            }
        }
       
        static void Main(string[] args)
        {
            Board board = new Board();
            Menu(); // Açılışta kullanıcını menuyu görüntüler
            int input;
            //Kullanıcı menu ekranında yanlış giriş yaptığı sürece menu tekrarlanır
            while ((!int.TryParse(Console.ReadLine(), out input)) || input < 0 || input > 4)
            {
                Menu();
            }
            switch (input)
            {
                case 1:
                    board.List();
                    break;

                case 2:
                    board.KartEkle();
                    break;

                case 3:
                    board.KartSil();
                    break;

                case 4:
                    board.KartTasi();
                    break;

                default:
                    Console.WriteLine("Hatalı seçim yaptınız!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
