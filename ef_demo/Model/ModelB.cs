using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_demo.Model
{
    public class ModelB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ModelAId { get; set; }
        public ModelA modelA { get; set; }
    }
}
