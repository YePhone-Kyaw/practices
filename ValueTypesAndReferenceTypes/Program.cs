namespace ValueTypesAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
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