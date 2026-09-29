namespace ValueTypesAndReferenceTypes
{
    // Struct is a value type, it is stored in the stack memory.
    public struct coordinates  {
        public int x;
        public int y;
        public int z;
    }
    class Program
    {
        static void Main(string[] args)
        {

            coordinates xyz = new coordinates();
            xyz.x = 10;
            xyz.y = 20;
            xyz.z = 30;

            coordinates x1y1z1 = xyz; // Copy by value
            x1y1z1.x = 100;

            // Value types
            // i value stays the same even after y is changed to 30 cause they have different memory addresses.
            int i = 10; // primitive data types
            int y = i;
            y = 30;

            Console.WriteLine(i);
            Console.WriteLine(y);


            // Reference types
            MyClass obj = new MyClass(); // Create instance
            obj.hello = "Hi";
            Console.WriteLine(obj.hello);

            MyClass obj2 = new MyClass();
            obj2 = obj; // by reference
            obj2.hello = "Hello";
            Console.WriteLine(obj.hello);
            Console.WriteLine(obj2.hello);
        }
    }

    class MyClass
    {
        public string hello = "";
    }
}
