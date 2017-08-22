using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobsMega.DTO
{
    public class OrderDTO
    {
        public System.Guid OrderId { get; set; }
        public PapaBobsMega.DTO.Enums.Size Size { get; set; }
        public PapaBobsMega.DTO.Enums.Crust Crust { get; set; }
        public bool GreenPeppers { get; set; }
        public bool Onions { get; set; }
        public bool Pepperoni { get; set; }
        public bool Sausage { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public PapaBobsMega.DTO.Enums.Payment PaymentType { get; set; }
        public bool Finished { get; set; }
    }
}
