using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experimento
{
    public partial class FormMantenimiento : Form
    {
        GenerarBD bdatos = new GenerarBD();
        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargaListaUsuarios()
        {
            string seleccion = "Select * from usuarios";
            if (bdatos.AbrirConexion())
            {
                dgvMantenimiento.DataSource = Mantenimiento.BuscarUsuario(bdatos.Conexion, seleccion);
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            try
            {
                if (bdatos.AbrirConexion())
                {
                    Mantenimiento jefe = new Mantenimiento();
                    Mantenimiento.Nombre = txtNombre.Text;
                    Mantenimiento.Apellidos = txtApellidos.Text;
                    Mantenimiento.nif = txtNIF.Text;

                    

                    if (String.IsNullOrEmpty(txtNIF.Text))  
                    {
                        if (Mantenimiento.YaEsta(bdatos.Conexion, jefe.Nombre, jefe.Apellidos))  
                            MessageBox.Show("Este usuario no se puede dar de alta. Ya existe");
                        }
                        else
                        {
                            resultado = jefe.AgregarUsuario(bdatos.Conexion, jefe);
                        }
                    }
                    else 
                    {
                        jefe.nif = Convert.ToInt16(txtNIF.Text);
                        resultado = jefe.ActualizaUsuario(bdatos.Conexion, jefe);
                    }

                    if (resultado > 0) 
                    {
                        LimpiarControles();
                    }

                    // Cierro la conexión
                    bdatos.CerrarConexion();
                    // volvemos a cargar toda la lista de usuarios;
                    CargaListaUsuarios();

                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally  // en cualquier caso cierro la conexión (haya error o no)
            {
                bdatos.CerrarConexion();
            }
        }

        // Busqueda de usuarios
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (bdatos.AbrirConexion())
            {
                dgvMantenimiento.DataSource = Mantenimiento.BuscarUsuario(bdatos.Conexion,
                                        txtNombre.Text, txtApellidos.Text, txtNIF.Text);
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        // Visualización de todos los datos de usuarios en el datagridview
        // Reseteo de las cajas de texto de información de un usuario
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // volvemos a cargar toda la lista de usuarios;
            CargaListaUsuarios();
            LimpiarControles();
        }


        // Elimina un usuario de la Base de Datos (con confirmación)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Para eliminar, el usuario selecciona un registro del datagrid. 
            // Posteriormente haremos clic en eliminar (nos pedirá confirmación)
            try
            {
                int resultado;

                if (dgvMantenimiento.SelectedRows.Count == 1) // Si hay una fila seleccionada en el datagridview
                {
                    int idUsuario = (int)dgvmantenimiento.CurrentRow.Cells[0].Value; // Obtenemos el id de la fila seleccionada

                    DialogResult confirmacion = MessageBox.Show("Borrado de registro seleccionado. ¿Continuar?",
                                                "Eliminación", MessageBoxButtons.YesNo);

                    if (confirmacion == DialogResult.Yes)
                    {
                        if (bdatos.AbrirConexion())
                        {
                            resultado = Mantenimiento.EliminaUsuario(bdatos.Conexion, idUsuario);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                        }
                        // Cierro la conexión
                        bdatos.CerrarConexion();
                        // volvemos a cargar toda la lista de usuarios;
                        CargaListaUsuarios();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
  




        }
    }

