using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PurchaseModel
    {
        [DataMember]
        public int PurchaseId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public DateTime Period { get; set; }
        [DataMember]
        public int Priority { get; set; }
        [DataMember]
        public PouchModel Pouch { get; set; }
    }
}
