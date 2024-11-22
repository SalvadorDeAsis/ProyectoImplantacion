using General.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.GUIEdicion
{
    public partial class PacientesEdicion : Form
    {
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtNombresPaciente.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtNombresPaciente, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }
        public PacientesEdicion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try { 
                if(Validar())
                {
                    
                    try
                    {
                        int ID_Paciente = Convert.ToInt32(txtIdPaciente.Text);
                    }catch(Exception) { 
                        int ID_Paciente=0;
                    }

                    //asignacion de los textbox a las variables de clase        
                    string Nombre = txtNombresPaciente.Text;
                    string Apellido = txtApellidosPaciente.Text;
                    DateTime FechaNacimiento = dtpFechaNac.Value;
                    string Genero = cbGenero.Text;
                    string Telefono = txtTelefono.Text;
                    string CorreoElectronico = txtCorreoElectronico.Text;
                    string Direccion = txtDireccion.Text;

                    var controller = new ControladorPacientes();

                    bool resultado = controller.InsertarPaciente(Nombre, Apellido, 
                      
                        FechaNacimiento,Genero, Telefono, CorreoElectronico, Direccion);
                    
                    /*verificar si es para insertar o actualizar*/
                    if (txtIdPaciente.Text.Trim().Length == 0)
                    {
                        //Guardar los datos ingresados
                        if(resultado)
                        {
                            MessageBox.Show("Paciente Guardado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("!ERROR¡: El paciente no se puede registrar verifique la informacion");
                        }
                    }
                    else
                    {
                        bool resultado1 = controller.ActualizarPaciente(Nombre, Apellido, FechaNacimiento,
                            Genero, Telefono, CorreoElectronico, Direccion);
                        if (resultado1)
                        {

                            MessageBox.Show("Datos del Paciente Actualizados");
                            Close();
                        }
                    }
                }
            }catch (Exception) {
            }
        }
        private void PacientesEdicion_Load(object sender, EventArgs e)
        {}
        private void txtNombresPaciente_TextChanged(object sender, EventArgs e)
        {}
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
