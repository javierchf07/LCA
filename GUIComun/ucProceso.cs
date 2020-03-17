using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIComun
{
    public enum EstadoFormulario { esEditando, esClave };
    public enum EstadoPermitido { esPermitido, noEsPermitido };
    public enum EstadoPermisos { Ejecutar, noEjecutar };

    public partial class ucProceso : ucModulo
    {
        private EstadoFormulario m_Estado;
        private EstadoPermitido m_Permitido;
        private EstadoPermisos m_Permiso;



        public ucProceso()
        {            
            InitializeComponent();
        }
    }
}
