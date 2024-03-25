namespace StupidTest;

public class Tests
{
    [Test]
    public void OnePlusOneShouldBeTwo()
    {
        int value1 = 1;
        int value2 = 1;
        Assert.That(value1 + value2, Is.EqualTo(2));
    }
}