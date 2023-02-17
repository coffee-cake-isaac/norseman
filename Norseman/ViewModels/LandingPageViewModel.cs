using Norseman.Lib.Enums;
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
        public VehicleMake SelectedMake
        {
            get => _selectedMake;
            set => SetProperty(ref _selectedMake, value);
        }

        public IEnumerable<VehicleMake> Makes
        {
            get
            {
                return Enum.GetValues(typeof(VehicleMake))
                    .Cast<VehicleMake>();
            }
        }

        public bool IsMakeVisible
        {
            get => _makeVisibility;
            set => SetProperty(ref _makeVisibility, value);
        }

        public bool IsModelVisible
        {
            get => _modelVisibility;
            set => SetProperty(ref _modelVisibility, value);
        }

        public ICommand SolidfyMakeCommand => new Command(SolidifyMake);

        public LandingPageViewModel() 
        {
            IsMakeVisible = false;
            IsModelVisible = true;
        }

        public void SolidifyMake()
        {
            IsMakeVisible = false;
            IsModelVisible = true;
        }

        private VehicleMake _selectedMake;
        private bool _makeVisibility, _modelVisibility;
    }
}
