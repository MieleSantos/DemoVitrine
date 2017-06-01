using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemonVitrine.Templates
{
    public class VitrineTemplate : ViewCell
    {
        StackLayout stackPrinc;
        StackLayout stackColuna1;
        StackLayout stackColuna2;

        Label lbl1;
        Label lbl2;
        Image img1;
        Image img2;
        

        public VitrineTemplate()
        {
            stackPrinc = new StackLayout { Orientation = StackOrientation.Horizontal };

            stackColuna1 = new StackLayout { Orientation = StackOrientation.Vertical };
            lbl1 = new Label { };
            stackColuna1.Children.Add(lbl1);
            img1 = new Image { };
            stackColuna1.Children.Add(img1);

            stackColuna2 = new StackLayout { Orientation = StackOrientation.Vertical };
            lbl2 = new Label { };
            stackColuna2.Children.Add(lbl2);
            img2 = new Image { };
            stackColuna2.Children.Add(img2);

            lbl1.SetBinding(Label.TextProperty,
                new Binding("descricao1", BindingMode.OneWay,
                null, null, "{0}"));
            
            img1.SetBinding(Image.SourceProperty,
                new Binding("Foto1", stringFormat: "/{0}"));

            lbl2.SetBinding(Label.TextProperty,
                new Binding("descricao2", BindingMode.OneWay,
                null, null, "{0}"));

            img2.SetBinding(Image.SourceProperty,
                new Binding("Foto2", stringFormat: "/{0}"));

            stackPrinc.Children.Add(stackColuna1);
            stackPrinc.Children.Add(stackColuna2);

            stackColuna1.GestureRecognizers.Add(new TapGestureRecognizer(OnTapP1));
            stackColuna1.GestureRecognizers.Add(new TapGestureRecognizer(OnTapP2));
            View = stackPrinc;
        }

        private void OnTapP2(View arg1, object arg2)
        {
            Application.Current.MainPage.DisplayAlert("Aviso", lbl1.Text,"ok");
        }

        private void OnTapP1(View arg1, object arg2)
        {
            Application.Current.MainPage.DisplayAlert("Aviso", lbl2.Text, "ok");
        }
    }
}
