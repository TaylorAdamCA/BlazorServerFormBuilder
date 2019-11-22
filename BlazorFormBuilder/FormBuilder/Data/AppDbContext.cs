using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormBuilder.Data.Entities.Forms;
using Microsoft.EntityFrameworkCore;

namespace FormBuilder.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Form> Forms { get; set; }
        public DbSet<FormField> FormFields { get; set; }
        public DbSet<FormWithFields> FormWithFields { get; set; }
    }
}