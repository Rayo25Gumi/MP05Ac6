using Xunit;

namespace TestDaw;

public class Testing
{
    [Fact]
    public void TestSuma()
    {
        int num1 = 5;
        int num2 = 3;

        int result = Program.Suma(num1, num2);

        Assert.Equal(8, result);
        //Este test comprueba que la función suma devuelve el restultado correcto
    }

    [Fact]
    public void TestResta()
    {
        int num1 = 5;
        int num2 = 3;

        int result = Program.Resta(num1, num2);

        Assert.Equal(2, result);

        //Este test comprueba que la función resta devuelve el restultado correcto
    }

    [Fact]
    public void TestEsPar()
    {
        int num = 4;

        bool result = Program.EsPar(num);

        Assert.True(result);

        // Verifica que cuando se introduce el 4 devuelva par
    }

    [Fact]
    public void TestTipoNumeroPositivo()
    {
        int num = 5;

        string result = Program.TipoNumero(num);

        Assert.Equal("Número positivo", result);

        // Verifica que cuando se introduce el 5 devuelva que es postivio
    }

    [Fact]
    public void TestContarLetras()
    {
        string palabra = "Hola";

        int result = Program.ContarLetras(palabra);

        Assert.Equal(4, result);

        // Verifica que cuando se introduce Hola devuelva que tiene 4 letras
    }
}
