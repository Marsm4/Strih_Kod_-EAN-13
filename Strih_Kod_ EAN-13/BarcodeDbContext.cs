using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Strih_Kod__EAN_13.MainWindow;

namespace Strih_Kod__EAN_13
{
    public class BarcodeDbContext : DbContext
    {
        public BarcodeDbContext() : base("name=BarcodeDBConnectionString") { }

        public DbSet<Product> Products { get; set; }
    }
}
