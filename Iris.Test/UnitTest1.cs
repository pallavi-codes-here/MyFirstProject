namespace Iris.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Class1 c = new Class1();
        Assert.Equal("Iris.Class1", c.ToString());
    }
}