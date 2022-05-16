using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codeFristapjoins.Models
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext ():base("Data Source=CHETUIWK1144\\SQLSERVER;Initial Catalog=NamanData;Integrated " +
            "Security=True;Pooling=False") { }
        public DbSet<Department> departments { get; set; }
        public DbSet<Empoyes> empoyes { get; set; }
    }
}