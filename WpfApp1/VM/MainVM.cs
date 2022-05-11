using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.Add;
using WpfApp1.Tools;


namespace WpfApp1.VM
{
     class MainVM : BaseVM
        {
            CurrentPageControl currentPageControl;

            public Page CurrentPage
            {
                get => currentPageControl.Page;
            }

            public CommandVM CreateClient { get; set; }
            public CommandVM ViewClients { get; set; }
            public CommandVM CreateOperator { get; set; }
            public CommandVM ViewOperators { get; set; }

            public CommandVM CreateOplata { get; set; }
            public CommandVM ViewOplata { get; set; }
            public CommandVM CreateTour { get; set; }
            public CommandVM ViewTour { get; set; }

            public MainVM()
            {
                currentPageControl = new CurrentPageControl();
                currentPageControl.PageChanged += CurrentPageControl_PageChanged;
                
                CreateClient = new WpfApp15.Tools.CommandVM(() => {
                    currentPageControl.SetPage(new AddClient(new AddClientVM(currentPageControl)));
                });
                ViewClient = new CommandVM(() => {
                    currentPageControl.SetPage(new ViewClient());
                });
            CreateOperator = new CommandVM(() => {
                currentPageControl.SetPage(new AddOperator(new AddOperatorsVM(currentPageControl)));
            });

            ViewOperator = new CommandVM(() =>
            {
                currentPageControl.SetPage(new ViewOperator());
            });
            CreateOplata = new CommandVM(() => {
                    currentPageControl.SetPage(new AddOplata(new AddOplataVM(currentPageControl)));
                });

                ViewOplata = new CommandVM(() =>
                {
                    currentPageControl.SetPage(new ViewOplata());
                });
                CreateTour = new CommandVM(() => {
                    currentPageControl.SetPage(new AddTour(new AddTourVM(currentPageControl)));
                });

                ViewTour = new CommandVM(() =>
                {
                    currentPageControl.SetPage(new ViewTour());
                });
            }

            private void CurrentPageControl_PageChanged(object sender, EventArgs e)
            {
                Signal(nameof(CurrentPage));
            }
        }
    }