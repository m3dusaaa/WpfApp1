using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DTO;
using WpfApp1.Tools;

namespace WpfApp1
{
    public class AddTourVM
    {
        public Tour AddTour { get; set; }
        public CommandVM SaveTour { get; set; }

        private CurrentPageControl currentPageControl;
        public AddTourVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddTour = new Tour();
            InitCommand();
        }
        public AddTourVM(AddTour AddTour, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddTour = AddTour;
            InitCommand();
        }

        public AddTourVM()
        {
        }

        private void InitCommand()
        {
            SaveTour = new CommandVM(() =>
            {
                var model = SqlModel.GetInstance();
                if (AddTour.ID == 0)
                    model.Insert(AddTour);
                else
                    model.Update(AddTour);
                currentPageControl.Back();
            });
        }



    }
}
  