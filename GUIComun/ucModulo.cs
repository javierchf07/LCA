using System;
using System.Windows.Forms;

namespace GUIComun
{
    
    public partial class ucModulo : UserControl
    {
        private string n_Nombre_Proceso;
        public string NombreProceso
        {
            get
            {
                return n_Nombre_Proceso;
            }
        }
        public ucModulo()
        {
            InitializeComponent();
        }
        protected virtual void SetNombreProceso(string value)
        {
            n_Nombre_Proceso = value;
        }
        public EventHandler ClickCerrar
        {
            set
            {
                SetCerrar(value);
            }
        }
        protected virtual EventHandler GetCerrar()
        {
            return null;
        }

        protected virtual void SetCerrar(EventHandler e)
        {
        }
    }
}
