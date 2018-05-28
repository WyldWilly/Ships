using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships.Data.Entities
{
    public class shipindex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Registry { get; set; }
        public string Class { get; set; }
        public int Type { get; set; }
        public bool ClassShip { get; set; }
        public bool Status { set; get; }
    }

    public class shiptypes
    {
        public int Id { get; set; }
        public string ShipTypeName { get; set; }
        public int ShipTypeCode { get; set; }
        public string Abbrev { get; set; }
    }

    public class initable
    {
        public int Id { get; set; }
        public string CodeSetName { get; set; }
        public string CodeSetValue { get; set; }
        public int CodeSetId { get; set; }
        public bool Status { get; set; }

    }
}
