using FoodDonationManagmentSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagmentSystem.Data
{
    public class DonarDbContext : DbContext
    {
        public DonarDbContext(DbContextOptions<DonarDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<DonarsModule> Donars { get; set; }
       

        }
    }
    
   

