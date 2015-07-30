using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using DataAccess;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using Models;
using ViewModels;

namespace PurchaseManagerUniversalApp.ViewModels
{
    public class AddPouchWin8ViewModel : AddPouchPageViewModel
    {
        public AddPouchWin8ViewModel()
        {
            Pouch = new PouchModel();
            Nav.Configure("MainPage", typeof(MainPage));
            Back = new RelayCommand(NavigateBack);
            AddPouch = new RelayCommand(NewPouch);
        }

        public RelayCommand Back { get; set; }

        public RelayCommand AddPouch { get; set; }

        private void NavigateBack()
        {
            Nav.NavigateTo("MainPage");
        }

        private void NewPouch()
        {
            JsonSerializer ser = new JsonSerializer();
            ser.SerializePouch(this.Pouch);
            this.Pouch = ser.DeserializePouch();
            Nav.GoBack();
        }
    }
}
