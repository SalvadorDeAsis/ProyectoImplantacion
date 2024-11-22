using General.CLS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.Controlador
{
    internal class ControladorPacientes
    {
        /*METODO PARA INSERTAR PACIENTE*/
        public bool InsertarPaciente(string nommbre, string apellido, DateTime FechaNacimiento, string Genero, string telefono,
            string correo, string direccion)
        {
            var paciente = new Paciente()
            {
                Nombre = nommbre,
                Apellido = apellido,
                FechaNacimiento = FechaNacimiento,
                Genero = Genero,
                Telefono = telefono,
                CorreoElectronico = correo,
                Direccion = direccion
            };
            return paciente.Insertar();
        }
        /*METODO PARA ACTUALIZAR PACIENTE*/
        public bool ActualizarPaciente(string nommbre, string apellido, DateTime FechaNacimiento, string Genero, string telefono,
            string correo, string direccion)
        {
            var paciente = new Paciente()
            {
                Nombre = nommbre,
                Apellido = apellido,
                FechaNacimiento = FechaNacimiento,
                Genero = Genero,
                Telefono = telefono,
                CorreoElectronico = correo,
                Direccion = direccion
            };
            return paciente.Actualizar();
        }
        /*METODO PARA ELIMINAR PACIENTE*/
        public bool EliminarPaciente(int idPaciente)
        {
            var paciente = new Paciente { ID_Paciente = idPaciente };
            return paciente.Eliminar();
        }

    }
}
