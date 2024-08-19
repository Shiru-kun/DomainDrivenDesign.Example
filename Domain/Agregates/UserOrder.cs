using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Agregates
{
    public class UserOrder
    {
        public Guid Id { get; set; }
        public User User { get; set; }  
        public Order Order { get; set; }  

    }
}
