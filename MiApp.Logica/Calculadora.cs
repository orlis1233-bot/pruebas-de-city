namespace MiApp.Logica;

public class Calculadora
{
    public int Sumar(int a, int b) => a + b;

    public decimal Dividir(decimal a, decimal b)
    {
        if (b == 0) throw new DivideByZeroException();
        return a / b;
    }
}
