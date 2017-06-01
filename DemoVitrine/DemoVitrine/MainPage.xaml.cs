using DemonVitrine.Model;
using DemonVitrine.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoVitrine
{
    public partial class MainPage : ContentPage
    {
        List<ProdVitrine> lista;
        ListView lv;

        public MainPage()
        {
            InitializeComponent();
          

            var itemTemplate = new DataTemplate(typeof(VitrineTemplate));
            lv = new ListView
            {
                ItemTemplate = itemTemplate,
                HasUnevenRows = true
            };
            stackPrinc.Children.Add(lv);
            lista = new List<ProdVitrine>();

            lista.Add(new ProdVitrine
            {
                Descricao1 = "SMARTPHONE 1",
                Foto1 = "img1.jpg",
                Descricao2 = "SMARTPHONE 2",
                Foto2 = "img2.jpg"
            });
            lista.Add(new ProdVitrine
            {
                Descricao1 = "SMARTPHONE 3",
                Foto1 = "img3.jpg",
                Descricao2 = "SMARTPHONE 4",
                Foto2 = "im4.jpg"
            });
            lista.Add(new ProdVitrine
            {
                Descricao1 = "SMARTPHONE 5",
                Foto1 = "img5.jpg",
                Descricao2 = "SMARTPHONE 6",
                Foto2 = "img6.jpg"
            });

            lv.ItemsSource = lista;

        }
    }
}

