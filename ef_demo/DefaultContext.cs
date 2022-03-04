using ef_demo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_demo
{
    public class DefaultContext:DbContext
    {
        public DbSet<ModelA> ModelAs { get; set; }
        public DbSet<ModelB> ModelBs { get; set; }

        string sqlStr = "data source=ZWL; Initial Catalog=ef_db; uid=sa; pwd=sqlserver";

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(sqlStr);
    }
}
