using System;
using System.Collections.Generic;
using Microsoft.Maui.Graphics;


namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. " +
                            "In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and " +
                            "communication, and the messenger of the gods. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://starlust.org/wp-content/uploads/2023/07/planet-mercury.webp",
                    "https://griffithobservatory.org/wp-content/uploads/2021/03/Mercury_fin_flood_LD_V3-1600x844.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Of all the planets, Venus is the one most similar to Earth. In fact, " +
                            "Venus is often called Earth's “sister” planet. As similar as it is in some ways, " +
                            "however, it is also very different in others. ",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/RifjtkFLBEFgzkZqWEh69P-1200-80.jpg",
                    "https://starwalk.space/gallery/images/amazing-planet-venus/1920x1080.jpg",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSRIK8HsPuD9mo2NePF9ZOpGjGFeHeB5g41wUYG51uCFvewSBAv4Fl1ZBGgYjBhNMjsJaA&usqp=CAU"

                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species " +
                            "of animals and plants have been discovered so far, and many more have yet to be found. While other " +
                            "planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions " +
                            "for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://res.cloudinary.com/jerrick/image/upload/d_642250b563292b35f27461a7.png,f_jpg,fl_progressive,q_auto,w_1024/63e0ae1d227cb3001dcfcedd.jpg",
                    "https://www.farmersalmanac.com/wp-content/uploads/2020/11/Exceptional-earth.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much as Mars. " +
                            "It may be the reddish color of Mars, or the fact that it can often be easily seen " +
                            "in the night sky, that has caused people to wonder about this close neighbor of ours. " +
                            "Tales of “Martians” invading Earth have been around for well over fifty years. But is " +
                            "it likely that any kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://www.worldatlas.com/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.frostscience.org/wp-content/uploads/2023/01/Mars-blog-header-1024x576.png",
                    "https://miro.medium.com/v2/resize:fit:1200/1*2n6yiV0A8p8Lyk55gId23Q.jpeg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. " +
                            "It is a gas giant with a mass more than 2.5 times that of all the other planets in the Solar " +
                            "System combined, and slightly less than one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://i0.wp.com/geolearn.in/wp-content/uploads/2020/12/image-187.png?fit=614%2C384&ssl=1",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfNDiO-vgPbwZ_hn1-urOWQw-4FYyXVcH1mA&s",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5Mc_u3Kd8JZkjGM4D5CVkfPxisrORr-bWhg&s"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second largest in the Solar System, " +
                            "after Jupiter. It is a gas giant, with an average radius of about nine times that of Earth. Saturn's " +
                            "interior is thought to be composed of a rocky core, surrounded by a deep layer of metallic hydrogen, " +
                            "an intermediate layer of liquid hydrogen and liquid helium, and an outer layer of gas.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://cf-img-a-in.tosshub.com/sites/visualstory/wp/2024/06/Saturn1.jpeg?size=*:900",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRl5NX24CQTZ0OB9T9BYoA2xlI2fc2bTUDAHA&s",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1elU2tkBub1odubHywTxL1StYHoGRsv_Dww&s"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. " +
                            "Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which " +
                            "astronomy calls 'ice' or volatiles. The planet's atmosphere has a complex layered cloud structure and " +
                            "has the lowest minimum temperature (49 K (?224 °C; ?371 °F)) of all the Solar System's planets.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTO6KXc87281zVEO7z9cUId7-nqBOglXNdgyA&s",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSG8CQzihe85ZwOPAGBE-JooA_hDUGirVmeHw&s",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdhFjYwfwG7-4c3mT-TB-y8JutZC_i6_cv0Q&s"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest known planet from the Sun. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the third-most-massive planet, " +
                            "and the densest giant planet. It is 17 times the mass of Earth and slightly more massive, " +
                            "but denser and smaller, than fellow ice giant Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOE0lFUuYQKRPDF5Jnpw40XpyuOUpKfLLXBA&s",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKYtK1rw-bMdomPmONkGk3cREGm79I_nSPJg&s",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1hyWzldCX3g_BWDTb-chlv-2elXM90qbZcw&s"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "Once known as the ninth planet, now classified as a dwarf planet",
                HeroImage = "pluto.png",
                Description = "Discovered in 1930, Pluto was long considered our solar system's ninth planet until its " +
                "reclassification in 2006. With a diameter of about 2,377 kilometers, this icy world orbits the Sun at an average " +
                "distance of 5.9 billion kilometers, taking 248 Earth years to complete one orbit. Despite its small size, " +
                "Pluto has five known moons, with Charon being the largest.",
                AccentColorStart = Color.FromArgb("#ae7e60"),
                AccentColorEnd = Color.FromArgb("#bdab9f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/resources/detail_files/933_BIG_P_COLOR_2_TRUE_COLOR1_1980.jpg",
                    "https://www.nasa.gov/wp-content/uploads/2021/06/pia19952-pluto-earth-comparison-2015_0709.webp",
                    "https://science.nasa.gov/wp-content/uploads/2023/01/15pluto_crop_for_blog_4x3.jpg"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "The largest object in the asteroid belt",
                HeroImage = "ceres.png",
                Description = "Located in the asteroid belt between Mars and Jupiter, Ceres was the first asteroid ever " +
                "discovered in 1801. With a diameter of approximately 940 kilometers, it comprises about one-third of the " +
                "asteroid belt's total mass. In 2015, NASA's Dawn spacecraft revealed Ceres has a rocky interior, an ice-rich " +
                "crust, and possibly a subsurface ocean of briny water. Its surface features numerous craters and mysterious " +
                "bright spots composed of salt deposits.",
                AccentColorStart = Color.FromArgb("#686462"),
                AccentColorEnd = Color.FromArgb("#b8b5b3"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/05/PIA22660_ceres.jpg",
                    "https://imgs.search.brave.com/YU9d6KgaVv2-9JJSfKDvzOo6IIxdG1ZFJCQsfR6xFgI/rs:fit:860:0:0/g:ce/aHR0cHM6Ly9tc3Rl/Y2hkcC5jZG4uc2hv/cGlmeS5jb20vcy9m/aWxlcy8xLzA1ODUv/MzM1NS9wcm9kdWN0/cy9hY2NvcmRpb24t/aXRlbS00LTUuanBn/P3Y9MTcwOTcyODUx/MQ",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA22478_modest.jpg"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The rapid spinner with an unusual elongated shape",
                HeroImage = "haumea.png",
                Description = "Discovered in 2004, Haumea is one of the strangest dwarf planets in our solar system. " +
                "Its elongated, egg-like shape results from its incredibly rapid rotation, completing one full turn in " +
                "just under 4 hours. Located in the Kuiper Belt beyond Neptune, Haumea has a diameter equivalent to about " +
                "one-third that of Earth's moon. It features a surface composed largely of crystalline water ice and has " +
                "two known moons, Hi'iaka and Namaka. Uniquely, Haumea is also surrounded by a ring system discovered in 2017.",
                AccentColorStart = Color.FromArgb("#757270"),
                AccentColorEnd = Color.FromArgb("#8b8680"),
                Images = new()
                {
                    "https://imgs.search.brave.com/IQq-XEv57-dHvGF3mK2vtJtFn_pLvg-c3Tl4KFX77eo/rs:fit:860:0:0/g:ce/aHR0cHM6Ly91cGxv/YWQud2lraW1lZGlh/Lm9yZy93aWtpcGVk/aWEvY29tbW9ucy90/aHVtYi9iL2JiL0hh/dW1lYV9yZW5kZXJp/bmcuanBnLzIyMHB4/LUhhdW1lYV9yZW5k/ZXJpbmcuanBn",
                    "https://imgs.search.brave.com/EW69O_iYvd0yq6A_JRwKixk8E64GXqP4bnDNRh0A6Tk/rs:fit:860:0:0/g:ce/aHR0cHM6Ly9pbWFn/ZXMuaW1tZWRpYXRl/Lm9yZy9zaXRlcy9h/bXRob3JpdHkvZmls/ZXMvY29udGVudC8y/Ni8yMDIyL2RlZmF1/bHQvZmlsZXMvdGh1/bWJzL2FydGljbGVz/L2hhdW1lYS5qcGVn/L2hhdW1lYS5qcGVn",
                    "https://www.thoughtco.com/thmb/wBcnaMkdPtKXMx_gL2j-mFuTWbk=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/haumea-dwarf-planet-pluto-4148139-1b5a8478a57f49b5b45a14bed50e0d3c.jpg"
                }
            },
            new()
            {
                Name = "MakeMake",
                Subtitle = "The crimson dwarf of the outer solar system",
                HeroImage = "makemake.png",
                Description = "Named after the creation deity of the Rapa Nui people of Easter Island, Makemake was " +
                "discovered in 2005. This Kuiper Belt object has a reddish hue and a diameter of roughly 1,430 kilometers, " +
                "making it about two-thirds the size of Pluto. Makemake takes approximately 305 Earth years to orbit the " +
                "Sun and has one known moon, discovered in 2016. Its surface is thought to be covered with methane, ethane, " +
                "and possibly nitrogen ices, giving it a reflective appearance that makes it the second brightest Kuiper Belt " +
                "object after Pluto.",
                AccentColorStart = Color.FromArgb("#7c4b34"),
                AccentColorEnd = Color.FromArgb("#9a7567"),
                Images = new()
                {
                    "https://imgs.search.brave.com/b8ER2GgbGFCQcM4zBimUbSYq2WjtDsQdh9EDQIv89Dw/rs:fit:860:0:0/g:ce/aHR0cHM6Ly93d3cu/dGhlc3BhY2VhY2Fk/ZW15Lm9yZy93cC1j/b250ZW50L3VwbG9h/ZHMvMjAyMS8wMi9t/YWtlbWFrZS10aHVt/Ym5haWwuanBn",
                    "https://imgs.search.brave.com/7mTpw3pYNGsBbsOPZbYhx4e0kd98_NmLxoxRn7j-g2M/rs:fit:860:0:0/g:ce/aHR0cHM6Ly9lc29w/aHlzaWNzLm9yZy9p/bWcvZXNvMTI0Ni1N/YWtlbWFrZS1tb29u/LnBuZw",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdVVHIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--bbf69ef3be2e7322681af6c0d5ea8f2f0f9ec3e1/PIA21398.jpg"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "The most massive dwarf planet that changed astronomy",
                HeroImage = "eris.png",
                Description = "Discovered in 2005, Eris caused a scientific revolution that led to the redefinition of " +
                "what constitutes a planet. Despite being slightly smaller in diameter than Pluto at about 2,326 kilometers, " +
                "Eris is approximately 27% more massive, making it the most massive known dwarf planet. Orbiting the Sun at an " +
                "average distance of 96 astronomical units (14.4 billion kilometers), Eris takes about 558 Earth years to " +
                "complete one orbit. Its highly reflective surface is covered with methane ice, and it has one known moon " +
                "named Dysnomia.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://www.go-astronomy.com/images/planets/eris-planet.jpg",
                    "https://solarsystem.nasa.gov/system/stellar_items/image_files/726_feature_1600x900_eris.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/05/eris-dysnomia_composite.jpg"
                }
            }
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets.OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}