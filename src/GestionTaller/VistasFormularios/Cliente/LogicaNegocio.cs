using BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTaller.VistasFormularios.Cliente
{
    public static class LogicaNegocio
    {
        /// <summary>
        /// Insercción a una tabla determinada
        /// </summary>
        /// <param name="tabla">Tabla que querramos insertar</param>
        /// <param name="numb">Datos</param>
        /// <param name="matricula">Datos</param>
        /// <param name="marca">Datos</param>
        /// <param name="modelo">Datos</param>
        /// <param name="tipo">Datos</param>
        /// <param name="dni">Datos</param>
        public static void EjecutarInserccion(string tabla, string numb, string matricula, string marca, string modelo, string tipo, string dni)
        {
            string instruccion = $"INSERT INTO {tabla} VALUES ('{numb}', '{matricula}', '{marca}', '{modelo}', '{tipo}', '{dni}')";

            ApiBaseDatos.EjecutarInstruccion(instruccion);
        }

    }
}
