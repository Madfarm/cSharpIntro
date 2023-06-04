namespace FirstGo
{
    class Program 
    {
        static void Main(string[] args)
        {
            char[] delimiterChars = {' ', ',', '.', ':', '\t'};
            string myStr = "one\ttwo three:four,five six seven";
            // string cloned = (string)myStr.Clone();
            System.Console.WriteLine($"Original string: {myStr} \n");

            string[] split = myStr.Split(delimiterChars);

            foreach (string item in split)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}