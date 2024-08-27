using Consigna3RecuperatorioCilindro;

class Consigna3RecuperatorioEntidades
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese el radio del cilindro:");
            double radio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del cilindro:");
            double altura = double.Parse(Console.ReadLine());

            Cilindro cilindro = new Cilindro(radio, altura);
            cilindro.MostrarInformacion();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
