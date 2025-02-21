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
            Nome = "Adidas Superstar",
            Prezzo = 100m,
            Descrizione = "Nate come scarpe da basket, adottate dai pionieri dell'hip hop, le adidas Superstar sono un'icona dello streetwear. Questa versione mantiene lo stile classico con la tomaia in pelle e le 3 strisce seghettate.",
            UrlImmagineCopertina = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/7ed0855435194229a525aad6009a0497_9366/Superstar_Shoes_White_EG4958_01_standard.jpg",
            UrlImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/8a358bcd5e3d453da815aad6009a249e_9366/Superstar_Shoes_White_EG4958_02_standard_hover.jpg",
            UrlImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/ff2e419f1eda4ebab23faad6009a3a9e_9366/Superstar_Shoes_White_EG4958_04_standard.jpg"
        },
        
        new Articolo {
        Id = 3,
        Nome = "Puma RS-X³ Puzzle",
        Prezzo = 110m,
        Descrizione = "Le Puma RS-X³ Puzzle sono un'esplosione di colore e stile. Con il loro design audace e la tecnologia Running System, queste scarpe offrono comfort e un look distintivo per chi ama distinguersi.",
        UrlImmagineCopertina = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/371570/04/sv01/fnd/PNA/fmt/png/PUMA-x-RUBIK'S-RS-X³-PUZZLE-Sneakers",
        UrlImmagineAggiuntiva1 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/371570/04/fnd/PNA/fmt/png/PUMA-x-RUBIK'S-RS-X³-PUZZLE-Sneakers",
        UrlImmagineAggiuntiva2 = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/371570/04/bv/fnd/PNA/fmt/png/PUMA-x-RUBIK'S-RS-X³-PUZZLE-Sneakers"
    }
        };

        public static IEnumerable<Articolo> GetAll() => _articoli;

        public static Articolo GetById(int id) => _articoli.FirstOrDefault(a => a.Id == id);
    }
}