using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Atimir.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}
        public async void TabbClick (object obj, EventArgs send)
        {
            await App.NavigateMaster(new TabbedPage1());
        }
	}
}