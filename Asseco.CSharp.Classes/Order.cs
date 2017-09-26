using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Classes
{
    class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string OrderNumber { get; set; }

        public decimal TotalAmount { get; set; }

        public Customer Customer { get; set; }

        public string Display
        {
            get
            {
                return $"Zamówienie nr {OrderNumber} \n z dn. {OrderDate} od {Customer.FullName} zamieszkały {Customer.HomeAddress.FullAdress} zatrudniony {Customer.WorkAddress.FullAdress}";
            }
            
        }


    }
}
