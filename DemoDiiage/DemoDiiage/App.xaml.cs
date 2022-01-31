using System;
using DemoDiiage.Commons;
using DemoDiiage.Helpers;
using DemoDiiage.Helpers.Interfaces;
using DemoDiiage.Models.Entities;
using DemoDiiage.Repositories;
using DemoDiiage.Repositories.Interface;
using DemoDiiage.Services;
using DemoDiiage.Services.Interfaces;
using DemoDiiage.ViewModels;
using DemoDiiage.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace DemoDiiage
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
            
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            
            await NavigationService.NavigateAsync($"{Constants.NavigationPage}/{Constants.MainPage}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            RegisterHelpers(containerRegistry);
            RegisterServices(containerRegistry);
            RegisterRepositories(containerRegistry);
            RegisterViews(containerRegistry);
        }
        
        private void RegisterViews(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(Constants.NavigationPage);
            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>(Constants.MainPage);
            containerRegistry.RegisterForNavigation<FindPage, FindViewModel>(Constants.FindPage);
            containerRegistry.RegisterForNavigation<ListPage, ListViewModel>(Constants.ListPage);
            containerRegistry.RegisterForNavigation<MoviePage, MovieViewModel>(Constants.MoviePage);
        }

        private void RegisterRepositories(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IRepository<MovieEntity>, Repository<MovieEntity>>();
        }

        private void RegisterServices(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAlertDialogService, AlertDialogService>();
            containerRegistry.RegisterSingleton<IRequestService, RequestService>();
            containerRegistry.RegisterSingleton<IDatabaseService, DatabaseService>();
        }

        private void RegisterHelpers(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IDataTransferHelper, DataTransferHelper>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}