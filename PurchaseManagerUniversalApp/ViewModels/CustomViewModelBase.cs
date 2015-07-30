using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using Models;

namespace ViewModels
{
    public class CustomViewModelBase : ViewModelBase
    {
        protected NavigationService Nav;

        public CustomViewModelBase()
        {
            this.Nav = new NavigationService();
        }

        public PouchModel Pouch { get; set; }
    }
}
