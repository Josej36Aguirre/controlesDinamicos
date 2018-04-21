using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace controlesDinamicos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            boton1.Clicked += Boton1_Clicked;

        }

        private void Boton1_Clicked(object sender, EventArgs e)
        {
            Panel.Children.Add(new Button()
            {

                Text = $"Boton{Panel.Children.Count+1}"
            });
        }
    }
}
