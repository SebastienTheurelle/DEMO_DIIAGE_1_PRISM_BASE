using System.Linq;
using DemoDiiage.Models.Entities;
using DemoDiiage.Services.Interfaces;
using DemoDiiage.ViewModels.Base;
using Prism.Navigation;

namespace DemoDiiage.ViewModels
{
    public class MovieViewModel : BaseViewModel
    {
        #region CTOR

        public MovieViewModel(IAlertDialogService alertDialogService, INavigationService navigationService) : base(
            alertDialogService, navigationService)
        {
            Title = "Movie";
        }

        #endregion

        #region Lifecycle

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters?.Any() ?? false)
            {
                var movie = parameters.GetValue<MovieEntity>("movie");
                Movie = movie;
            }
            else
            {
                //No parameter 
                await NavigationService.GoBackAsync();
            }

            base.OnNavigatedTo(parameters);
        }

        #endregion

        #region Privates

        #endregion

        #region Publics

        #region MovieEntity => Movie

        private MovieEntity _movie;

        public MovieEntity Movie
        {
            get => _movie;
            set => this.SetProperty(ref _movie, value);
        }

        #endregion

        #endregion

        #region Commands

        #endregion

        #region Methods

        #endregion
    }
}