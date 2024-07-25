using Microsoft.EntityFrameworkCore;
using System;

namespace HomeWork5.DataBase
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options)
            : base(options) { }

        public DbSet<CVClass> CVdb { get; set; }
    }


}
