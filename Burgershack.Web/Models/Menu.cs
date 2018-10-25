using Burgershack.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Burgershack.Web.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public List<Drink> Drinks { get; set; }
        public List<Burger> Burgers { get; set; }
    }
}
