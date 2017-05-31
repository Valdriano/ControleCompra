using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCompra.View
{

    public class MasterPaginaMenuItem
    {
        public MasterPaginaMenuItem()
        {
            TargetType = typeof( MasterPaginaDetail );
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}