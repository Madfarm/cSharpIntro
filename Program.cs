namespace FirstGo
{
    class Program 
    {
        static void Main(string[] args)
        {
            string myStr = "Wow this is a dope language";
            // string cloned = (string)myStr.Clone();

            string[] split = myStr.Split(' ');


            System.Console.WriteLine(split);
        }
    }
}