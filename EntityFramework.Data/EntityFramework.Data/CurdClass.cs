using EntityFramework.Data.DemoEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
    public  class CurdClass
    {
        private DemoDbContext demo;
        public CurdClass()
        {
            demo = new DemoDbContext();
        }
        public void insert(ClassRoom deatils)
        {
            demo.Class.Add(deatils);
            demo.SaveChanges();

        }
    }
}
