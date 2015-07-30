using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ViewModels
{
    public class AddPurchaseViewModel : CustomViewModelBase
    {
        public AddPurchaseViewModel()
        {
            this.PriorityContext = new List<int> {1,2,3};
        }

        public PurchaseModel Purchase { get; set; }

        public List<int> PriorityContext { get; set; } 
    }
}
