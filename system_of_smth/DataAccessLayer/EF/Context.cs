using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
//using DataAccessLayer.

namespace DataAccessLayer.EF
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ComplexArchitectureDB;Trusted_Connection=True;");
        }
    }
}
