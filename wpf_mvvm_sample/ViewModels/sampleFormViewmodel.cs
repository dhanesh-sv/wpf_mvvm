using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_mvvm_sample.Common;

namespace wpf_mvvm_sample.ViewModels
{
    class sampleFormViewmodel
    {
        public RelayCommand saveDetails { get; set; }


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
            string Name = new ViewModelLocator().sampleFormModelProperty.Name;
            byte Age = new ViewModelLocator().sampleFormModelProperty.Age;
            DateTime? DOB = new ViewModelLocator().sampleFormModelProperty.DOB;
        }
    }
}
