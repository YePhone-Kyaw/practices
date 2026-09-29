namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            object o = y; // stack to heap - Boxing [Value type to Reference Type]
            int z = (int)o; // heap to stack - Unboxing [Reference type to Value Type]
        }
    }
}
