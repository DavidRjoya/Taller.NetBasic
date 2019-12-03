namespace Taller1
{
    using Modelos;
    using System;

    class Program
    {
        static void Main(string[] args)
        {

          Cliente nuevoCliente;

            nuevoCliente = new Cliente("david","Alvarado",new DateTime(1999,7,2));


            //nuevoCliente.Nombre = "David";
            //nuevoCliente.Apellido = "Joya";
            //nuevoCliente.Edad = 19;
            //Clae
       
            Console.WriteLine($"Cliente 1 {nuevoCliente.Nombre} {nuevoCliente.Apellido} {nuevoCliente.Edad}");

            Cliente nuevoCliente2 = new Cliente("kr 95 a");
            nuevoCliente2.Nombre = "DAVID";
            Console.WriteLine($"Cliente 1 {nuevoCliente2.Nombre} {nuevoCliente2.Apellido} {nuevoCliente2.Edad} {nuevoCliente2.Direccion}");




            //getter obetener valor por defecto
        }
    }
}
