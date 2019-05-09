using _27._04._2019.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _27._04._2019.Command
{
    class PDF : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public PDF(QruplarView qruplarView)
        {

        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

           MessageBox.Show("PDF");

        }
    }
}
