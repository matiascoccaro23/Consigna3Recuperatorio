using System;

namespace Consigna3RecuperatorioCilindro
{
    struct Cilindro
    {
        private double radio;
        private double altura;
        public Cilindro(double radio, double altura)
        {
            if (radio <= 0 || altura <= 0)
            {
                throw new ArgumentException("El radio y la altura deben ser mayores a cero.");
            }

            this.radio = radio;
            this.altura = altura;
        }
        public void EstablecerRadio(double radio)
        {
            if (radio > 0)
            {
                this.radio = radio;
            }
            else
            {
                throw new ArgumentException("El radio debe ser mayor a cero.");
            }
        }
        public double ObtenerRadio()
        {
            return this.radio;
        }
        public void EstablecerAltura(double altura)
        {
            if (altura > 0)
            {
                this.altura = altura;
            }
            else
            {
                throw new ArgumentException("La altura debe ser mayor a cero.");
            }
        }
        public double ObtenerAltura()
        {
            return this.altura;
        }
        public double CalcularSuperficie()
        {
            return 2 * Math.PI * Math.Pow(radio, 2) + 2 * Math.PI * radio * altura;
        }
        public double CalcularVolumen()
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Radio: {radio}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Perímetro de la base: {CalcularPerimetro():F2}");
            Console.WriteLine($"Superficie: {CalcularSuperficie():F2}");
            Console.WriteLine($"Volumen: {CalcularVolumen():F2}");
        }
    }
}
