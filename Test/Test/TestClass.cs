namespace TestClass;

public class SimpleClass(int value)
{
    public int Value{ get; set;} = value;
    
    public int GetValuePlusOne()
    {
        return Value + 1;
    }
}