using _27._04._2019.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _27._04._2019.Command
{
    class Imtina : ICommand
    {
        public QruplarView qruplarView { get; set; }


        public Imtina(QruplarView QruplarView)
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
            qruplarView.state = 1;
            var item = qruplarView.groups.FirstOrDefault(x => x.Id == qruplarView.currentQruplar.Id);
            qruplarView.groups.Remove(item);
            qruplarView.currentQruplar = new Entity.Qruplar();
            qruplarView.selectQruplar = null;
            qruplarView.selectQruplar = new Entity.Qruplar();
        }
    }
}
