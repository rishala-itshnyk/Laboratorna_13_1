namespace Laboratorna_13_1.Tests;

[TestFixture]
public class TaylorSeriesTests
{
    [Test]
    public void CalculateTaylorSeries_ReturnsExpectedResult()
    {
        double x = 1.0;
        double epsilon = 1e-10;

        double result = TaylorCalculate.TaylorSeries.CalculateTaylorSeries(x, epsilon, out _);

        Assert.That(result, Is.EqualTo(0.72477845900707616d).Within(0.060619704392923857d));
    }
}

[TestFixture]
public class ArctgFunctionTests
{
    [Test]
    public void CalculateArctg_ReturnsExpectedResult()
    {
        double x = 1.0;

        double result = ArctgCalculate.ArctgFunction.CalculateArctg(x);

        Assert.That(result, Is.EqualTo(0.72477845893738568d).Within(0.060619704462614332d));
    }
}