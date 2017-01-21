using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeAmigos.Store.DAL;
using ThreeAmigos.Store.Models;
using System.Data.Entity;

namespace ThreeAmigos.Store.Tests
{
   
        class TestProductDbSet : TestDbSet<ProductViewModel>
        {
            public override ProductViewModel Find(params object[] keyValues)
            {
                return this.SingleOrDefault(product => product.ID == (int)keyValues.Single());
            }
        }
    }

