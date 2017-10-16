using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS1ProjectTeam02.Entities
{
    // This is the Transaction class that is used in order to convert the contents into 
    // the safe type
    class Transaction
    {
        public int id { get; set; }
        public int orderQuantity { get; set; }
        public decimal sales { get; set; }
        public string shippingMode { get; set; }
        public decimal profits { get; set; }
        public decimal unitPrice { get; set; }
        public string customerName { get; set; }
        public string province { get; set; }
        public string customerSegment { get; set; }
        public string productCategory { get; set; }
        public string productSubCategory { get; set; }
        public string productName { get; set; }

    }
}
