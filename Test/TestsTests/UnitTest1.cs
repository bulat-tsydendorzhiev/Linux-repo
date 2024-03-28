using TestClass;

namespace TestsTests;

public class Tests
{

    [Test]
    public void Test1()
    {
        int value = 1;
        TestClass.SimpleClass simple = new(1);
        Assert.That(simple.GetValuePlusOne(), Is.EqualTo(value + 1));
    }
}