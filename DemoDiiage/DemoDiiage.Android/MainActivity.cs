using Android.App;
using Android.Content.PM;
using Android.OS;
using DemoDiiage.Android.Services;
using DemoDiiage.Repositories;
using DemoDiiage.Repositories.Interface;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;

namespace DemoDiiage.Android
{
    [Activity(Label = "DemoDiiage", Theme = "@style/MainTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Forms.Init(this, savedInstanceState);
            LoadApplication(new App(new AndroidInitializer()));
        }
    }
    
    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register plateform specific services here
            containerRegistry.RegisterSingleton<IDatabase, SqliteConnectionService>();
            containerRegistry.Register(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}