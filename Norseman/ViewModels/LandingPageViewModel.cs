using Norseman.Lib.Enums;
using Norseman.Lib.Services.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Norseman.ViewModels
{
    public class LandingPageViewModel : ViewModelBase
    {
        /// <summary>
        /// The user selected manufacturer for their EV
        /// </summary>
        public VehicleMake SelectedMake
        {
            get => _selectedMake;
            set => SetProperty(ref _selectedMake, value);
        }

        /// <summary>
        /// The list of makes that users can currently select from
        /// <see cref="VehicleMake"/>
        /// </summary>
        public IEnumerable<VehicleMake> Makes
        {
            get
            {
                return Enum.GetValues(typeof(VehicleMake))
                    .Cast<VehicleMake>();
            }
        }

        /// <summary>
        /// Determines if the make list is visible to the user for selection
        /// </summary>
        public bool IsMakeVisible
        {
            get => _makeVisibility;
            set => SetProperty(ref _makeVisibility, value);
        }

        /// <summary>
        /// Determines if the model list is visible to the user for selection
        /// </summary>
        public bool IsModelVisible
        {
            get => _modelVisibility;
            set => SetProperty(ref _modelVisibility, value);
        }

        /// <summary>
        /// The command used for binding the button for saving their vehicle
        /// </summary>
        public ICommand SolidfyMakeCommand => new Command(SolidifyMake);

        /// <summary>
        /// Default constructor
        /// </summary>
        public LandingPageViewModel(INavigationService navigationService) : base(navigationService) 
        {
            IsMakeVisible = false;
            IsModelVisible = true;
        }

        /// <summary>
        /// Solidifies the make by preventing the user from making a different <see cref="VehicleMake"/> selection
        /// </summary>
        public void SolidifyMake()
        {
            IsMakeVisible = false;
            IsModelVisible = true;
        }

        /// <summary>
        /// Private backing fields
        /// </summary>
        private VehicleMake _selectedMake;
        private bool _makeVisibility, _modelVisibility;
    }
}
