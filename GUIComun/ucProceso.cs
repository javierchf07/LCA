using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GUIComun
{
    public enum EstadoFormulario { esEditando, esClave };
    public enum EstadoPermitido { esPermitido, noEsPermitido };
    public enum EstadoPermisos { Ejecutar, noEjecutar };

    public partial class ucProceso : ucModulo
    {
        #region Atributos
        private EstadoFormulario m_Estado;
        private EstadoPermitido m_Permitido;
        private EstadoPermisos m_Permiso;
        protected bool entornoConfigurado;

        public EstadoFormulario Estado {
            get { return m_Estado; }
            set { setEstadoFormulario(value); }
        }

        public EstadoPermitido Permitido {
            get { return m_Permitido; }
            set { setPermitir(value); }
        }

        public EstadoPermisos Permisos {
            get { return m_Permiso; }
            //set { setPermiso(value); }
        }

        #endregion

        #region constructores

        public ucProceso()
        {            
            InitializeComponent();
            m_Estado = EstadoFormulario.esClave;
            /*asignamos un evento a la coleccion de tablas, de modo que 
             cada vez que se cree una nueva tabla dispare un evento*/
            datos.Tables.CollectionChanged += tablasCambiadas;
        }

        private void tablasCambiadas(object sender, CollectionChangeEventArgs e)
        {
            DataTable nuevo;
            if (e.Action == CollectionChangeAction.Add)
            {
                nuevo = (DataTable)e.Element;
                nuevo.TableNewRow += eventoNuevoRegistro;
            }
        }

        private void eventoNuevoRegistro(object sender, DataTableNewRowEventArgs e)
        {
            NuevoRegistro(e.Row.Table.TableName, e.Row);
        }


        #endregion
        #region Accesores y modificadores
        protected virtual void setEstadoFormulario(EstadoFormulario value)
        {
            m_Estado = value;
            sbuGuardar.Enabled = value == EstadoFormulario.esEditando;
            sbuCancelar.Enabled = value == EstadoFormulario.esEditando;
            sbuEliminar.Enabled = value == EstadoFormulario.esEditando;
        }

        protected virtual void setEstadoBotones(bool escribir) {
            if (escribir)
            {
                setEstadoFormulario(EstadoFormulario.esEditando);
            }
            else
            {
                setPermitir(EstadoPermitido.esPermitido);
            }
        }

        private void setPermitir(EstadoPermitido value)
        {
            m_Permitido = value;
            sbuGuardar.Enabled = value == EstadoPermitido.esPermitido;
            sbuEliminar.Enabled = value == EstadoPermitido.esPermitido;
        }

        protected virtual void setPermiso(bool value) {
            if (value)
            {
                Estado = EstadoFormulario.esClave;
            }
            else
            {
                paSuperior.Enabled = value;
                paInferior.Enabled = value;
                paCentral.Enabled = value;
            }
        }
        #endregion
        #region metodos overridables
        protected virtual void ConfigurarEntorno()
        {
            entornoConfigurado = true;
        }
        public virtual void ConfigurarnuevaFila(string tabla, DataRow registro) { }
        public virtual void Nuevo()
        {
            LimpiarDataSet();
        }
        
        public virtual void Guardar() { }
        public virtual void Cancelar() {
            LimpiarDataSet();
            Estado = EstadoFormulario.esClave;
        }

        public virtual void Eliminar()
        {
            Estado = EstadoFormulario.esClave;
        }
        public virtual int Recuperar() { return 0; }
        public virtual void Cerrar() { }
        #endregion
        #region Servicios
        protected void FinalizaEdicion() {
            CurrencyManager cm;
            foreach (DataTable dt in datos.Tables)
            {
                cm = (CurrencyManager)this.BindingContext[dt];
                cm.CancelCurrentEdit();
            }
        }
        /// <summary>
        /// metodo que se dispara cada vez que se crea un nuevo registro
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="row"></param>
        private void NuevoRegistro(string tableName, DataRow row)
        {
            throw new NotImplementedException();
        }

        protected DataTable ObtenerTabla(string nombre, bool crearSiNoExiste)
        {
            DataTable retval = datos.Tables[nombre];
            if (retval == null && crearSiNoExiste)
                retval = datos.Tables.Add(nombre);
            return retval;
        }

        protected DataTable GenerarTabla(string tabla, IDataReader reader)
        {
            DataTable destino = ObtenerTabla(tabla, true);
            destino.Rows.Clear();
            CrearTablaReader(reader, destino, destino.Columns.Count == 0, true);
            return destino;
        }

        public int CrearTablaReader(IDataReader reader, DataTable tabla, 
                                    bool crearEstructura, bool llenarDatos)
        {
            if (crearEstructura || tabla.Columns.Count==0)
            {
                tabla.Columns.Clear();
                DataTable schemaTable = reader.GetSchemaTable();
                ArrayList pkCols = new ArrayList();
                int i, n;
                n = reader.FieldCount;
                for ( i = 0; i < n; i++)
                {
                    DataColumn col = new DataColumn();
                    col.ColumnName = reader.GetName(i);
                    col.DataType = reader.GetFieldType(i);

                    if (col.DataType.ToString()=="System.String")
                    {
                        col.MaxLength = (Int32)schemaTable.Rows[i]["ColumnSize"];
                    }
                    col.Unique = (bool)schemaTable.Rows[i]["IsUnique"];
                    col.AutoIncrement = (bool)schemaTable.Rows[i]["IsAutoIncrement"];
                    tabla.Columns.Add(col);
                }
            }
            if (llenarDatos)
                LlenarTabla(tabla, reader);
            reader.Close();
            return tabla.Rows.Count;
        }

        public int LlenarTabla(DataTable tabla, IDataReader reader)
        {
            object[] aData = new object[tabla.Columns.Count];
            while (reader.Read())
            {
                reader.GetValues(aData);
                tabla.Rows.Add(aData);
            }
            tabla.AcceptChanges();
            return tabla.Rows.Count;
        }

        protected virtual void LimpiarDataSet()
        {
            foreach (DataTable dt in datos.Tables)
            {
                dt.Rows.Clear();
            }
        }
        protected void BlanquearDataSet()
        {
            datos.Clear();
            datos.Tables.Clear();
            datos.Relations.Clear();
        }

        #endregion

        #region eventos
        private void sbuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
                Estado = EstadoFormulario.esClave;
            }
            catch 
            {
                Estado = EstadoFormulario.esEditando;
            }
        }

        private void sbuCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void sbuEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este registro?",
                                "Confirmacion",MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                Eliminar();
                Estado = EstadoFormulario.esClave;
            }
        }

        private void sbuCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        #endregion
    }
}
