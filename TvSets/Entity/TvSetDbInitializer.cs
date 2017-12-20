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
        protected override void Seed(TvContext db)
        {
            Company sams = new Company
            {
                Name = "Samsung"
            };

            Company lg = new Company
            {
                Name = "LG"
            };

            Company phil = new Company
            {
                Name = "Philips"
            };

            db.Companies.AddRange(new List<Company> { sams, lg, phil });
            db.SaveChanges();

            Technology lcd = new Technology
            {
                Name = "LCD"
            };

            Technology oled = new Technology
            {
                Name = "OLED"
            };

            Technology plasma = new Technology
            {
                Name = "Plasma"
            };

            Technology proj = new Technology
            {
                Name = "Projection"
            };

            Technology kin = new Technology
            {
                Name = "Kinescope"
            };

            db.Technologies.AddRange(new List<Technology> { lcd, oled, plasma, proj, kin });
            db.SaveChanges();

            Tvset item1 = new Tvset
            {
                Name = "Smart TV",
                Year = 2018,
                Size = 55,
                Resolution = "4096x2160",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = sams,
                Technology = lcd,
                Price = 267
            };

            Tvset item2 = new Tvset
            {
                Name = "Super Jet",
                Year = 2018,
                Size = 55,
                Resolution = "4096x2160",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = lg,
                Technology = oled,
                Price = 999
            };

            Tvset item3 = new Tvset
            {
                Name = "P1",
                Year = 1991,
                Size = 15,
                Resolution = "800x600",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = phil,
                Technology = kin,
                Price = 20
            };

            Tvset item4 = new Tvset
            {
                Name = "43LJ595V",
                Year = 2017,
                Size = 43,
                Resolution = "1920x1080",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = lg,
                Technology = oled,
                Price = 750
            };

            Tvset item5 = new Tvset
            {
                Name = "UE32J5205AK",
                Year = 2018,
                Size = 55,
                Resolution = "4096x2160",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = sams,
                Technology = lcd,
                Price = 240
            };

            Tvset item6 = new Tvset
            {
                Name = "UE50KU6000U",
                Year = 2019,
                Size = 23,
                Resolution = "1920x1080",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = phil,
                Technology = oled,
                Price = 250
            };

            Tvset item7 = new Tvset
            {
                Name = "KD-55XE9005",
                Year = 2018,
                Size = 45,
                Resolution = "3840x2160",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = lg,
                Technology = plasma,
                Price = 400
            };

            Tvset item8 = new Tvset
            {
                Name = "43LH570V",
                Year = 2017,
                Size = 35,
                Resolution = "1920x1080",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = sams,
                Technology = oled,
                Price = 790
            };

            db.Tvsets.AddRange(new List<Tvset> { item1, item2, item3, item4, item5, item6, item7, item8 });

            db.SaveChanges();

        }
    }
}