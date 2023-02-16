using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Componentes
{
    public partial class ControlesObrigatorios : Component
    {
        public ControlesObrigatorios()
        {
            InitializeComponent();
        }

        public ControlesObrigatorios(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
