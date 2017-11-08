using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using wpf_mvvm_sample.Common;
using wpf_mvvm_sample.Models;

namespace wpf_mvvm_sample.ViewModels
{
    class sampleFormViewmodel : NotifyPropertyChangedBase
    {
        public RelayCommand saveDetails { get; set; }

        private List<LocationModel> _lstLocModel;
        public List<LocationModel> lstLocModel
        {
            get { return _lstLocModel; }
            set
            {
                _lstLocModel = value;
                objLocModel = _lstLocModel[0];
                RaisePropertyChanged("lstLocModel");
            }
        }

        private LocationModel _objLocModel;
        public LocationModel objLocModel
        {
            get { return _objLocModel; }
            set
            {
                _objLocModel = value;
                new ViewModelLocator().sampleFormModelProperty.Location = _objLocModel.LocationName;
                RaisePropertyChanged("objLocModel");
            }
        }



        private ObservableCollection<sampleFormModel> _obsSampleFormModel = new ObservableCollection<sampleFormModel>();
        public ObservableCollection<sampleFormModel> obsSampleFormModel
        {
            get { return _obsSampleFormModel; }
            set
            {
                _obsSampleFormModel = value;
                RaisePropertyChanged("obsSampleFormModel");
            }
        }

        private sampleFormModel _objSampleFormModel;
        public sampleFormModel objSampleFormModel
        {
            get { return _objSampleFormModel; }
            set
            {
                _objSampleFormModel = value;
                RaisePropertyChanged("objSampleFormModel");
            }
        }

        public sampleFormViewmodel()
        {
            saveDetails = new RelayCommand(saveDetailsExecute, saveDetailsCanExecute);
        }

        private bool saveDetailsCanExecute(object obj)
        {
            return true;
        }

        private void saveDetailsExecute(object obj)
        {
            string Name = new ViewModelLocator().sampleFormModelProperty.userName;
            byte Age = new ViewModelLocator().sampleFormModelProperty.Age;
            DateTime? DOB = new ViewModelLocator().sampleFormModelProperty.DOB;
            string Location = new ViewModelLocator().sampleFormModelProperty.Location;

            obsSampleFormModel.Add(new ViewModelLocator().sampleFormModelProperty);
            RaisePropertyChanged("obsSampleFormModel");
        }
    }
}
