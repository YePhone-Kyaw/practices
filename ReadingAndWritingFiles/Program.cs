namespace ReadingAndWritingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("d:/data.txt", "Hello World!");
            string output = File.ReadAllText("d:/data.txt");

            Console.WriteLine(output);
        }
    }
}
