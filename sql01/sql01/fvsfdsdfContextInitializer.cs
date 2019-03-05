using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql01
{
    //TODO:2 add the context initializer
    class fvsfdsdfContextInitializer : DropCreateDatabaseIfModelChanges<fvsfdsdfEntities>
    {
        protected override void Seed(fvsfdsdfEntities context)
        {

        }
    }
}
