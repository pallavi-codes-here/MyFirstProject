// Copyright (c) Pallavi Srivastava. All rights reserved.

namespace Iris.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var c = new Class1();
        Assert.Equal("Iris.Class1", c.ToString());
    }
}