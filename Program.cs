namespace feladat
{
    internal class Program
    {
        static Random r = new Random();
        static void F05()
        {
            int[] tomb = new int[5];
            int szam;
            int i = 0;
            for(i = 0; i < tomb.Length; i++)
            {
                Console.Write("Adj meg egész számokat: ");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in tomb)
            {
                Console.WriteLine(item);
            }
            for (i = tomb.Length - 1; i >= 0; i-- )
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine($"Második elemek: {tomb[1]}, {tomb[3]}");

            Console.WriteLine($"Kérek egy számot 1 és 5 között: ");
            szam=Convert.ToInt32(Console.ReadLine());
            int minusz = szam - 1;
            Console.WriteLine($"A keresett szám: {tomb[minusz]}");
        }

        static void F13()
        {
            
            int[] tomb = new int[20]; 
            for (int i = 0; i < tomb.Length; i++)
            {

                tomb[i] = r.Next(-100, 101);
            }
            foreach (int item in tomb)
            {
                Console.Write(item + ", ");
            }
            for (int i = 0; i < tomb.Length; i++)

            {

                Console.WriteLine($"{(i + 1),3} {tomb[i],5} {(tomb[i] < 0 ? "-" : "+"),5}");

            }
            
            
        }


        static void Main(string[] args)
        {
            //F05();
            F13();
        }
    }
}
