using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.CLS
{
    internal class SesionLogin
    {
        string Username;
        string Password;

        public void Username1(string user) {
            Username = user;
        }
        public void password1(string pass)
        {
            Password = pass;
        }
       

        public Boolean Verificar()
        {
            Boolean Resultado = false;
            DataTable dt = new DataTable();

            DataLayer.DBOperaciones oOperacion = new DataLayer.DBOperaciones();
            String query = "SELECT ID_Usuario,Empleados_ID_Empleado, Roles_ID_Rol FROM usuarios WHERE Usuario ='" + Username+ "' AND Clave = '" + Password + "';";
            dt = oOperacion.Consultar(query);

            try
            {
                if (dt.Rows.Count == 1)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }

            }
            catch (Exception)
            {
                Resultado |= false;
            }

            return Resultado;
        }

        public void CerrarSesion()
        {
           
            Username = null;
            Password = null;

           
            
        }

    }
}
