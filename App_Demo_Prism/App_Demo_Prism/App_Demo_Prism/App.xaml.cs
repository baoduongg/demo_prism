using Prism;
using Prism.Ioc;
using App_Demo_Prism.ViewModels;
using App_Demo_Prism.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App_Demo_Prism
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MasterDetailPage1");
            //await NavigationService.NavigateAsync("DemoTabbedPage");
          //  await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<MasterDetailPage1>();
            containerRegistry.RegisterForNavigation<PageA,PageAViewModel>();
            containerRegistry.RegisterForNavigation<DemoDependency>();
            containerRegistry.RegisterForNavigation<DemoListView>();
            containerRegistry.RegisterForNavigation<DemoTabbedPage>();
        }
    }
}
