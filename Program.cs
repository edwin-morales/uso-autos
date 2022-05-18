using System;
namespace usoAutos
{
    class Program
    {
        static void Main(string[]args)
        {

            autos autos1 = new autos();

            autos autos = new autos();

            Console.WriteLine(autos1.getInfoAutos());

        }

    }

    class autos
    {

        public autos ()
        {
            ruedas = 4;

            largo = 2300.5;

            ancho = 0.800;

        }
        public String getInfoAutos()
        {
            return "Informacion del autos:\n " + "Ruedas:" + ruedas + " largo " + largo + " ancho " + ancho;

        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private string tapiceria;

    }
}