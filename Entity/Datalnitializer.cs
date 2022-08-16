using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace vizem.Entity
{

    public class Datalnitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler=new List<Category>()
            {
                new Category(){ Name = "Kamera", Description = "Kamera ürünleri" },
                new Category(){ Name = "Bilgisiyar", Description = "Bilgisiyar ürünleri" },
                new Category(){ Name = "Ev ve Yaşam", Description = "Ev ve Yaşam ürünleri" },
                new Category(){ Name = "Mutfak", Description = "Mutfak ürünleri" },
                new Category(){ Name = "Telefon" , Description = "Telefon Ürünleri" },
                new Category(){ Name = "Aaa" , Description = "s Ürünleri" }

             };

            foreach (var kategori in kategoriler) 
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {

                 new Product(){ Name = "Canon Eos 1200D 18-55 mm DC Profesyonel Dijital Fotoğraf Makinesi",Description = "Harika Fotoğraflarınızı Bu Makina Sayesinde Dahada Harikalaştırmanız Elbette Çok Basit.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 1 , Image = "1.jpg"},
                new Product(){ Name = "Canon Eos 100D 18-55 mm DC Profesyonel Fotoğraf Makines",Description = "Harika Fotoğraflarınızı Bu Makina Sayesinde Dahada Harikalaştırmanız Elbette Çok Basit.", Price =3500 , Stock =500 , IsApproved =true , CategoryId = 1, Image = "2.jpg"},
                new Product(){ Name = "Canon Eos 700D 18-55 DC DSLR Fotoğraf Makinesi",Description = "Harika Fotoğraflarınızı Bu Makina Sayesinde Dahada Harikalaştırmanız Elbette Çok Basit.", Price =1500 , Stock =500 , IsApproved =false , CategoryId = 1, Image = "3.jpg"},
                new Product(){ Name = "Canon Eos 100D 18-55 mm IS STM Kit DSLR Fotoğraf Makinesi",Description = "Harika Fotoğraflarınızı Bu Makina Sayesinde Dahada Harikalaştırmanız Elbette Çok Basit.", Price =3100 , Stock =500 , IsApproved =true , CategoryId = 1, Image = "4.jpg"},
                new Product(){ Name = "Canon Eos 700D + 18-55 Is Stm + Çanta + 16 Gb Hafıza Kartı",Description = "Harika Fotoğraflarınızı Bu Makina Sayesinde Dahada Harikalaştırmanız Elbette Çok Basit.", Price =5900 , Stock =500 , IsApproved =false , CategoryId = 1, Image = "5.jpg"},

                new Product(){ Name = "Monster Tulpar v25 Intel Core i5 7200U 8GB 1TB R7 M445 Windows 10 Home 15.6 FHD Taşınabilir Bilgisayar FHDG20W81C",Description = "Oyun Deneyiminizi Zirveye Çıkarın." , Price =11200 , Stock =500 , IsApproved =true , CategoryId = 2, Image = "6.jpg"},
                new Product(){ Name = "Monster Abra v310 Intel Core i7 7500U 12GB 1TB GT920M Windows 10 Home 15.6 Taşınabilir Bilgisayar 80TV028XTX",Description = "Oyun Deneyiminizi Zirveye Çıkarın.", Price =14500 , Stock =1200 , IsApproved =true , CategoryId = 2, Image = "7.jpg", },
                new Product(){ Name = "Monster Abra v3.7 Intel Core i7 7500U 8GB 512GB SSD GT940MX Windows 10 Home 17.3 QHD Taşınabilir Bilgisayar",Description = "Oyun Deneyiminizi Zirveye Çıkarın.", Price =13400 , Stock =0 , IsApproved =false , CategoryId = 2, Image = "8.jpg"},
                new Product(){ Name = "Monster Tulpar v2.5 Intel Core i7 7500U 16GB 512GB SSD GT940MX Windows 10 Home 13.3 QHD Taşınabilir Bilgisayar",Description = "Oyun Deneyiminizi Zirveye Çıkarın.", Price =12500 , Stock =600 , IsApproved =true , CategoryId = 2, Image = "9.jpg"},
                new Product(){ Name = "Monster Abra v52v1 Intel Core i7 7700HQ 16GB 1TB + 128GB SSD GTX1050 Windows 10 Home",Description = "Oyun Deneyiminizi Zirveye Çıkarın.", Price =10000 , Stock =500 , IsApproved =true , CategoryId = 2 , IsHome= true, Image = "10.jpg"},

                new Product(){ Name = "Puf", Description = "Hayatınızı Pratikleştirecek Ev ve Yasam Ürünleri" , Price =20 , Stock =500 , IsApproved =true , CategoryId = 3, Image = "11.jpg"},
                new Product(){ Name = "Yastık",Description = "Hayatınızı Pratikleştirecek Ev ve Yasam Ürünleri", Price =25 , Stock =1200 , IsApproved =true , CategoryId = 3, Image = "12.jpg"},
                new Product(){ Name = "Koltuk",Description = "Hayatınızı Pratikleştirecek Ev ve Yasam Ürünleri", Price =3400 , Stock =0 , IsApproved =false , CategoryId =3 , IsHome= true , Image = "13.jpg"},
                new Product(){ Name = "Halı",Description = "Hayatınızı Pratikleştirecek Ev ve Yasam Ürünleri", Price =250 , Stock =600 , IsApproved =true , CategoryId = 3, Image = "14.jpg"},
                new Product(){ Name = "Ayna",Description = "Hayatınızı Pratikleştirecek Ev ve Yasam Ürünleri.", Price =300 , Stock =500 , IsApproved =true , CategoryId = 3, Image = "15.jpg"},

                new Product(){ Name = "Huni", Description = "Hayatınızı Pratikleştirecek Mutfak Ürünleri" , Price =100 , Stock =500 , IsApproved =true , CategoryId = 4, Image = "16.jpg"},
                new Product(){ Name = "Bıçak",Description = "Hayatınızı Pratikleştirecek Mutfak Ürünleri", Price =15 , Stock =1200 , IsApproved =true , CategoryId = 4, IsHome = true, Image = "17.jpg"}, 
                new Product(){ Name = "Ezici",Description = "Hayatınızı Pratikleştirecek Mutfak Ürünleri", Price =10 , Stock =0 , IsApproved =false , CategoryId =4, Image = "18.jpg"},
                new Product(){ Name = "Tabak",Description = "Hayatınızı Pratikleştirecek Mutfak Ürünleri", Price =19 , Stock =600 , IsApproved =true , CategoryId = 4, IsHome=true, Image = "19.jpg"},
                new Product(){ Name = "Çatal",Description = "Hayatınızı Pratikleştirecek Mutfak Ürünleri.", Price =15 , Stock =500 , IsApproved =true , CategoryId = 4, Image = "20.jpg"},




                new Product(){ Name = "Apple iPhone X 64 GB (Apple Türkiye Garantili)", Description ="Tüm işlemlerinizi gerçekleştirebileceğiniz Akıllı Telefonlar" , Price =10000 , Stock =500 , IsApproved =true , CategoryId = 5, Image = "21.jpg"},
                new Product(){ Name = "Apple iPhone 11 32 GB (Apple Türkiye Garantili)",Description = "Tüm işlemlerinizi gerçekleştirebileceğiniz Akıllı Telefonlar", Price =11000 , Stock =1200 , IsApproved =true , CategoryId = 5, Image = "22.jpg"},
                new Product(){ Name = "Apple iPhone 13 32 GB (Apple Türkiye Garantili)",Description = "Tüm işlemlerinizi gerçekleştirebileceğiniz Akıllı Telefonlar.", Price =15000 , Stock =0 , IsApproved =false , CategoryId =5, Image = "23.jpg"},
                new Product(){ Name = "Apple İphone 12 268GB",Description = "Tüm işlemlerinizi gerçekleştirebileceğiniz Akıllı Telefonlar", Price =2500 , Stock =11000, IsApproved =true , CategoryId = 5, Image = "24.jpg"},
                new Product(){ Name = "Xiaomi Mi 5S 64GB (İthalatçı Garantili)",Description = "Tüm işlemlerinizi gerçekleştirebileceğiniz Akıllı Telefonlar.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 5, IsHome= true, Image = "25.jpg"},



            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}