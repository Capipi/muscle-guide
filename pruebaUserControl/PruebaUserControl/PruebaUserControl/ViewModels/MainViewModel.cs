using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaUserControl.Models;

namespace PruebaUserControl.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Properties

        private DataInput input1;

        public DataInput Input1
        {
            get 
            {
                return input1;
            }
            set
            {
                if (input1 == value)
                {
                    return;
                }
                input1 = value;
                OnPropertyChanged(nameof(Input1));
            }
        }

        private DataInput input2;

        public DataInput Input2
        {
            get
            {
                return input2;
            }
            set
            {
                if (input2 == value)
                {
                    return;
                }
                input2 = value;
                OnPropertyChanged(nameof(Input2));
            }
        }
        public MainViewModel()
        {
            Input1 = new DataInput()
            {
                Title = Literals.NameLabel,
                MaxLength = Literals.Max30
            };

            Input2 = new DataInput()
            {
                Title = Literals.DescriptionLabel,
                MaxLength = Literals.Max140
            };
        }
    #endregion
    }
}
