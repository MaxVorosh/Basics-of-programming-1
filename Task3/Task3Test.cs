using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task3.Task3;

namespace Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1));
        That(F(-0.5), Is.EqualTo(0));
        That(F(-1.0), Is.EqualTo(0));
        That(F(-2.0), Is.EqualTo(0));
        That(F(0.5), Is.EqualTo(1));
        That(F(2), Is.EqualTo(1));
        That(F(4), Is.EqualTo(1));
        That(F(6.23), Is.EqualTo(1));
        That(F(8.5), Is.EqualTo(1));
        That(F(1), Is.EqualTo(-1));
        That(F(3), Is.EqualTo(-1));
        That(F(5.5), Is.EqualTo(-1));
        That(F(1.11), Is.EqualTo(-1));
        That(F(7.23), Is.EqualTo(-1));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(2022), Is.EqualTo(365));
        That(NumberOfDays(2023), Is.EqualTo(365));
        That(NumberOfDays(2024), Is.EqualTo(366));
        That(NumberOfDays(500), Is.EqualTo(365));
        That(NumberOfDays(700), Is.EqualTo(365));
        That(NumberOfDays(200), Is.EqualTo(365));
        That(NumberOfDays(1200), Is.EqualTo(366));
        That(NumberOfDays(2000), Is.EqualTo(366));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
        That(Rotate2('З', 2, -1), Is.EqualTo('Ю'));
        That(Rotate2('Ю', -1, -1), Is.EqualTo('С'));
        That(Rotate2('В', 1, 1), Is.EqualTo('З'));
        That(Rotate2('С', 2, 2), Is.EqualTo('С'));
        That(Rotate2('З', 1, 2), Is.EqualTo('С'));
        That(Rotate2('Ю', 2, 1), Is.EqualTo('З'));
        That(Rotate2('В', -1, 1), Is.EqualTo('В'));
        That(Rotate2('С', -1, 2), Is.EqualTo('З'));
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(21), Is.EqualTo("двадцать один год"));
        That(AgeDescription(33), Is.EqualTo("тридцать три года"));
        That(AgeDescription(65), Is.EqualTo("шестьдесят пять лет"));
        That(AgeDescription(50), Is.EqualTo("пятьдесят лет"));
        That(AgeDescription(24), Is.EqualTo("двадцать четыре года"));
        That(AgeDescription(36), Is.EqualTo("тридцать шесть лет"));
        That(AgeDescription(67), Is.EqualTo("шестьдесят семь лет"));
        That(AgeDescription(58), Is.EqualTo("пятьдесят восемь лет"));
        That(AgeDescription(69), Is.EqualTo("шестьдесят девять лет"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}