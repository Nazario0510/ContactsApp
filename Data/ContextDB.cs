using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactsApp.Models;

namespace ContactsApp.Data
{
    public class ContextDB:DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options):base(options)
        {

        }

        public DbSet<Contact> contacts { get; set; }
    }
}
