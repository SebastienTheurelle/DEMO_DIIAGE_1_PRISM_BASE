using System;
using System.Threading.Tasks;
using DemoDiiage.Models.Entities;
using DemoDiiage.Services.Interfaces;
using DemoDiiage.ViewModels.Base;
using Prism.Commands;
using Prism.Navigation;

namespace DemoDiiage.ViewModels
{
    public class FindViewModel : BaseViewModel
    {
        #region CTOR

        public FindViewModel(IAlertDialogService alertDialogService, INavigationService navigationService,
            IDatabaseService databaseService, IRequestService requestService) : base(alertDialogService,
            navigationService)
        {
            _requestService = requestService;
            _databaseService = databaseService;

            ActionCommand = new DelegateCommand<string>(async (string action) => await DoActionCommand(action));

            Title = "Randomize";
        }

        #endregion

        #region Lifecycle

        #endregion

        #region Privates

        private readonly IDatabaseService _databaseService;
        private readonly IRequestService _requestService;

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

        public DelegateCommand<string> ActionCommand { get; set; }

        private async Task DoActionCommand(string action)
        {
            switch (action)
            {
                case "Save":
                    await SaveMovie();
                    break;
                case "Random":
                    await GetAMovie();
                    break;
                default:
                    return;
            }
        }

        #endregion

        #region Methods
        private async Task GetAMovie()
        {
            try
            {
                var movie = await _requestService.GetRandomMovie();
                if (movie != null)
                {
                    Movie = new MovieEntity(movie);
                }
                else
                {
                    //Display error
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //Display error
            }
        }

        private async Task SaveMovie()
        {
            try
            {
                if (Movie == null)
                {
                    return;
                }

               var result = _databaseService.InsertMovie(Movie);
               if (result != null)
               {
                   //display success
               }
               else
               {
                   //display error
               }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //display error
            }
        }

        #endregion
    }
}