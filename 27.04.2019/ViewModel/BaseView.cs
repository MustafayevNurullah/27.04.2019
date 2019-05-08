using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._04._2019.ViewModel
{
    class BaseView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnpropertyChanged(PropertyChangedEventArgs e)
        {

            PropertyChanged?.Invoke(this, e);
        }


    }
}
