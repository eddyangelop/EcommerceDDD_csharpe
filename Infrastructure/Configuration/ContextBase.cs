using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(String.Empty);
                base.OnConfiguring(optionsBuilder);
            }
        }

        //private string GetStringConnectionConfing()
        //{




          //  string strCon = "Data Source=LAPTOP-N3KBHKL3;Initial Catalog=DDD_ECOMMERCE;Integrated Security=False;User ID=eddyangelop;Password=Developer@123;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
           // return strCon;
        //}

    }
}
