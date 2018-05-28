using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Ships.Data.Entities;

namespace Ships.Data.Mapper
{
    public class ShipIndex : EntityTypeConfiguration<shipindex>
    {
        public ShipIndex()
        {
            ToTable("shipindex");
            HasKey(c => c.Id);

            Property(c => c.Id).IsRequired().HasColumnName("Id").HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name).IsRequired().HasColumnName("Name").HasColumnType("varchar").HasMaxLength(45);
            Property(c => c.Registry).IsRequired().HasColumnName("Registry").HasColumnType("varchar").HasMaxLength(15);
            Property(c => c.Class).IsRequired().HasColumnName("Class").HasColumnType("varchar").HasMaxLength(45);
            Property(c => c.Type).IsRequired().HasColumnName("Type").HasColumnType("int");
            Property(c => c.ClassShip).IsRequired().HasColumnName("ClassShip").HasColumnType("boolean");
            Property(c => c.Status).IsRequired().HasColumnName("Status").HasColumnType("boolean");
        }
    }

    public class ShipTypes : EntityTypeConfiguration<shiptypes>
    {

        public ShipTypes()
        {
            ToTable("shiptypes");
            HasKey(s=> s.Id);

            Property(s=> s.Id).IsRequired().HasColumnName("Id").HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.ShipTypeName).IsRequired().HasColumnName("ShipTypeName").HasColumnType("varchar").HasMaxLength(45);
            Property(s => s.ShipTypeName).IsRequired().HasColumnName("ShipTypeName").HasColumnType("int");
            Property(s => s.Abbrev).IsRequired().HasColumnName("Abbrev").HasColumnType("varchar").HasMaxLength(10);

        }
    }

    public class IniTable : EntityTypeConfiguration<initable>
    {
        public IniTable()
        {
            ToTable("initable");
            HasKey(t => t.Id);

            Property(t=> t.Id).IsRequired().HasColumnName("Id").HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t=> t.CodeSetName).IsRequired().HasColumnName("CodeSetName").HasColumnType("varchar").HasMaxLength(45);
            Property(t=> t.CodeSetValue).IsRequired().HasColumnName("CodeSetValue").HasColumnType("varchar").HasMaxLength(45);
            Property(t => t.CodeSetId).IsRequired().HasColumnName("CodeSetID").HasColumnType("int");
            Property(t=> t.Status).IsRequired().HasColumnName("Status").HasColumnType("boolean");

        }


    }
}
