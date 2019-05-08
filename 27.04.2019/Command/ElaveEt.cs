using _27._04._2019.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _27._04._2019.Command
{
    class ElaveEt : ICommand
    {
        public QruplarView qruplarView { get; set; }
        public ElaveEt(QruplarView QruplarView)
        {
            qruplarView = QruplarView;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var item = qruplarView.groups.FirstOrDefault(x => x.Id == qruplarView.currentQruplar.Id);
            if (item == null)
            {
                int count = qruplarView.groups.Count;
                qruplarView.groups.Add(qruplarView.currentQruplar);
                qruplarView.groups[count].Id = count + 1;
            }
            qruplarView.currentQruplar = new Entity.Qruplar();

        }
    }
}
