using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    internal class Medicamento
    {
        // Campos privados
        private int _ID_Insumo;
        private string _NombreInsumo;
        private string _Descripcion;
        private int _CantidadDisponible;
        private decimal _PrecioUnitario;
        private string _Proveedor;
        private DateTime _FechaVencimiento;
        private string _ImagenMedicamento;

        // Propiedades públicas
        public int ID_Insumo { get => _ID_Insumo; set => _ID_Insumo = value; }
        public string NombreInsumo { get => _NombreInsumo; set => _NombreInsumo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int CantidadDisponible { get => _CantidadDisponible; set => _CantidadDisponible = value; }
        public decimal PrecioUnitario { get => _PrecioUnitario; set => _PrecioUnitario = value; }
        public string Proveedor { get => _Proveedor; set => _Proveedor = value; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
        public string ImagenMedicamento { get => _ImagenMedicamento; set => _ImagenMedicamento = value; }

        // Método para insertar un nuevo medicamento
        public bool Insertar()
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("INSERT INTO `Medicamentos` (`NombreInsumo`, `Descripcion`, `CantidadDisponible`, `PrecioUnitario`, `Proveedor`, `FechaVencimiento`, `ImagenMedicamento`) VALUES (");
            sentencia.Append("'" + _NombreInsumo + "', '" + _Descripcion + "', '" + _CantidadDisponible + "', '" + _PrecioUnitario + "', '" + _Proveedor + "', '" + _FechaVencimiento.ToString("yyyy-MM-dd") + "', '" + _ImagenMedicamento + "');");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resultado = false;
            }

            return resultado;
        }

        // Método para actualizar un medicamento existente
        public bool Actualizar()
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("UPDATE `Medicamentos` SET ");
            sentencia.Append("`NombreInsumo` = '" + _NombreInsumo + "', ");
            sentencia.Append("`Descripcion` = '" + _Descripcion + "', ");
            sentencia.Append("`CantidadDisponible` = '" + _CantidadDisponible + "', ");
            sentencia.Append("`PrecioUnitario` = '" + _PrecioUnitario + "', ");
            sentencia.Append("`Proveedor` = '" + _Proveedor + "', ");
            sentencia.Append("`FechaVencimiento` = '" + _FechaVencimiento.ToString("yyyy-MM-dd") + "', ");
            sentencia.Append("`ImagenMedicamento` = '" + _ImagenMedicamento + "' ");
            sentencia.Append("WHERE `ID_Insumo` = '" + _ID_Insumo + "';");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resultado = false;
            }

            return resultado;
        }

        // Método para eliminar un medicamento existente
        public bool Eliminar()
        {
            bool resultado = false;
            DataLayer.DBOperaciones operacion = new DataLayer.DBOperaciones();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("DELETE FROM `Medicamentos` ");
            sentencia.Append("WHERE `ID_Insumo` = " + _ID_Insumo + ";");

            try
            {
                if (operacion.EjecutarSentencia(sentencia.ToString()) >= 0)
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resultado = false;
            }

            return resultado;
        }
    }
}
