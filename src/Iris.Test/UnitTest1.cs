// Copyright (c) Pallavi Srivastava. All rights reserved.

using FluentAssertions;

namespace Iris.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var c = new Class1();

        c.ToString().Should().Be("Iris.Class1");
    }
}