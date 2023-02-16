using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Componentes
{
    public partial class DecimalTextbox2 : Component
    {
        public DecimalTextbox2()
        {
            InitializeComponent();
        }

        public DecimalTextbox2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
