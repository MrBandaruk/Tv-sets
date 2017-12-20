using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TvSets.Models;

namespace TvSets.Entity
{
    public class TvSetDbInitializer : DropCreateDatabaseIfModelChanges<TvContext>
    {
        //заполнение пустой базы данных
        protected override void Seed(TvContext db)
        {
            Company samsung = new Company("Samsung");
            Company lg = new Company("LG");
            Company phil = new Company("Philips");
            Company sony = new Company("Sony");
            Company horizont = new Company("Horizont");

            db.Companies.AddRange(new List<Company> { samsung, lg, phil, sony, horizont });
            db.SaveChanges();

            Technology lcd = new Technology("LCD");
            Technology oled = new Technology("OLED");
            Technology plasma = new Technology("Plasma");
            Technology proj = new Technology("Projection");
            Technology kin = new Technology("Kinescope");

            db.Technologies.AddRange(new List<Technology> { lcd, oled, plasma, proj, kin });
            db.SaveChanges();

            Tvset item1 = new Tvset
            {
                Name = "UE43MU6100U",
                Year = 2017,
                Size = 43,
                Resolution = "3840x2160",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = samsung,
                Technology = lcd,
                Price = 1164,
                ImageLink = "http://localhost:50567/img/ace78163fd25379cbfe3ef1550e4ba78.jpeg"
            };

            Tvset item2 = new Tvset
            {
                Name = "49SJ810V",
                Year = 2017,
                Size = 49,
                Resolution = "3840x2160",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = lg,
                Technology = oled,
                Price = 1978,
                ImageLink = "http://localhost:50567/img/21a207f0a06f15651b6fec174ef77e8e.jpeg"
            };

            Tvset item3 = new Tvset
            {
                Name = "UE32M5500AU",
                Year = 2016,
                Size = 32,
                Resolution = "1920x1080",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = samsung,
                Technology = lcd,
                Price = 814,
                ImageLink = "http://localhost:50567/img/970eca584f9e2a7d53321435b3115838.jpeg"
            };

            Tvset item4 = new Tvset
            {
                Name = "OLED55B7V",
                Year = 2018,
                Size = 55,
                Resolution = "3840x2160",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = lg,
                Technology = oled,
                Price = 3345,
                ImageLink = "http://localhost:50567/img/261207325.jpeg"
            };

            Tvset item5 = new Tvset
            {
                Name = "UE55J5205AK",
                Year = 2017,
                Size = 55,
                Resolution = "4096x2160",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = samsung,
                Technology = lcd,
                Price = 1420,
                ImageLink = "http://localhost:50567/img/68e584333f6c0d76a59779e4489b5116.jpg"
            };

            Tvset item6 = new Tvset
            {
                Name = "UE32J5205AK",
                Year = 2016,
                Size = 32,
                Resolution = "1920x1080",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = phil,
                Technology = plasma,
                Price = 672,
                ImageLink = "http://localhost:50567/img/c553ef6ca0dc0ad19ceb90508823d4a2.jpg"
            };

            Tvset item7 = new Tvset
            {
                Name = "24MT49S-PZ",
                Year = 2016,
                Size = 24,
                Resolution = "1366x76",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = lg,
                Technology = plasma,
                Price = 469,
                ImageLink = "http://localhost:50567/img/b9b1c80fb5e7f7ac2a49ed67dfad66fc.jpeg"
            };

            Tvset item8 = new Tvset
            {
                Name = "32LJ594U",
                Year = 2016,
                Size = 32,
                Resolution = "1366x768",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = lg,
                Technology = plasma,
                Price = 615,
                ImageLink = "http://localhost:50567/img/fce77ac176b2810ca8ad8ca7a1d4557b.jpeg"
            };

            Tvset item9 = new Tvset
            {
                Name = "40PFT4101/60",
                Year = 2017,
                Size = 40,
                Resolution = "1920x1080",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = phil,
                Technology = oled,
                Price = 750,
                ImageLink = "http://localhost:50567/img/4a4e1aba6ab898d13104e66a573d442b.jpg"
            };

            Tvset item10 = new Tvset
            {
                Name = "KD-55XE9005",
                Year = 2018,
                Size = 55,
                Resolution = "4096x2160",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = sony,
                Technology = lcd,
                Price = 3080,
                ImageLink = "http://localhost:50567/img/1d67603ba92b070ba84003f716c797a0.jpeg"
            };

            Tvset item11 = new Tvset
            {
                Name = "UE32J4500AK",
                Year = 2010,
                Size = 32,
                Resolution = "1920x1080",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = samsung,
                Technology = plasma,
                Price = 250,
                ImageLink = "http://localhost:50567/img/0b4d79c00ca90bfdbeb80462811d4778.jpg"
            };

            Tvset item12 = new Tvset
            {
                Name = "43LE7173D",
                Year = 2015,
                Size = 43,
                Resolution = "1920x1080",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = horizont,
                Technology = plasma,
                Price = 690,
                ImageLink = "http://localhost:50567/img/c72c1c72b24f26ed6dbe6aa8780837d9.jpeg"
            };

            Tvset item13 = new Tvset
            {
                Name = "STAR2000",
                Year = 2000,
                Size = 17,
                Resolution = "800x600",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = horizont,
                Technology = proj,
                Price = 120,
                ImageLink = "http://localhost:50567/img/181725.jpg"
            };

            db.Tvsets.AddRange(new List<Tvset> { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13 });
            db.SaveChanges();
        }
    }
}