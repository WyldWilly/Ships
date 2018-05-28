using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ships.Data.Context;
using Ships.Data.Entities;

namespace Ships.Data.Repositories
{
    public class Repository
    {
        private ShipContext ctx;

        public Repository(string connString)
        {
            ctx = new ShipContext(connString);
        }

        #region Insert
        public ShipContext Insert(ShipContext P)
        {
            try
            {
                P = ctx.ShipI


            }
            catch
            {


            }


        }


        #region Update

        #region Delete

        #region Retrieval

    }
}
