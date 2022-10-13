using System.Reflection.PortableExecutable;

namespace Summ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //string inputpath = "D:\\VS Snippets\\CodeforcesRound827\\input.txt";
            //string outputpath = "D:\\VS Snippets\\CodeforcesRound827\\output.txt";

            //FileStream infs = new FileStream(inputpath, FileMode.OpenOrCreate);
            //infs.Close();
            //FileStream outfs = new FileStream(outputpath, FileMode.OpenOrCreate);
            //outfs.Close();

            //int countOf;
            //using (var reader = new StreamReader(inputpath))
            //{
            //    countOf = Convert.ToInt32(reader.ReadLine());
            //}
            int countOf;
            countOf = Convert.ToInt32(Console.ReadLine());

            #endregion
            int[,] numbers;
            numbers = new int[countOf, 3];
            string line;
            string[] linee = new string[3];
            bool[] answer = new bool[countOf];
            //using (var reader = new StreamReader(inputpath))
            //{
            //    reader.ReadLine();
            for (int i = 0; i < countOf; i++)
            {
                //line = reader.ReadLine();
                line = Console.ReadLine();
                linee = line.Split(' ');
                numbers[i, 0] = Convert.ToInt32(linee[0]);
                numbers[i, 1] = Convert.ToInt32(linee[1]);
                numbers[i, 2] = Convert.ToInt32(linee[2]);
                if ((numbers[i, 0] + numbers[i, 1] == numbers[i, 2]) || (numbers[i, 0] + numbers[i, 2] == numbers[i, 1]) || (numbers[i, 1] + numbers[i, 2] == numbers[i, 0]))
                {
                    answer[i] = true;
                }
                else
                {
                    answer[i] = false;
                }
            }

            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == true)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");

                }
            }
        }
    }
}