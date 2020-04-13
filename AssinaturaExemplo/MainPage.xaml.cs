using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignaturePad.Forms;
using Xamarin.Forms;

namespace AssinaturaExemplo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       async void  btnAssinatura_Clicked(System.Object sender, System.EventArgs e)
        {
            //Voce pode escolher o formato da assinatura
            Stream image = await assinaturaControle.GetImageStreamAsync(SignatureImageFormat.Png);

        }
    }
}
