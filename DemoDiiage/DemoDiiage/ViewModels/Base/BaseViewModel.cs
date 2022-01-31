using DemoDiiage.Services.Interfaces;
using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;

namespace DemoDiiage.ViewModels.Base
{
    public class BaseViewModel : BindableBase, INavigationAware, IPageLifecycleAware
    {
        #region CTOR

        public BaseViewModel(IAlertDialogService alertDialogService, INavigationService navigationService)
        {
            AlertDialogService = alertDialogService;
            NavigationService = navigationService;
        }

        #endregion

        #region Lifecycle

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void OnAppearing()
        {
        }

        public void OnDisappearing()
        {
        }

        #endregion

        #region Protected

        protected IAlertDialogService AlertDialogService;
        protected INavigationService NavigationService;

        #endregion

        #region Publics

        #region string => Title

        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        #endregion

        #region bool => IsBusy

        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        #endregion

        #endregion

        #region Commands

        #endregion

        #region Methods

        #endregion
    }
}