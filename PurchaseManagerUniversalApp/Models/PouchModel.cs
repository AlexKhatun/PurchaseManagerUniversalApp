using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PouchModel
    {
        [DataMember]
        public int PouchId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Money { get; set; }
        [DataMember]
        public ICollection<PurchaseModel> Purchases { get; set; } 
    }
}
