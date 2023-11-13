using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYListas.Dtos
{
    internal class ClienteDto
    {
        //Atributos (Caracteristicas)
         string nombreCliente;

         string apellidosCliente;

         string dniCliente;

         DateOnly fechaNacimientoCliente;

         string emailCliente;

         int tlfCliente;

         DateOnly fchAltaCliente;

         DateOnly fchBajaCliente;

        //Getters y Setters
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public DateOnly FechaNacimientoCliente { get => fechaNacimientoCliente; set => fechaNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public DateOnly FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public DateOnly FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }

       



        //Constructores

        public ClienteDto()
        {

        }

        public ClienteDto(string nombreCliente, string dniCliente)
        {
            this.nombreCliente = nombreCliente;
            this.dniCliente = dniCliente;
        }

        public ClienteDto(string nombreCliente, string apellidosCliente, string dniCliente, DateOnly fechaNacimientoCliente, string emailCliente, int tlfCliente, DateOnly fchAltaCliente) : this(nombreCliente, apellidosCliente)
        {
            this.dniCliente = dniCliente;
            this.fechaNacimientoCliente = fechaNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
        }







        //ToString

        public string toString()
        {
            string objetoString= this.nombreCliente +" "+ this.dniCliente;

            return objetoString;
        }
    }
}
