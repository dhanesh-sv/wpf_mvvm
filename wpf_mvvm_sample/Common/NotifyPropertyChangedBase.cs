using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_mvvm_sample.Common
{
    class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string PrprtyName)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(PrprtyName));
        }
    }
}
