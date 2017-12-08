using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhasCompras.Models;

namespace MinhaLista.Models
{
    public class ItemMap
    {
        public ItemMap(EntityTypeBuilder<Item> entityBuilder)
        {
            entityBuilder.HasKey(i => i.ID);
            entityBuilder.Property(i => i.Nome).IsRequired();
            entityBuilder.Property(i => i.Checked);
        }
    }
}
