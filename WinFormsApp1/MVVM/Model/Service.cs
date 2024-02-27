using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.MVVM.Model
{
    public class Service 
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }

        public Service(string serviceName, decimal price)
        {
            ServiceName = serviceName;
            Price = price;
        }
        public Service(int serviceId, string serviceName, decimal price)
        {
            ServiceId = serviceId;
            ServiceName = serviceName;
            Price = price;
        }
        public Service() { }
    }
}
