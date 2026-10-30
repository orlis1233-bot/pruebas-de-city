using MiApp.Logica;
using Xunit;

public class CalculadoraTests
{
    [Fact]
    public void Sumar_DosNumeros_RegresaSuma()
    {
        var calc = new Calculadora();
        Assert.Equal(5, calc.Sumar(2, 3));
    }

    [Fact]
    public void Restar_DosNumeros_RegresaResta()
    {
        var calc = new Calculadora();
        Assert.Equal(4, calc.Restar(10, 6));
    }

    [Fact]
    public void Dividir_EntreCero_LanzaExcepcion()
    {
        var calc = new Calculadora();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
    }
}
