
using Xamarin.Forms;

namespace Atimir.View
{
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            this.Master = new Menu();
            this.Detail = new NavigationPage(new Pagina2());
            App.MasterDetail = this;
        }
    }
}