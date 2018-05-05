using RadioZonica.Interfaces;
using System;
using Xamarin.Forms;

namespace RadioZonica.Pages
{
    public partial class SharePage : ContentPage
    {
        public SharePage()
        {
            InitializeComponent();

            lblWP.Text = "Agendá nuestro número y escribinos: \n11-2262-7728";
        }

        private void Whatsapp_Tapped(object sender, EventArgs e)
        {
            var uri = new Uri("tel:1122627728");
            Device.OpenUri(uri);
        }

        private void Share_Tapped(object sender, EventArgs e)
        {
            DependencyService.Get<ISocial>().ShareLink("Estoy escuchando Radio Zonica!! www.radiozonica.com.ar");
        }
    }
}