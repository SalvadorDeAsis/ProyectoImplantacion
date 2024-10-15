using Principal.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Principal.GUI
{
    public partial class Login : Form
    {
       private Boolean _Autorizado = false;

        public Login()
        {
            InitializeComponent();
        }
        public bool Autorizado { get => _Autorizado; set => _Autorizado = value; }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            /* DataTable dt = new DataTable();

             DataLayer.DBOperaciones oOperacion = new DataLayer.DBOperaciones();
             String query = "SELECT ID_Usuario,Empleados_ID_Empleado, Roles_ID_Rol FROM usuarios WHERE Usuario ='" + txtUsuario.Text + "' AND Clave = '" + txtClave.Text + "';";
             dt = oOperacion.Consultar(query);

             dt.Rows.Count == 1*/

            SesionLogin dt = new SesionLogin();
            dt.Username1(txtUsuario.Text);
            dt.password1(txtClave.Text);

            if (dt.Verificar())
            {
                _Autorizado = true;
                Close();
            }
            else
            {
                MessageBox.Show("ERROR CONTRASEÑA O USUARIO INCORRECTO.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
