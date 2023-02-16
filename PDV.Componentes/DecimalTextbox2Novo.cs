using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Componentes
{
    public partial class DecimalTextbox2Novo : Component
    {
        public DecimalTextbox2Novo()
        {
            InitializeComponent();
        }

        public DecimalTextbox2Novo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
