namespace assignment03D04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array two dimensional 
            #region v02
            int[,] marks = new int[2, 3];
            bool flag;
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine($"enter the student{i+1} marks :");
                for (int j = 0; j < marks.GetLength(1); )
                {
                    Console.WriteLine($"enter mark of subject{j+1}");
                    flag=int.TryParse(Console.ReadLine(), out marks[i,j]);
                    if (flag)
                        j++;
                }
            }
            Console.Clear();
            Console.Beep(2554, 1000);
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine($" the student{i + 1} marks :");
                for (int j = 0; j < marks.GetLength(1);j++)
                {
                    Console.Write($"{marks[i,j]}  ");
                    
                }
                Console.WriteLine();
            }
            #endregion

        }
    }
}
