using Norseman.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public LandingPageViewModel() 
        {

        }

        private VehicleMake _selectedMake;
    }
}
