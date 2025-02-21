using System.Collections.Generic;
using System.Linq;

namespace Progetto3.Models
{
    public static class ArticoloRepository
    {
        private static List<Articolo> _articoli = new List<Articolo>
        {
            

            new Articolo {
            Id = 1,
            Nome = "Nike Air Force 1 '07",
            Prezzo = 110m,
            Descrizione = "La leggenda continua a vivere nell'Air Force 1 '07, l'icona del basket che porta un tocco di novità a ciò che conosci meglio: pelle resistente, colori puliti e la giusta quantità di flash per farti brillare.",
            UrlImmagineCopertina = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/b7d9211c-26e7-431a-ac24-b0540fb3c00f/air-force-1-07-mens-shoes-5QFp5Z.png",
            UrlImmagineAggiuntiva1 = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/00375837-849f-4f17-ba24-d201d27be49b/air-force-1-07-mens-shoes-5QFp5Z.png",
            UrlImmagineAggiuntiva2 = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/33533fe2-1157-4001-896e-1803b30659c8/air-force-1-07-mens-shoes-5QFp5Z.png"
        },
            new Articolo {
            Id = 2,
            Nome = "Nike Air Max 270",
            Prezzo = 150m,
            Descrizione = "Le Nike Air Max 270 uniscono il look di due icone Air Max con un design innovativo creato appositamente per il lifestyle. Presentano la nostra unità Air più grande nel tallone per un morbido comfort che dura tutto il giorno.",
            UrlImmagineCopertina = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/skwgyqrbfzhu6uyeh0gg/air-max-270-mens-shoes-KkLcGR.png",
    UrlImmagineAggiuntiva1 = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/vjsleghax3zaerdjwtpz/air-max-270-mens-shoes-KkLcGR.png",
    UrlImmagineAggiuntiva2 = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/gsq1oqauoxdslwsmlm5t/air-max-270-mens-shoes-KkLcGR.png"
},
        new Articolo {
            Id = 3,
            Nome = "Nike Air Jordan 1 Retro High OG",
            Prezzo = 180m,
            Descrizione = "Le Air Jordan 1 Retro High OG sono una riedizione fedele del modello originale del 1985. Con la loro silhouette iconica e i materiali premium, queste sneaker rappresentano un pezzo di storia del basket e della cultura streetwear.",
            UrlImmagineCopertina = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/5e7687f1-c13e-4bac-8ffa-a6f863ae9157/NIKE+DUNK+HI+RETRO.png",
            UrlImmagineAggiuntiva1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/811b9857-d626-46d0-b2ff-7a8858717fc6/NIKE+DUNK+HI+RETRO.png",
            UrlImmagineAggiuntiva2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/d3482474-5200-4d92-b556-f24fd2a2c577/NIKE+DUNK+HI+RETRO.png"
        },
        new Articolo {
        Id = 4,
        Nome = "Nike Dunk Low",
        Prezzo = 120m,
        Descrizione = "Le Nike Dunk Low combinano il design iconico degli anni '80 con un comfort moderno. Perfette per lo streetwear e lo skate.",
        UrlImmagineCopertina = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/d04a3567-0130-450f-bb96-32687814adde/NIKE+DUNK+LOW+RETRO.png",
        UrlImmagineAggiuntiva1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/59cea9e9-093d-4e2c-ab8b-a021b0798827/NIKE+DUNK+LOW+RETRO.png",
        UrlImmagineAggiuntiva2 = "https://static.nike.com/a/images/t_PDP_936_v1/f_auto,q_auto:eco/821370d7-e934-424c-b25b-f95bb8174dfd/NIKE+DUNK+LOW+RETRO.png"
    },
    new Articolo {
        Id = 5,
        Nome = "Nike Blazer Mid '77 Vintage",
        Prezzo = 110m,
        Descrizione = "Un classico senza tempo, le Nike Blazer Mid '77 Vintage offrono un look rétro e una tomaia in pelle premium.",
        UrlImmagineCopertina = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/fb7eda3c-5ac8-4d05-a18f-1c2c5e82e36e/BLAZER+MID+%2777+VNTG.png",
        UrlImmagineAggiuntiva1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/ef4dbed6-c621-4879-8db3-f87296bfb570/BLAZER+MID+%2777+VNTG.png",
        UrlImmagineAggiuntiva2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/2d9fe33e-9a31-4e7b-9d7c-c4ecf7abd2bb/BLAZER+MID+%2777+VNTG.png"
    },
    new Articolo {
        Id = 6,
        Nome = "Nike React Vision",
        Prezzo = 130m,
        Descrizione = "Le Nike React Vision offrono un comfort estremo grazie alla tecnologia React e un look futuristico ispirato ai sogni.",
        UrlImmagineCopertina = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/1252b86c-b89e-416c-aaa5-eb9a6dd461d4/NIKE+REACT+VISION+GS.png",
        UrlImmagineAggiuntiva1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/9bde1e6c-14e0-4f4c-a5dc-fa60fb7f6c4b/NIKE+REACT+VISION+GS.png",
        UrlImmagineAggiuntiva2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/b0e31e5e-dff7-4c7e-9d5f-e9fcf85512f5/NIKE+REACT+VISION+GS.png"
    },
        new Articolo {
            Id = 7,
            Nome = "Adidas Superstar",
            Prezzo = 100m,
            Descrizione = "Nate come scarpe da basket, adottate dai pionieri dell'hip hop, le adidas Superstar sono un'icona dello streetwear. Questa versione mantiene lo stile classico con la tomaia in pelle e le 3 strisce seghettate.",
            UrlImmagineCopertina = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/7ed0855435194229a525aad6009a0497_9366/Superstar_Shoes_White_EG4958_01_standard.jpg",
            UrlImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/8a358bcd5e3d453da815aad6009a249e_9366/Superstar_Shoes_White_EG4958_02_standard_hover.jpg",
            UrlImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/ff2e419f1eda4ebab23faad6009a3a9e_9366/Superstar_Shoes_White_EG4958_04_standard.jpg"
        },
        new Articolo {
    Id = 8,
    Nome = "Adidas Gazelle",
    Prezzo = 90m,
    Descrizione = "Le Adidas Gazelle sono un'icona dello stile casual. Con la loro silhouette classica e la tomaia in morbida pelle scamosciata, queste sneaker offrono un look senza tempo e un comfort duraturo.",
    UrlImmagineCopertina = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/b5c7e975482e4024bf54c56fc98ec6be_9366/Scarpe_Gazelle_Bold_Marrone_JI2697_01_00_standard.jpg",
    UrlImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/6bcbde09e562471ba80dc3bda9674748_9366/Scarpe_Gazelle_Bold_Marrone_JI2697_04_standard.jpg",
    UrlImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/f586cc33203e41278851aed4a523f6d0_9366/Scarpe_Gazelle_Bold_Marrone_JI2697_09_standard.jpg"
},





        new Articolo {
            Id = 9,
            Nome = "Adidas Campus",
            Prezzo = 100m,
            Descrizione = "Le Adidas Campus sono un classico intramontabile dello streetwear. Con la loro tomaia in morbida pelle scamosciata e la suola in gomma, offrono comfort e stile per ogni occasione.",
            UrlImmagineCopertina = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/4659ee058ba34bd2a5d0af500104c17d_9366/Scarpe_Campus_00s_Nero_HQ8708_01_standard.jpg",
            UrlImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/a93a651339a34d269115af500104f641_9366/Scarpe_Campus_00s_Nero_HQ8708_04_standard.jpg",
            UrlImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/d7cac0147c614d428808af5001050224_9366/Scarpe_Campus_00s_Nero_HQ8708_05_standard.jpg"
        },

        new Articolo {
        Id = 10,
        Nome = "Adidas NMD_R1",
        Prezzo = 140m,
        Descrizione = "Le Adidas NMD_R1 combinano uno stile urbano con la tecnologia Boost per un'ammortizzazione eccezionale.",
        UrlImmagineCopertina = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/412a94f9dc334afa8fc3ad4e011e6964_9366/Scarpe_NMD_R1_Nero_H03994_01_standard.jpg",
        UrlImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/e0d0b95e3caf4313a34ead4e011e858b_9366/Scarpe_NMD_R1_Nero_H03994_04_standard.jpg",
        UrlImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/3cbb218379224d828440ad4e011ea3c1_9366/Scarpe_NMD_R1_Nero_H03994_09_standard.jpg"
    },
    new Articolo {
        Id = 11,
        Nome = "Adidas Ultraboost 22",
        Prezzo = 180m,
        Descrizione = "Le Adidas Ultraboost 22 offrono un comfort incredibile grazie all'innovativa intersuola Boost, ideale per lunghe camminate e corse.",
        UrlImmagineCopertina = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/e455dff588be4164a40dad7900d3b244_9366/Scarpe_Ultraboost_22_Grigio_GX5460_01_standard.jpg",
        UrlImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/242d6baf5fe249c5a61fad7900d3cffc_9366/Scarpe_Ultraboost_22_Grigio_GX5460_04_standard.jpg",
        UrlImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/5c0884937571460a896ead7900d3ed05_9366/Scarpe_Ultraboost_22_Grigio_GX5460_09_standard.jpg"
    },
    new Articolo {
        Id = 12,
        Nome = "Adidas NMD S1 MAHBS",
        Prezzo = 230m,
        Descrizione = "Le Adidas NMD S1 MAHBS sono una versione esclusiva delle iconiche NMD, nate dalla collaborazione con l’artista **Philllllthy**. Si distinguono per il loro **design futuristico** e un’estetica ispirata al vintage, con una tomaia in **Primeknit slavata**, dettagli volutamente consumati e una suola spessa con **intersuola BOOST** per il massimo comfort. Il look “invecchiato” dona un tocco unico, rendendole perfette per chi ama lo streetwear con carattere.",
        UrlImmagineCopertina = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/4c52d86c75bb4dcaafe6afc5016abad9_9366/Scarpe_NMD_S1_MAHBS_Marrone_ID4806_01_standard.jpg",
        UrlImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/8d7e5300a7b24220a206fff3d33ce2af_9366/Scarpe_NMD_S1_MAHBS_Marrone_ID4806_011_hover_standard.jpg",
        UrlImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/97a6225cf1694416a7bdafc5016addd7_9366/Scarpe_NMD_S1_MAHBS_Marrone_ID4806_02_standard.jpg"
    },

        new Articolo {
        Id = 13,
        Nome = "Puma RS-X³ Puzzle",
        Prezzo = 110m,
        Descrizione = "Le Puma RS-X³ Puzzle sono un'esplosione di colore e stile. Con il loro design audace e la tecnologia Running System, queste scarpe offrono comfort e un look distintivo per chi ama distinguersi.",
        UrlImmagineCopertina = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/371570/04/sv01/fnd/PNA/fmt/png/PUMA-x-RUBIK'S-RS-X³-PUZZLE-Sneakers",
        UrlImmagineAggiuntiva1 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/371570/04/fnd/PNA/fmt/png/PUMA-x-RUBIK'S-RS-X³-PUZZLE-Sneakers",
        UrlImmagineAggiuntiva2 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/371570/04/bv/fnd/PNA/fmt/png/PUMA-x-RUBIK'S-RS-X³-PUZZLE-Sneakers"
    },
        new Articolo {
            Id = 14,
            Nome = "Puma Future Rider",
            Prezzo = 80m,
            Descrizione = "Le Puma Future Rider sono un'interpretazione moderna delle iconiche Easy Rider. Con una silhouette slanciata e colori vivaci, queste sneaker offrono stile e comfort per tutti i giorni.",
            UrlImmagineCopertina = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/371149/05/sv01/fnd/PNA/fmt/png/Future-Rider-Play-On-Sneakers",
            UrlImmagineAggiuntiva1 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/371149/05/fnd/PNA/fmt/png/Future-Rider-Play-On-Sneakers",
            UrlImmagineAggiuntiva2 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/371149/05/bv/fnd/PNA/fmt/png/Future-Rider-Play-On-Sneakers"
        },
        new Articolo {
            Id = 15,
            Nome = "Puma Suede Classic XXI",
            Prezzo = 70m,
            Descrizione = "Le Puma Suede Classic XXI sono un'evoluzione delle iconiche Suede. Con una tomaia in pelle scamosciata premium e il classico formstrip Puma, queste sneaker sono un must per ogni guardaroba.",
            UrlImmagineCopertina = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/374915/01/sv01/fnd/PNA/fmt/png/Suede-Classic-XXI-Sneakers",
            UrlImmagineAggiuntiva1 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/374915/01/fnd/PNA/fmt/png/Suede-Classic-XXI-Sneakers",
            UrlImmagineAggiuntiva2 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/374915/01/bv/fnd/PNA/fmt/png/Suede-Classic-XXI-Sneakers"
        },

        new Articolo {
        Id = 16,
        Nome = "Puma Cali Court",
        Prezzo = 100m,
        Descrizione = "Le Puma Cali Court offrono un look casual ed elegante con dettagli metallici e una silhouette raffinata.",
        UrlImmagineCopertina = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_550,h_550/global/393802/20/sv01/fnd/EEA/fmt/png/Sneaker-PUMA-Cali-Court-Leather-da-donna",
        UrlImmagineAggiuntiva1 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_550,h_550/global/393802/20/fnd/EEA/fmt/png/Sneaker-PUMA-Cali-Court-Leather-da-donna",
        UrlImmagineAggiuntiva2 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_550,h_550/global/393802/20/sv04/fnd/EEA/fmt/png/Sneaker-PUMA-Cali-Court-Leather-da-donna"
    },
    new Articolo {
        Id = 17,
        Nome = "Puma RS-X Triple",
        Prezzo = 120m,
        Descrizione = "Le Puma RS-X Triple combinano un design moderno con l'innovativa tecnologia Running System per il massimo comfort.",
        UrlImmagineCopertina = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_550,h_550/global/391928/01/sv01/fnd/EEA/fmt/png/Sneakers-RS-X-Triple",
        UrlImmagineAggiuntiva1 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_550,h_550/global/391928/01/fnd/EEA/fmt/png/Sneakers-RS-X-Triple",
        UrlImmagineAggiuntiva2 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_550,h_550/global/391928/01/sv04/fnd/EEA/fmt/png/Sneakers-RS-X-Triple"
    },
    new Articolo {
        Id = 18,
        Nome = "Puma RS-X Efekt PRM",
        Prezzo = 130m,
        Descrizione = "Le Puma RS-X Efekt PRM si ispirano alla cultura dei DJ con un mix di colori audaci e dettagli futuristici.",
        UrlImmagineCopertina = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_550,h_550/global/390776/54/sv01/fnd/EEA/fmt/png/Sneakers-RS-X-Efekt-PRM",
        UrlImmagineAggiuntiva1 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_550,h_550/global/390776/54/fnd/EEA/fmt/png/Sneakers-RS-X-Efekt-PRM",
        UrlImmagineAggiuntiva2 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_550,h_550/global/390776/54/sv02/fnd/EEA/fmt/png/Sneakers-RS-X-Efekt-PRM"
    }

        };
        

public static IEnumerable<Articolo> GetAll() => _articoli;

        public static Articolo GetById(int id) => _articoli.FirstOrDefault(a => a.Id == id);
    }
}