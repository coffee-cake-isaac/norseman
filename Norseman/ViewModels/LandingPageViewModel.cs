using Norseman.Enums;
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

        public Visibility MakeVisibility
        {
            get => _makeVisibility;
            set => SetProperty(ref _makeVisibility, value);
        }

        public Visibility ModelVisibility
        {
            get => _modelVisibility;
            set => SetProperty(ref _modelVisibility, value);
        }

        public ICommand SolidfyMakeCommand => new Command(SolidifyMake);

        public LandingPageViewModel() 
        {

        }

        public void SolidifyMake()
        {
            MakeVisibility = Visibility.Collapsed;
            ModelVisibility = Visibility.Visible;
        }

        private VehicleMake _selectedMake;
        private Visibility _makeVisibility, _modelVisibility;
    }
}
