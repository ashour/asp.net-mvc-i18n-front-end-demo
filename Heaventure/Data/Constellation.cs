using System;
using System.Collections.Generic;

namespace Heaventure.Data
{
    public class Constellation
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string ImageUrl { get; private set; }
        public int StarCount { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public static List<Constellation> All()
        {
            return new List<Constellation>()
            {
                new Constellation() {
                    Id = 1,
                    Name = "Capricornus",
                    Description = "Capricornus /ˌkæprɪˈkɔːrnəs/ is one of the constellations of the zodiac. Its name is Latin for \"horned goat\" or \"goat horn\" or \"having horns like a goat's\", and it is commonly represented in the form of a sea goat: a mythical creature that is half goat, half fish. Its symbol is Capricorn.svg (Unicode ♑).",
                    ImageUrl = "~/Content/Images/Capricornus.png",
                    StarCount = 3,
                    CreatedAt = new DateTime(2020, 04, 22)
                },
                new Constellation() {
                    Id = 2,
                    Name = "Aries",
                    Description = "Aries is one of the constellations of the zodiac. It is located in the Northern celestial hemisphere between Pisces to the west and Taurus to the east. The name Aries is Latin for ram, and its symbol is Aries.svg (Unicode ♈), representing a ram's horns.",
                    ImageUrl = "~/Content/Images/Aries.png",
                    StarCount = 18,
                    CreatedAt = new DateTime(2020, 04, 20)
                },
                new Constellation()
                {
                    Id = 3,
                    Name = "Hydrus",
                    Description = "Hydrus /ˈhaɪdrəs/ is a small constellation in the deep southern sky. It was one of twelve constellations created by Petrus Plancius from the observations of Pieter Dirkszoon Keyser and Frederick de Houtman.",
                    ImageUrl = "~/Content/Images/Hydrus.png",
                    StarCount = 18,
                    CreatedAt = new DateTime(2020, 03, 30)
                },
                new Constellation()
                {
                    Id = 4,
                    Name = "Puppis",
                    Description = "Puppis /ˈpʌpɪs/ is a constellation in the southern sky. Puppis, the Poop Deck, was originally part of an over-large constellation, the ship of Jason and the Argonauts, Argo Navis, which centuries after its initial description, was divided into three parts, the other two being Carina (the keel and hull), and Vela (the sails of the ship).",
                    ImageUrl = "~/Content/Images/Puppis.png",
                    StarCount = 9,
                    CreatedAt = new DateTime(2020, 04, 14)
                },
                new Constellation()
                {
                    Id = 5,
                    Name = "Telescopium",
                    Description = "Telescopium is a minor constellation in the southern celestial hemisphere, one of twelve named in the 18th century by French astronomer Nicolas-Louis de Lacaille and one of several depicting scientific instruments. Its name is a Latinized form of the Greek word for telescope.",
                    ImageUrl = "~/Content/Images/Telescopium.png",
                    StarCount = 2,
                    CreatedAt = new DateTime(2020, 04, 19)
                },
                new Constellation()
                {
                    Id = 6,
                    Name = "Ursa Major",
                    Description = "Ursa Major (/ˈɜːrsə ˈmeɪdʒər/; also known as the Great Bear) is a constellation in the northern sky, whose associated mythology likely dates back into prehistory. Its Latin name means \"greater (or larger) she-bear,\" referring to and contrasting it with nearby Ursa Minor, the lesser bear.",
                    ImageUrl = "~/Content/Images/UrsaMajor.png",
                    StarCount = 20,
                    CreatedAt = new DateTime(2020, 03, 21)
                }
            };
        }

        public static Constellation FindById(int id) => 
            All().Find(constellation => constellation.Id == id);

    }
}