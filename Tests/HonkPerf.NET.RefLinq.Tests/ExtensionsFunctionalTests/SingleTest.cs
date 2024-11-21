﻿// Copyright (c) Angouri 2021.
// This file from HonkPerf.NET project is MIT-licensed.
// Read more: https://github.com/asc-community/HonkPerf.NET

using System;

namespace Tests.ExtensionsFunctionalTests;

public class SingleTest
{
    [Fact]
    public void Test1()
    {
        var seq =
            new[] { 2 }
            .ToRefLinq()
            .Single();
        Assert.Equal(2, seq);
    }

    [Fact]
    public void Test2()
    {
        var seq =
            new int[] { }
            .ToRefLinq();
        Assert.Throws<InvalidOperationException>(() => seq.Single());
    }

    [Fact]
    public void Test3()
    {
        var seq =
            new int[] { 1, 2 }
            .ToRefLinq();
        Assert.Throws<InvalidOperationException>(() => seq.Single());
    }
}