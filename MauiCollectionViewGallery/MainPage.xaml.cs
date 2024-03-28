using MauiCollectionViewGallery.Gallery.Pool;

namespace MauiCollectionViewGallery
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}


		private async void Button_Clicked(object sender, EventArgs e)
		{
			var page = new PoolPage();
			await page.LoadLogs();

			await this.Navigation.PushAsync(page, true);
        }
    }

}
