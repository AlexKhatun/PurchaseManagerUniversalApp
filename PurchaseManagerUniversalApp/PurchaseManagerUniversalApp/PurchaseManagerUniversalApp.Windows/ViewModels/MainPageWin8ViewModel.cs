using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using Models;
using ViewModels;

namespace PurchaseManagerUniversalApp.ViewModels
{
    public class MainPageWin8ViewModel : MainPageViewModel
    {
        public MainPageWin8ViewModel()
        {
            this.Nav = new NavigationService();
            this.NavConfig();
            this.AddPouch = new RelayCommand(this.NavigateToAddPouch);
            this.AddPurchase = new RelayCommand(this.NavigateToAddPurchase);
        }

        public RelayCommand AddPouch { get; set; }

        public RelayCommand AddPurchase { get; set; }

        private void NavigateToAddPouch()
        {
            Nav.NavigateTo("AddPouchPage");
        }

        private void NavigateToAddPurchase()
        {
            Nav.NavigateTo("AddPurchasePage");
        }

        private void NavConfig()
        {
            Nav.Configure("AddPouchPage", typeof(AddPouchPage));
            Nav.Configure("AddPurchasePage", typeof(AddPurchasePage));
        }
    }
}
