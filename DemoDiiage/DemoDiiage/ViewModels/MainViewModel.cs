using System.Threading.Tasks;
using DemoDiiage.Commons;
using DemoDiiage.Services.Interfaces;
using DemoDiiage.ViewModels.Base;
using Prism.Commands;
using Prism.Navigation;

namespace DemoDiiage.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        #region CTOR
        public MainViewModel(IAlertDialogService alertDialogService, INavigationService navigationService) : base(
            alertDialogService, navigationService)
        {
            FindCommand = new DelegateCommand(async () => await DoFindCommand());
            ListCommand = new DelegateCommand(async () => await DoListCommand());
            
            Title = "Netflix Randomizer";
        }

        #endregion

        #region Lifecycle

        #endregion

        #region Privates

        #endregion

        #region Publics

        #endregion

        #region Commands
        
        public DelegateCommand FindCommand { get; set; }

        private async Task DoFindCommand()
        {
            await NavigationService.NavigateAsync(Constants.FindPage);
        }
        
        public DelegateCommand ListCommand { get; set; }

        private async Task DoListCommand()
        {
            await NavigationService.NavigateAsync(Constants.ListPage);
        }

        #endregion

        #region Methods

        #endregion
    }
}