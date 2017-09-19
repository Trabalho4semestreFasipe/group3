using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Atimir.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Desejo : ContentPage
	{
		public Desejo ()
		{
			InitializeComponent ();

            int codigo;
            string produto;
            string categoria;
            string loja;
            float precoMin;
            float precoMax;

        }
	}
}