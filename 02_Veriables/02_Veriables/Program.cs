using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDeğişkenler
            double number;
            number = 4.85;
            Console.WriteLine(number);
            Console.WriteLine("************* Fiyat Listesi ***************");
            Console.WriteLine();
            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;
            Console.WriteLine("Elma Birim Fiyatı:" + applePrice + "TL");
            Console.WriteLine("Portakal Birim Fiyatı:" + orangePrice +"TL");
            Console.WriteLine("Çilek Birim Fiyatı:" + strawberryPrice + "TL");
            Console.WriteLine("Patates Birim Fiyatı:" + potatoPrice + "TL");
            Console.WriteLine("Domates Birim Fiyatı:" + tomatoPrice + "TL"  );

            double appleGram, orangeGram, strawberryGram ,potatoGram,tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalprice= orangeGram * orangePrice;
            double strawberryTotalprice= strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;
            Console.WriteLine("Alınan Ürün : Elma - " + "Birim Fiyat: " + applePrice + "-Gramaj: " + appleGram + "Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyat: " + orangePrice + "-Gramaj: " + orangeGram + "Toplam Tutar: " + orangeTotalprice);
            Console.WriteLine("Alınan Ürün : Çilek - " + "Birim Fiyat: " + strawberryPrice + "-Gramaj: " + strawberryGram + "Toplam Tutar: " + strawberryTotalprice);
            Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyat: " + potatoPrice + "-Gramaj: " + potatoGram + "Toplam Tutar: " + potatoTotalPrice);
            Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyat: " + tomatoPrice + "-Gramaj: " + tomatoGram + "Toplam Tutar: " + tomatoTotalPrice);
            double shoppingTotalPrice= appleTotalPrice + orangeTotalprice + strawberryTotalprice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Alışveriş Toplam Tutar : " + shoppingTotalPrice + "TL");
            #endregion
            #region CharDeğişkenler
            char symbol = 'a';
            Console.WriteLine(symbol);
            #region KlavyedenVeriGirişleriStringDeğişkenler
            Console.WriteLine("*************************  CSHARP HAVA YOLLARI YOLCU BİLGİSİ **************************");
            Console.WriteLine();
            String customerName, customerSurname, custoemrDistrict, customerCity, customerAge, customesIdentityNumber;

            Console.Write("Yolcu Adı : ");
            customerName = Console.ReadLine();
            Console.Write("Yolcu Soyadı: ");
            customerSurname = Console.ReadLine();
            Console.Write("İlçe Bilgisi : ");
            custoemrDistrict= Console.ReadLine();
            Console.Write("Şehir Bilgisi: ");
            customerCity = Console.ReadLine();
            Console.Write("Yaş Bilgisi: ");
            customerAge = Console.ReadLine();
            Console.WriteLine("TC Kimlik No : ");
            customesIdentityNumber = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            Console.WriteLine("TC Kimlik No: " + customesIdentityNumber);
            Console.WriteLine("Yolcu Ad Soyad"+customerName + " " + customerSurname + " " + custoemrDistrict + "/" + customerCity + " " + customerAge);






            #endregion

            #endregion
            #region KlavyedenTamSayıGirişleriveDönüşümler
            int shoePrice, computerPrice, chairPrice, tvPrice;
            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;
            int shoeCount, computerCount, chairCount, tvCount;
            Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoeCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoeCount * shoePrice +computerCount * computerPrice + chairCount *chairPrice + tvCount * tvPrice;
            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar : " + totalPrice);







            #endregion
            #region KlavyedenOndalıklıSayıİşlemleri
            double exam1, exam2, exam3, result;
            Console.WriteLine("Lütfen 1.Sınav Notunuzu Giriniz");
            exam1=double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2.Sınav Notunuzu Giriniz");
            exam2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 3.Sınav Notunuzu Giriniz");
            exam3 = double.Parse(Console.ReadLine());
            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız : " + result);


            #endregion
            #region KlavyedenKarakterGirişleri
            char gender;
            Console.WriteLine("Lütfen cinsiyet seçiniz");
            gender=char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);
            Console.Read();
            #endregion

        }
    }
}
