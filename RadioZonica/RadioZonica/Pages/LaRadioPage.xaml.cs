using System;
using Xamarin.Forms;

namespace RadioZonica.Pages
{
    public partial class LaRadioPage : ContentPage
    {
        public LaRadioPage()
        {
            InitializeComponent();

            lblText.Text= "RadioZonica nació con el objetivo de crear una nueva manera de hacer radio, utilizando Internet como medio de difusión social. Durante el año 2005 marco tendencia, al ser uno de los primeros medios online del pais en apostar a una novedosa forma de comunicación, cumpliendo en 2015 con 10 años de experiencia en el mercado nacional.\n\n" +
                "Gracias al trabajo de un equipo de excelencia y a la confianza depositada por sus oyentes, RadioZónica se ha convertido en un referente tanto en la generación como en la difusión de noticias y contenidos, lo que le mereció la declaración de interés cultural y social en la ciudad de Buenos Aires  en el año 2014.El proyecto fue firmado por 13 legisladores y aprobado por unanimidad en la legislatura porteña.\n\n" +
                "En Diciembre de 2014 la emisora fue ganadora del prestigioso premio Eter como 'Mejor Radio de Internet 2014' de la Republica Argentina.\n\n" +
                "Con el objetivo de desarrollarse como un medio independiente y con pluralidad de voces, se formó desde sus comienzos una programación dirigida a un público heterogéneo, fomentando una coherencia capaz de incorporar a su grilla magazines, entrevistas, cultura, deporte, política, actualidad y ciclos educativos.\n\n" +
                "Radio Zónica cuenta con personalidades que continuamente sorprenden a sus oyentes y a la competencia, sumando repetidoras a su red, en diferentes puntos del país, llegando de este modo cada día a más hogares y lugares de trabajo.\n\n" +
                "El principal desafío como referente de su medio, es sumar creatividad en la interacción con sus oyentes y auspiciantes, manteniendo el prestigio que Radio Zónica ha sabido conquistar. Ejemplo de esto es el galardón que se le fue otorgado en el año 2008, siendo la  primera emisora por internet en ganar un premio reservado hasta el momento para las radios convencionales: 'El Premio Eter' a la Creatividad en una Radio Web.\n\n" +
                "Radio Zonica 'La Radio más escuchada en Internet'.\n\n";
        }

        private void Url_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.radiozonica.com.ar"));
        }
    }
}