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
                Technology = lcd              
            };

            Tvset item2 = new Tvset
            {
                Name = "Super Jet",
                Year = 2018,
                Size = 55,
                Resolution = "4096x2160",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = lg,
                Technology = oled
            };

            Tvset item3 = new Tvset
            {
                Name = "P1",
                Year = 1991,
                Size = 15,
                Resolution = "800x600",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = phil,
                Technology = kin
            };

            Tvset item4 = new Tvset
            {
                Name = "Smart TV",
                Year = 2017,
                Size = 35,
                Resolution = "1920x1080",
                Details = "A television set, more commonly called a television, TV, TV set, television receiver, or telly, is a device that combines a tuner, display, and loudspeakers for the purpose of viewing television. Introduced in the late 1920s in mechanical form, television sets became a popular consumer product after World War II in electronic form, using cathode ray tubes. The addition of color to broadcast television after 1953 further increased the popularity of television sets in the 1960s",
                Company = sams,
                Technology = oled
            };

            db.Tvsets.AddRange(new List<Tvset> { item1, item2, item3, item4 });

            db.SaveChanges();

        }
    }
}