using _27._04._2019.Entity;
using _27._04._2019.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _27._04._2019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            QruplarView qruplarVM = new QruplarView();
            qruplarVM.state = 1;
            qruplarVM.groups = new ObservableCollection<Qruplar>()
            {
                new Qruplar()
                {
                    Id=1,
                    QrupAdi="896a2",
                    Filiali =new Filial()
                    {
                        Id=1,
                        Filiali="Xetai",
                    },
                    Seviyye =new Seviyye()
                    {
                        Id=1,
                        Seviyye_=3,
                    },
                    Xidmetnovu =new XidmetNovu()
                    {
                        Id=1,
                        XidmetNovu_="Fizika",
                    }

                },
                new Qruplar()
                {
                    Id=2,
                    QrupAdi="866a2",
                    Filiali =new Filial()
                    {
                        Id=2,
                        Filiali="Yasamal",
                    },
                    Seviyye =new Seviyye()
                    {
                        Id=2,
                        Seviyye_=5,
                    },
                    Xidmetnovu =new XidmetNovu()
                    {
                        Id=2,
                        XidmetNovu_="Riyaziyyat",

                    }

                }
            };
            qruplarVM.Filials = new List<Filial>()
            {

                new Filial()
                {
                    Id =1,
                    Filiali="Xetai",

                },
                new Filial()
                {
                    Id=2,
                    Filiali="Yasamal",
                }
            };
            qruplarVM.Seviyyes = new List<Seviyye>()
            {

                new Seviyye()
                {
                    Id=1,
                    Seviyye_=3,
                },
                new Seviyye()
                {
                    Id=2,
                    Seviyye_=5,
                },
            };

            qruplarVM.XidmetNovu = new List<XidmetNovu>()
            {

                new XidmetNovu()
                {
                    Id=1,
                    XidmetNovu_="Fizika",
                },
                new XidmetNovu()
                {
                    Id=2,
                    XidmetNovu_="Riyaziyyat",
                }

            };
            DataContext = qruplarVM;
        }
    }
}
