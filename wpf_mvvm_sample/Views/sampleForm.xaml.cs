using System.Collections.Generic;
using System.Windows;
using wpf_mvvm_sample.Models;
using wpf_mvvm_sample.ViewModels;

namespace wpf_mvvm_sample.Views
{
    /// <summary>
    /// Interaction logic for sampleForm.xaml
    /// </summary>
    public partial class sampleForm : Window
    {
        public sampleForm()
        {
            InitializeComponent();
            List<LocationModel> lstLocation = new List<LocationModel>();
            lstLocation.Add(new LocationModel() { LocationId = 0, LocationName = "Select" });
            lstLocation.Add(new LocationModel() { LocationId = 1, LocationName = "Hyderabad" });
            lstLocation.Add(new LocationModel() { LocationId = 2, LocationName = "Secunderabad" });
            lstLocation.Add(new LocationModel() { LocationId = 3, LocationName = "Godavarikhani" });
            new ViewModelLocator().sampleFormViewModelProperty.lstLocModel = lstLocation;
        }
    }
}
