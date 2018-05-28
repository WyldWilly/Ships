using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Ships.Data.Entities;
using Ships.Data.Mapper;

namespace Ships.Data.Context
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ShipContext:DbContext
    {
        public ShipContext(string connString) : base(connString)
        {

        }

        //Db Sets

        public DbSet<ShipIndex> ShipI{ get; set; }
        public DbSet<ShipTypes> TypeI { get; set; }
        public DbSet<IniTable> IniI { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ShipIndex());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ShipTypes());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new IniTable());
            base.OnModelCreating(modelBuilder);

        }


    }
}
