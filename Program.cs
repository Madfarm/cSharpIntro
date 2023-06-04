namespace FirstGo
{
    class Program 
    {
        static void Main(string[] args)
        {
            string myStr = "Wow this is a dope language";

            string cloned = (string)myStr.Clone();


            if(cloned.CompareTo(myStr) == 0)
            {
                Console.WriteLine("They're the same!");
            } 
            else
            {
                System.Console.WriteLine("They're not the same :(");
            }
        }
    }
}