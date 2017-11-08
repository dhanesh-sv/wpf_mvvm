using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_mvvm_sample.Common;

namespace wpf_mvvm_sample.Models
{
    class sampleFormModel : NotifyPropertyChangedBase
    {
        private string _userName;
        public string userName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged("userName");
            }
        }

        private byte _Age;
        public byte Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                RaisePropertyChanged("Age");
            }
        }

        private DateTime? _DOB;
        public DateTime? DOB
        {
            get { return _DOB; }
            set
            {
                _DOB = value;
                RaisePropertyChanged("DOB");
            }
        }

        private string _Location;
        public string Location
        {
            get { return _Location; }
            set
            {
                _Location = value;
                RaisePropertyChanged("Location");
            }
        }

        
    }
}
