using AppEvaluacion3WEB1._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEvaluacion3WEB1._3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityList : ContentPage
    {
        public IList<Artist> Artistas { get; private set; }
        public ActivityList()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            // Inicializa la lista de artistas
            InitializeList();
        }

        public void InitializeList()
        {
            Artistas = new List<Artist>();

            // Adele
            Artistas.Add(new Artist
            {
                ImagenURL = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/artists/Adele.png",
                Nombre = "Adele",
                Edad = 34,
                Generos = "Blue-eyed | soul | pop pop-soul",
                Discografia = new List<Album>{
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/61jNfu1D+HL._AC_SX569_.jpg",
                        Nombre = "21",
                        Descripcion = "21 es el segundo álbum de estudio de la cantautora británica Adele, con una duración total de 48:12 minutos.",
                        FechaLanzamiento = "Enero 24, 2011",
                        Discografica = "Columbia Records",
                        Generos = "Pop | Soul | Rhythm and blues | R&B contemporáneo",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Rolling in the Deep",
                                Duracion = "3:48"
                            },
                            new Song
                            {
                                Nombre = "Rumour Has It",
                                Duracion = "3:43"
                            },
                            new Song
                            {
                                Nombre = "Turning Tables",
                                Duracion = "4:10"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://cdnb.20m.es/sites/124/2020/05/Adele-25.jpg",
                        Nombre = "25",
                        Descripcion = "25 es el tercer álbum de estudio de la cantautora británica Adele. Cuatro años después del lanzamiento de 21. El álbum se titula como un reflejo de su vida y estado de ánimo a sus 25 años.",
                        FechaLanzamiento = "Noviembre 20, 2015",
                        Discografica = "Columbia Records & XL",
                        Generos = "Pop | Blue-eyed soul | | R&B ",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Hello",
                                Duracion = "4:55"
                            },
                            new Song
                            {
                                Nombre = "I Miss You",
                                Duracion = "5:49"
                            },
                            new Song
                            {
                                Nombre = "When We Were Young",
                                Duracion = "4:51"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://pbs.twimg.com/media/FEkFpZOXwAUz7dI.jpg",
                        Nombre = "30",
                        Descripcion = "30 es el cuarto álbum de estudio de la cantautora británica Adele. Con una duración de 58:15",
                        FechaLanzamiento = "Noviembre 19, 2021",
                        Discografica = "Columbia Records & Melted Stone",
                        Generos = "Pop | Soul | Jazz",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Easy on Me",
                                Duracion = "3:44"
                            },
                            new Song
                            {
                                Nombre = "Strangers by Nature",
                                Duracion = "3:02"
                            },
                            new Song
                            {
                                Nombre = "Oh My God",
                                Duracion = "3:45"
                            }
                        }
                    }
                }
            });

            // Ariana Grande
            Artistas.Add(new Artist
            {
                ImagenURL = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/artists/Ariana%20Grande.png",
                Nombre = "Ariana Grande",
                Edad = 29,
                Generos = "Pop | Dance/Electronica | R&B",
                Discografia = new List<Album>{
                    new Album {
                        ImagenURL = "https://i.pinimg.com/originals/62/c4/01/62c4016e0fded818b56100bf00334e31.jpg",
                        Nombre = "Thank U, Next",
                        Descripcion = "Thank U, Next es el quinto álbum de estudio de la cantante y actriz estadounidense Ariana Grande, con una duración de 41:11 minutos.",
                        FechaLanzamiento = "Febrero 8, 2019",
                        Discografica = "Republic Records",
                        Generos = "Pop | Trap",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "thank u, next",
                                Duracion = "3:27"
                            },
                            new Song {
                                Nombre = "7 rings",
                                Duracion = "2:59"
                            },
                            new Song {
                                Nombre = "bad idea",
                                Duracion = "4:27"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/618f33fE9uL._AC_SL1024_.jpg",
                        Nombre = "Sweetener",
                        Descripcion = "Es el cuarto trabajo discográfico de la cantante estadounidense Ariana Grande. Este está producido por la misma cantante.",
                        FechaLanzamiento = "Agosto 17, 2018",
                        Discografica = "Republic Records",
                        Generos = "Pop | R&B",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "God Is a Woman",
                                Duracion = "3:17"
                            },
                            new Song {
                                Nombre = "No Tears Left to Cry",
                                Duracion = "3:25"
                            },
                            new Song {
                                Nombre = "The Light Is Coming",
                                Duracion = "3:48"
                            }
                        }
                    }, new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/81l-vS-TuxL._AC_SL1500_.jpg",
                        Nombre = "Positions",
                        Descripcion = "Positions es el sexto álbum de estudio de la cantante estadounidense Ariana Grande. Grande creó el álbum con un enfoque en su voz, mientras que el tema transmitía sanación emocional.",
                        FechaLanzamiento = "Octubre 30, 2020",
                        Discografica = "Republic Records",
                        Generos = "Pop | R&B",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "shut up",
                                Duracion = "2:38"
                            },
                            new Song {
                                Nombre = "motive",
                                Duracion = "2:48"
                            },
                            new Song {
                                Nombre = "pov",
                                Duracion = "3:22"
                            }
                        }
                    }
                }
            });

            // Bad Bunny
            Artistas.Add(new Artist
            {
                ImagenURL = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/artists/BadBunny.png",
                Nombre = "Bad Bunny",
                Edad = 28,
                Generos = "Trap latino | Reguetón | hip hop | rap | dancehall",
                Discografia = new List<Album>{
                    new Album {
                        ImagenURL = "https://kubomusical.com/wp-content/uploads/2020/03/b28aff60b7bb76c1c225499b4a3e37b6.999x999x1.jpg",
                        Nombre = "YHLQMDLG",
                        Descripcion = "Es el segundo álbum de estudio en solitario del rapero y cantante puertorriqueño Bad Bunny.",
                        FechaLanzamiento = "Febrero 29, 2020",
                        Discografica = "Rimas Entertainment",
                        Generos = "Reguetón | Trap",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Yo perreo sola",
                                Duracion = "2:52"
                            },
                            new Song {
                                Nombre = "La Zona",
                                Duracion = "2:17"
                            },
                            new Song {
                                Nombre = "Pero ya no",
                                Duracion = "2:41"
                            }
                        }
                    }
                }
            });

            // Billie Eilish
            Artistas.Add(new Artist
            {
                ImagenURL = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/artists/BillieEilish.png",
                Nombre = "Billie Eilish",
                Edad = 20,
                Generos = "Alternativo/Independiente",
                Discografia = new List<Album>{
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/61VFNQJ-HLL._AC_SX679_.jpg",
                        Nombre = "Don't Smile at Me",
                        Descripcion = "Don't Smile at Me, es el primer extended play de la cantante estadounidense Billie Eilish, y contiene varios de sus sencillos lanzados previamente.",
                        FechaLanzamiento = "Agosto 11, 2017",
                        Discografica = "Interscope Records",
                        Generos = "Electropop",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "COPYCAT",
                                Duracion = "3:15"
                            },
                            new Song {
                                Nombre = "party favor",
                                Duracion = "3:25"
                            },
                            new Song {
                                Nombre = "idontwannabeyouanymore",
                                Duracion = "3:24"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/71SHkMeVdhL._AC_SL1500_.jpg",
                        Nombre = "When We All Fall Asleep, Where Do We Go?",
                        Descripcion = "Es el primer álbum de estudio de la cantante estadounidense Billie Eilish.",
                        FechaLanzamiento = "Marzo 19, 2019",
                        Discografica = "Interscope Records",
                        Generos = "Electropop | R&B Alternativo",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "bad guy",
                                Duracion = "3:14"
                            },
                            new Song {
                                Nombre = "all the good girls go to hell",
                                Duracion = "2:49"
                            },
                            new Song {
                                Nombre = "wish you were gay",
                                Duracion = "3:42"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/71laVfWEkCS._SL1400_.jpg",
                        Nombre = "Happier Than Ever",
                        Descripcion = "Happier Than Ever es el segundo álbum de estudio de la cantautora estadounidense Billie Eilish. Sirve como continuación de When We All Fall Asleep, Where Do We Go?.",
                        FechaLanzamiento = "Julio 30, 2021",
                        Discografica = "Interscope Records & Darkroom Records",
                        Generos = "Pop | Electropop",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Getting Older",
                                Duracion = "4:04"
                            },
                            new Song {
                                Nombre = "Billie Bossa Nova",
                                Duracion = "3:17"
                            },
                            new Song {
                                Nombre = "Therefore I Am",
                                Duracion = "2:53"
                            }
                        }
                    }
                }
            });

            // Katy Perry
            Artistas.Add(new Artist
            {
                ImagenURL = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/artists/KatyPerry.png",
                Nombre = "Katy Perry",
                Edad = 37,
                Generos = "Dance/Electronica | Pop",
                Discografia = new List<Album>{
                    new Album {
                        ImagenURL = "https://cloudfront-us-east-1.images.arcpublishing.com/eluniverso/F7BSROR5ONH7LP5FEIFDEYTXIQ.png",
                        Nombre = "Prism",
                        Descripcion = "Prism es el tercer álbum de estudio de la cantante estadounidense Katy Perry.",
                        FechaLanzamiento = "Octubre 22, 2013",
                        Discografica = "Capitol Records",
                        Generos = "R&B/Soul | Pop",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Roar",
                                Duracion = "3:44"
                            },
                            new Song {
                                Nombre = "Dark Horse",
                                Duracion = "3:35"
                            },
                            new Song {
                                Nombre = "Legendary Lovers",
                                Duracion = "3:44"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/71wvFIXFmBL._AC_SL1400_.jpg",
                        Nombre = "Witness",
                        Descripcion = "Witness —en español: Testigo— es el cuarto álbum de estudio de la cantante y compositora estadounidense Katy Perry.",
                        FechaLanzamiento = "Junio 9, 2017",
                        Discografica = "Capital Records",
                        Generos = "Dance pop | Electropop",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Bon appétit",
                                Duracion = "3:48"
                            },
                            new Song {
                                Nombre = "Swish Swish",
                                Duracion = "4:02"
                            },
                            new Song {
                                Nombre = "Witness",
                                Duracion = "4:10"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/71HHknWPulL._AC_SL1200_.jpg",
                        Nombre = "Smile",
                        Descripcion = "Smile —en español: Sonrisa— es el quinto álbum de estudio de la cantante estadounidense Katy Perry.",
                        FechaLanzamiento = "Agosto 28, 2020",
                        Discografica = "Capitol Records",
                        Generos = "Dance-pop  | Pop",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Harleys in Hawaii",
                                Duracion = "3:05"
                            },
                            new Song {
                                Nombre = "Smile",
                                Duracion = "2:47"
                            },
                            new Song {
                                Nombre = "Resilient",
                                Duracion = "3:08"
                            }
                        }
                    }
                }
            });

            // Michael Jackson
            Artistas.Add(new Artist
            {
                ImagenURL = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/artists/MichaelJackson.png",
                Nombre = "Michael Jackson",
                Edad = 50,
                Generos = "Disco | Dance/Electronica | Pop soul | Dance pop | R&B contemporaneo | Funk | Pop | Soul | R&B/Soul",
                Discografia = new List<Album>{
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/81ogsUqshzL._AC_SL1500_.jpg",
                        Nombre = "Thriller",
                        Descripcion = "Thriller es el sexto álbum de estudio del artista estadounidense Michael Jackson.",
                        FechaLanzamiento = "Noviembre 30, 1982",
                        Discografica = "Epic Records",
                        Generos = "Disco | Funk | Pop",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Thriller",
                                Duracion = "5:58"
                            },
                            new Song {
                                Nombre = "Billie jean",
                                Duracion = "4:54"
                            },
                            new Song {
                                Nombre = "Beat It",
                                Duracion = "4:18"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/71rWMh8QHnL._AC_SL1500_.jpg",
                        Nombre = "Bad",
                        Descripcion = "Bad es el séptimo álbum de estudio del cantante estadounidense Michael Jackson. Fue escrito y grabado en un periodo de casi un año.",
                        FechaLanzamiento = "Agosto 31, 1987",
                        Discografica = "Westlake",
                        Generos = "R&B | Funk | Pop | Soul | Dance | Rock",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Smooth Criminal",
                                Duracion = "4:18"
                            },
                            new Song {
                                Nombre = "Bad",
                                Duracion = "4:07"
                            },
                            new Song {
                                Nombre = "I Just Can't Stop Loving You",
                                Duracion = "4:12"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/81umHhwn+TL._SL1500_.jpg",
                        Nombre = "HIStory: Past, Present and Future, Book I",
                        Descripcion = "Es el noveno álbum de estudio del cantante estadounidense Michael Jackson. Con ventas estimadas en 20 millones de copias en el mundo, es uno de los álbumes más vendidos de la historia.",
                        FechaLanzamiento = "Junio 16, 1995",
                        Discografica = "Epic",
                        Generos = "Funk | Pop | Dance ",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "They Don't Care About Us",
                                Duracion = "4:44"
                            },
                            new Song {
                                Nombre = "Earth Song",
                                Duracion = "6:46"
                            },
                            new Song {
                                Nombre = "You Are Not Alone",
                                Duracion = "5:45"
                            }
                        }
                    }
                }
            });

            // Rosalia
            Artistas.Add(new Artist
            {
                ImagenURL = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/artists/Rosalia.png",
                Nombre = "Rosalia",
                Edad = 28,
                Generos = "Alternativa/Independiente | Flamenco | R&B | Art pop | Nuevo Flamento | Regueton",
                Discografia = new List<Album>{
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/61aR4hkkAnL._AC_SL1200_.jpg",
                        Nombre = "El mal querer",
                        Descripcion = "El Mal Querer es el segundo álbum de estudio de la cantautora española Rosalía. Está producido conjuntamente por ella misma y El Guincho.",
                        FechaLanzamiento = "Noviembre 2, 2018",
                        Discografica = "Sony",
                        Generos = "Nuevo flamenco | Experimental pop | Rhythm and blues latino",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "MALAMENTE (Cap.1: Augurio)",
                                Duracion = "2:30"
                            },
                            new Song {
                                Nombre = "Pienso en tu mirá (Cap.3: Celos)",
                                Duracion = "2:30"
                            },
                            new Song {
                                Nombre = "BAGDAD (Cap.7: Liturgia)",
                                Duracion = "2:30"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/61RnZGfoQeL._SL1116_.jpg",
                        Nombre = "Motomami",
                        Descripcion = "Motomami es el tercer álbum de estudio de la cantante española Rosalía.",
                        FechaLanzamiento = "Marzo 18, 2022",
                        Discografica = "Columbia Records",
                        Generos = "Urbano latino | pop",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "SAOKO",
                                Duracion = "2:18"
                            },
                            new Song {
                                Nombre = "CHICKEN TERIYAKI",
                                Duracion = "2:03"
                            },
                            new Song {
                                Nombre = "HENTAI",
                                Duracion = "2:43"
                            }
                        }
                    }
                }
            });

            // Sia
            Artistas.Add(new Artist
            {
                ImagenURL = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/artists/Sia.png",
                Nombre = "Sia",
                Edad = 46,
                Generos = "Dance/Electronica | Pop",
                Discografia = new List<Album>{
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/81KAWA8Wu4L._AC_SL1500_.jpg",
                        Nombre = "This Is Acting",
                        Descripcion = "This is Acting es el séptimo álbum de estudio de la cantante y compositora australiana Sia. Se trata principalmente de un álbum de electropop, que se compone de canciones escritas por Sia que fueron rechazadas por otras artistas femeninas de pop.",
                        FechaLanzamiento = "Enero 29, 2016",
                        Discografica = "Inertia | Monkey Puzzle | RCA",
                        Generos = "Pop | Electropop | Rabe | Pop alternativo",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Bird Set Free",
                                Duracion = "4:12"
                            },
                            new Song {
                                Nombre = "One Million Bullets",
                                Duracion = "4:12"
                            },
                            new Song {
                                Nombre = "Unstoppable",
                                Duracion = "3:37"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/91vpAHTYblL._AC_SL1500_.jpg",
                        Nombre = "Everyday Is Christmas",
                        Descripcion = "Everyday Is Christmas es el octavo álbum de estudio y primer álbum navideño de la cantante y compositora Sia.",
                        FechaLanzamiento = "Noviembre 17, 2017",
                        Discografica = "Atlantic Records",
                        Generos = "Pop | Musica navideña",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Snowman",
                                Duracion = "2:46"
                            },
                            new Song {
                                Nombre = "Santa's Comming for Us",
                                Duracion = "3:26"
                            },
                            new Song {
                                Nombre = "Candy Cane Lane",
                                Duracion = "3:32"
                            }
                        }
                    }
                }
            });

            // Taylor Swift
            Artistas.Add(new Artist
            {
                ImagenURL = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/artists/TaylorSwift.png",
                Nombre = "Taylor Swift",
                Edad = 32,
                Generos = "Pop | Country | Rock alternativo | Country pop | Folk pop | Electropop | Synth pop | Bubblegum pop | Country rock",
                Discografia = new List<Album>{
                    new Album {
                        ImagenURL = "https://www.sanborns.com.mx/imagenes-sanborns-ii/1200/843930033102.jpg",
                        Nombre = "Reputation",
                        Descripcion = "Reputation es el sexto álbum de estudio de la cantante y compositora estadounidense Taylor Swift.",
                        FechaLanzamiento = "Noviembre 10, 2017",
                        Discografica = "Big Machine Records",
                        Generos = "Pop | Dance pop | Electropop | Synth-pop",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "...Ready for it?",
                                Duracion = "3:28"
                            },
                            new Song {
                                Nombre = "Look What You Made Me Do",
                                Duracion = "3:31"
                            },
                            new Song {
                                Nombre = "End Game",
                                Duracion = "4:04"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/71RfNE3rIyL._AC_SL1500_.jpg",
                        Nombre = "Lover",
                        Descripcion = "Lover es el séptimo álbum de estudio de la cantante estadounidense Taylor Swift como productora ejecutiva.",
                        FechaLanzamiento = "Agosto 23, 2019",
                        Discografica = "Republic Records & Taylor Swift Productions",
                        Generos = "Pop | Pop rock | Electropop | Synth-pop",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Lover",
                                Duracion = "3:41"
                            },
                            new Song {
                                Nombre = "I Forgot That You Existed",
                                Duracion = "2:51"
                            },
                            new Song {
                                Nombre = "The Man",
                                Duracion = "3:10"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/81TwyCudCWL._SL1500_.jpg",
                        Nombre = "Red (Taylor's Version)",
                        Descripcion = "Red (Taylor's Version) es el segundo álbum regrabado de la cantante y compositora estadounidense Taylor Swift.",
                        FechaLanzamiento = "Noviembre 21, 2021",
                        Discografica = "Republic Records & Taylor Swift Productions",
                        Generos = "Pop | Pop rock | Electropop | Synth-pop",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Red (Taylor's Version)",
                                Duracion = "3:43"
                            },
                            new Song {
                                Nombre = "Run (Taylor's Version)",
                                Duracion = "4:00"
                            },
                            new Song {
                                Nombre = "I Almost Done (Taylor's Version)",
                                Duracion = "4:05"
                            }
                        }
                    }
                }
            });

            // Twenty One Pilots
            Artistas.Add(new Artist
            {
                ImagenURL = "https://raw.githubusercontent.com/eduardrivs/Resources/main/Modam/artists/TOP.png",
                Nombre = "Twenty One Pilots",
                Edad = 13,
                Generos = "Indie pop | Hip hop alternativo | Electropop | Pop rap | Pop rock | Rock alternativo | Rap rock",
                Discografia = new List<Album>{
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/71k-5WHYB9L._AC_SX522_.jpg",
                        Nombre = "Blurryface",
                        Descripcion = "Blurryface, es el cuarto álbum de larga duración y segundo álbum de estudio del dúo musical estadounidense Twenty One Pilots.",
                        FechaLanzamiento = "Mayo 17, 2015",
                        Discografica = "Fueled by Ramen",
                        Generos = "Alternativo/Independiente | Pop",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Heavydirtysoul",
                                Duracion = "3:55"
                            },
                            new Song {
                                Nombre = "Ride",
                                Duracion = "3:34"
                            },
                            new Song {
                                Nombre = "Stressed Out",
                                Duracion = "3:22"
                            }
                        }
                    },
                    new Album {
                        ImagenURL = "https://m.media-amazon.com/images/I/81ucF7MxoeL._AC_SX425_.jpg",
                        Nombre = "Trench",
                        Descripcion = "Trench es el quinto álbum del dúo estadounidense Twenty One Pilots y el tercero como dúo.",
                        FechaLanzamiento = "Octubre 5, 2018",
                        Discografica = "Fueled by Ramen",
                        Generos = "Rap rock | Electropop | Indietronica | Rock electrónico | Rock alternativo | Pop rock",
                        Canciones = new List<Song>
                        {
                            new Song {
                                Nombre = "Jumpsuit",
                                Duracion = "3:59"
                            },
                            new Song {
                                Nombre = "Chlorine",
                                Duracion = "4:19"
                            },
                            new Song {
                                Nombre = "My blood",
                                Duracion = "3:49"
                            }
                        }
                    }
                }
            });

            BindingContext = this;
        }

        void OnSelectionChanged(Object sender, SelectionChangedEventArgs e)
        {
            Artist selectedItem = e.CurrentSelection[0] as Artist;
        }
    }
}