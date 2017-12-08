using MinhaLista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasCompras.Models
{
    public class Item : BaseEntity
    {
        //public int ID { get; set; }
        public string Nome { get; set; }
        public Boolean Checked { get; set; }
    }
}
