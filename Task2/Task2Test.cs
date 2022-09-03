using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(-2, 12, 3), Is.EqualTo(-2));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(-1, -1, -1), Is.EqualTo(-1));
    }

    [Test]
    public void Min3Test4() 
    {
        That(Min3(92, 45, 2), Is.EqualTo(2));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(1, 5, 7), Is.EqualTo(7));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(15, 2, 8), Is.EqualTo(15));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(-19, -2, -121), Is.EqualTo(-2));
    }

    public void Max3Test4() 
    {
        That(Max3(0, 0, 0), Is.EqualTo(0));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }

    [Test]
    public void MoreRadDegTests()
    {
        That(Deg2Rad(0), Is.EqualTo(0).Within(1e-5));
        That(Deg2Rad(90.0), Is.EqualTo(Math.PI / 2).Within(1e-5));
        That(Deg2Rad(-30.0), Is.EqualTo(-Math.PI / 6).Within(1e-5));
        That(Deg2Rad(-225.0), Is.EqualTo(-Math.PI * 1.25).Within(1e-5));
        That(Deg2Rad(-180.0), Is.EqualTo(-Math.PI).Within(1e-5));
        That(Rad2Deg(0), Is.EqualTo(0).Within(1e-5));
        That(Rad2Deg(Math.PI / 2), Is.EqualTo(90.0).Within(1e-5));
        That(Rad2Deg(-Math.PI / 6), Is.EqualTo(-30.0).Within(1e-5));
        That(Rad2Deg(-Math.PI * 1.25), Is.EqualTo(-225.0).Within(1e-5));
        That(Rad2Deg(-Math.PI), Is.EqualTo(-180.0).Within(1e-5));
    }
}