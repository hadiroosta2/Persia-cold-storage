using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Persia_cold_storage.Models
{
    public class Persia:DbContext
    {
        public Persia():base("name=PCString")
        {

        }
        static Persia()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Persia>());
        }
        public DbSet<user> users { get; set; }
    }
}