namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.8M;
        var cents = valor.ToCents();
    }
}