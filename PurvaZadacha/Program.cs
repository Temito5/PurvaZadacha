namespace PurvaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi broi elementi: ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers= new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Vavedi chislo: ");
                int item=int.Parse(Console.ReadLine());
                numbers.Add(item);
            }

            //int newIndex = n / 2;
            //numbers.Insert(newIndex, 6);

            //int minElement=numbers.Min();
            //numbers.Add(minElement);

            while (numbers.Contains(0))
            {
                numbers.Remove(0);
            }
            
           
           

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"numbers[{i}]={numbers[i]}");
            }
            Console.WriteLine("Broqt na elementite v spicuka e: " + numbers.Count);
        }
    }
}