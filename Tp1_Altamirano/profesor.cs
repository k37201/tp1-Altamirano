using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Altamirano
{
    class profesor : persona
    {
        public int matricula { get; set; }
        public materia m { get; set; }
        public comision c { get; set; }
    }
}
