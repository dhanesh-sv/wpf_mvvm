using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using wpf_mvvm_sample.Common;
using wpf_mvvm_sample.Models;
using wpf_mvvm_sample.ViewModels;

namespace wpf_mvvm_sample.ViewModels
{
    class ViewModelLocator : NotifyPropertyChangedBase
    {


        private static sampleFormModel _sampleFormModelProperty;
        public sampleFormModel sampleFormModelProperty
        {
            get
            {
                if (_sampleFormModelProperty == null)
                {
                    _sampleFormModelProperty = new sampleFormModel();
                    RaisePropertyChanged("sampleFormModelProperty");
                }
                return _sampleFormModelProperty;
            }
        }


        private static sampleFormViewmodel _sampleFormViewModelProperty;
        public sampleFormViewmodel sampleFormViewModelProperty
        {
            get
            {
                if (_sampleFormViewModelProperty == null)
                {
                    _sampleFormViewModelProperty = new sampleFormViewmodel();
                    RaisePropertyChanged("sampleFormViewModelProperty");
                }
                return _sampleFormViewModelProperty;
            }
        }
    }
}
