using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DemoDiiage.Commons;
using DemoDiiage.Models.Entities;
using DemoDiiage.Services;
using DemoDiiage.Services.Interfaces;
using DemoDiiage.ViewModels.Base;
using Prism.Commands;
using Prism.Navigation;

namespace DemoDiiage.ViewModels
{
    public class ListViewModel : BaseViewModel
    {

        #region CTOR
        
        public ListViewModel(IAlertDialogService alertDialogService, INavigationService navigationService,
            DatabaseService databaseService) : base(alertDialogService, navigationService)
        {
            _databaseService = databaseService;

            DeleteMovieCommand = new DelegateCommand<MovieEntity>((MovieEntity movie) => DoDeleteMovieCommand(movie));
            ShowMovieCommand = new DelegateCommand<MovieEntity>((MovieEntity movie) => DoShowMovieCommand(movie));
        }

        #endregion

        #region Lifecycle

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            FillWatchList();
        }

        #endregion

        #region Privates

        private readonly IDatabaseService _databaseService;

        #endregion

        #region Publics

        #region type => publicName

        private ObservableCollection<MovieEntity> _watchList;

        public ObservableCollection<MovieEntity> WatchList
        {
            get => _watchList;
            set => this.SetProperty(ref _watchList, value);
        }

        #endregion

        #endregion

        #region Commands

        public DelegateCommand<MovieEntity> DeleteMovieCommand { get; set; }

        private void DoDeleteMovieCommand(MovieEntity movie)
        {
            try
            {
                if (movie == null)
                {
                    return;
                }
                
                _databaseService.DeleteMovie(movie);
                WatchList.Remove(movie);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //display error
            }
        }
        
        public DelegateCommand<MovieEntity> ShowMovieCommand { get; set; }

        
        private async Task DoShowMovieCommand(MovieEntity movie)
        {
            try
            {
                if (movie == null)
                {
                    return;
                }

                var paramters = new NavigationParameters()
                {
                    {"movie", movie}
                };
                await NavigationService.NavigateAsync(Constants.MoviePage, paramters);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //display error
            }
        }
        #endregion

        #region Methods

        private void FillWatchList()
        {
            try
            {
                var list = _databaseService.GetMovies();
                WatchList = new ObservableCollection<MovieEntity>(list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //Display error
                return;
            }
        }

        #endregion
    }
}