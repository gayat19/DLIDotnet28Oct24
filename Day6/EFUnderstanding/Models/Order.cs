using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnderstanding.Models
{

    public class Order
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        public string OrderStatus { get; set; } = "New";
        public Customer? Customer { get; set; }
        

    }

}
