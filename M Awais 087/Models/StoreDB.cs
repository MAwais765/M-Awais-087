using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M_Awais_087.Models
{
    public class StoreDB : DbContext

    {
        public StoreDB(DbContextOptions<StoreDB> options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
    }
}
