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
                Console.WriteLine($"enter the student{i + 1} marks :");
                for (int j = 0; j < marks.GetLength(1);)
                {
                    Console.WriteLine($"enter mark of subject{j + 1}");
                    flag = int.TryParse(Console.ReadLine(), out marks[i, j]);
                    if (flag)
                        j++;
                }
            }
            Console.Clear();
            Console.Beep(2554, 1000);
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine($" the student{i + 1} marks :");
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    Console.Write($"{marks[i, j]}  ");

                }
                Console.WriteLine();
            }
            #endregion
            //two dimensional array judged 
            #region v03

            int[][] mark = new int[3][];
            mark[0] = new int[3] {5,8,9};
            mark[1] = new int[2] { 8, 7 };
            mark[2] = new int[1] { 1 };
            int totalElements = 0;
            for (int i = 0; i < mark.Length; i++)
            {
                for(int j = 0; j < mark[i].Length; j++)
                {
                    Console.WriteLine(mark[i][j]);
                }
            }

            // Calculate the total number of elements
            
            #endregion
        }
    }
}
