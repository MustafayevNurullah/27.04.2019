using _27._04._2019.Entity;
using _27._04._2019.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _27._04._2019.Command
{
    class Search : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public QruplarView qruplarView { get; set; }
        public Search(QruplarView QruplarView)
        {
            qruplarView = QruplarView;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var item = qruplarView.groups.Where(x => (x.QrupAdi == null) ? true : x.QrupAdi.Contains(qruplarView.search) || (x.Filiali.Filiali == null) ? true : x.Filiali.Filiali.Contains(qruplarView.search)
                || (x.Seviyye == null) ? true : x.Seviyye.Seviyye_.Contains(qruplarView.search) || (x.Xidmetnovu.XidmetNovu_ == null) ? true : x.Xidmetnovu.XidmetNovu_.Contains(qruplarView.search)).ToList();
            if (item.Count != 0)
            {
              
            qruplarView.group = new ObservableCollection<Qruplar>(item);
            }
            else
            {
                   MessageBox.Show("Not Found");
            }
        }
    }
}
