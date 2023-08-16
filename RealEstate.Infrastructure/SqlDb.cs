using Microsoft.EntityFrameworkCore;
using Realestate.Models;
using RealEstate.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RealEstate.Infrastructure
{
    public class SqlDb : DbContext
    {

        public SqlDb(DbContextOptions<SqlDb> options) : base(options)
        {


        }

        public DbSet<RealEstatesE> realEstates { get; set; }
        public DbSet<Booking> bookings { get; set; }
    }
}
