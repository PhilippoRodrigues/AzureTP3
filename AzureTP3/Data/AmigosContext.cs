using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace AzureTP3.Data
{
    public class AmigosContext : DbContext
    {
        public AmigosContext (DbContextOptions<AmigosContext> options)
            : base(options)
        {
        }

        public DbSet<Modelo.Amigo> Amigo { get; set; }
    }
}
