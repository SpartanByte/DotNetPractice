//generic classes can operate on different data types with ease
using System;

//<T> indicates name of parameter, becomes a specific data type
class GenericSwapper<T>
{
    //instance variables but type has not been specified yet (set at Runtime)
    public T x; public T y;
    public GenericSwapper(T val1, T val2)
    {
        // set instance variables
        this.x = val1; this.y = val2;
    }

    public void Switch()
    {
        //switch values of x and y
        T temp = this.x;
        this.x = this.y;
        this.y = temp;
    }

}
class SwapUser
{
    static void Main()
    {
        //setting type at runtime
        GenericSwapper<string> genSwap = new GenericSwapper<string>("hello", "world");
        genSwap.Switch();
        Console.WriteLine("The value of x is " + genSwap.x);
        Console.WriteLine("The value of y is " + genSwap.y);
    }
}