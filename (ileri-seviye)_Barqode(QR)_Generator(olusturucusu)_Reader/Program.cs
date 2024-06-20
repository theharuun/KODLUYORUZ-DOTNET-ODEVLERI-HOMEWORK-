using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using ZXing;


namespace _ileri_seviye__Barqode_QR__Generator_olusturucusu__Reader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan metin girişi al
            Console.WriteLine("Lütfen barcode oluşturmak için bir metin girin:");
            string inputText = Console.ReadLine();

            // Barcode oluştur
            var barcodeGenerator = new BarcodeGenerator();
            var barcodeBitmap = barcodeGenerator.GenerateBarcode(inputText);

            // Barcode'u kaydet ve dosya adını al
            string fileName = SaveBarcodeImage(barcodeBitmap);

            // Barcode metnini dosyaya ekle
            string textFileName = "barcode_values.txt";
            string textFilePath = Path.Combine(Directory.GetCurrentDirectory(), textFileName);
            AddBarcodeValueToFile(textFilePath, fileName, inputText);

            // Sonucu ekrana yazdır
            Console.WriteLine($"Oluşturulan barcode text: {inputText}");
            Console.WriteLine($"Barcode görseli '{fileName}' dosyasına kaydedildi.");
            Console.WriteLine($"Barcode metni '{textFileName}' dosyasına eklendi.");

            Console.ReadLine();
        }
        static string SaveBarcodeImage(Bitmap barcodeBitmap)
        {
            // Benzersiz dosya adı oluştur
            string fileName = $"barcode_{DateTime.Now:yyyyMMddHHmmssfff}.png"; // Örneğin: barcode_20240620123456789.png

            // Dosyayı kaydet
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            barcodeBitmap.Save(filePath);

            return fileName;
        }

        static void AddBarcodeValueToFile(string filePath, string fileName, string inputText)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"Dosya Adı: {fileName}");
                writer.WriteLine($"Metin: {inputText}");
                writer.WriteLine(new string('-', 20)); // Araya ayırıcı ekleyebilirsiniz
            }
        }


        public class BarcodeGenerator
        {
          
            public Bitmap GenerateBarcode(string text)
            {
                var writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.CODE_128,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Width = 300,
                        Height = 100
                    }
                };

                return writer.Write(text);
            }
        }

        public class BarcodeReaderExample
        {
            public string ReadBarcode(Bitmap bitmap)
            {
                var reader = new BarcodeReader();
                var result = reader.Decode(bitmap);
                return result?.Text;
            }
        }
    }
}
