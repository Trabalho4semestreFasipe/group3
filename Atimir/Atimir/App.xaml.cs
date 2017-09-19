﻿using Atimir.View;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Atimir
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetail { get; set;}

        public async static Task NavigateMaster(Page page)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.Detail.Navigation.PushAsync(page);
        
        }
		public App()
		{
			InitializeComponent();

            MainPage = new MasterDetail();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}