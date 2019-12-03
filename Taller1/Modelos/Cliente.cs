using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1.Modelos
{
    public class Cliente
    {
        public Cliente(String nombre, String apellido, DateTime fechanacimiento) {
            
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechanacimiento;
            Edad = DateTime.Today.AddTicks(-fechanacimiento.Ticks).Year - 1;
        }

        public Cliente(String direccion)
        {
            Direccion = direccion;
        }

        public Cliente()
        {
            
        }

        public String Nombre, Apellido, Direccion;
        public int Telefono, Edad;
        public DateTime FechaNacimiento;

        

    }

}
