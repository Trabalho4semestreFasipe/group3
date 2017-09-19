using Atimir.View;
using System;
using Xamarin.Forms;

namespace Atimir
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        public void MeuAlerta(Object obj, EventArgs seder)
        {
            Navigation.PushAsync(new Pagina2());
        }
	}
}
