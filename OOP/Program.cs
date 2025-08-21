public class A
{
    public void method1()
    {
        Console.WriteLine("Hello from method1");
    }
}

public class B : A
{
    public void method2()
    {
        //Console.WriteLine("Hello from method2");
    }

    public int addTwoNumbers(int a, int b)
    {
        return a + b;
    }
}

// public class Example
// {
//     public static void Main(string[] args)
//     {
//         B b = new B();
//         b.method1();
//         Console.WriteLine(b.addTwoNumbers(3, 4));
//     }
// }


// Inheritance 
public class Class_A
{
    private int _value = 21;

    public class Class_B : Class_A
    {
        public int getValue()
        {
            return _value;
        }
    }
}

public class Class_C : Class_A
{
    // public int getValue()
    // {
    //     //return _value;
    // }
}


// Override Values
public class OverrrideValues
{
    public virtual void method1()
    {
        Console.WriteLine("Hello from method1");
    }
}

public class FirstOverride : OverrrideValues
{
    public override void method1()
    {
        Console.WriteLine("Hello from FirstOverride method1");
    }
}

public class AccessValue
{
    public static void Main(string[] args)
    {
        var b = new Class_A.Class_B();
        Console.WriteLine(b.getValue());

    }


    // Override Instantiation
    FirstOverride firstOverride = new FirstOverride();
    //firstOverride.method1();
}