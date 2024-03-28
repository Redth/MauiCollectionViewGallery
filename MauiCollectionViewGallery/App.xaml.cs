using MauiCollectionViewGallery.Gallery.Pool;

namespace MauiCollectionViewGallery
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}
	}
}
