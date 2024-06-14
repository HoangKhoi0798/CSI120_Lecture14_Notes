namespace CSI120_Lecture14_Notes
{
    internal class Program
    {

        public static Movie[] movies = new Movie[3];

        // 2D Array - Matrix
        // dataype [,] name = new datatype [sizeX, sizeY]
        // In trials X represents different trials, Y represents our fields

        static int[,] intMatrix = new int[3, 3];
        static int[,] randomMatrix;

        static void Main(string[] args)
        {

            char[,] board = {
                {' ',' ',' '}, // Row
                {' ',' ',' '},
                {' ',' ',' '},
            };
           
        }// Main

        public static bool WinCondition(char[,] board)
        {
            // Write code to check if the board is a winning board
            // Check to see if either player won on the diagonal
            // (Opt) won on vertical or horizontal
            return false;
        }

        // Create a program, method, then when you pass in 2D array of char
        // char[3,3]

        // Check if the 2D array is a winning game of tic tac toe

        #region Matrix
        public static void MatrixExample2()
        {
            randomMatrix = PopulateIntMatrix(5, 10);
            DisplayMatrix(randomMatrix);

            Console.WriteLine();
            Console.Write("Diagonal: ");
            for (int x = 0; x < randomMatrix.GetLength(0); x++)
            {
                Console.Write(randomMatrix[x, x] + " ");
            }

        }

        public static int[,] PopulateIntMatrix(int xSize, int ySize)
        {
            int[,] temp = new int[xSize, ySize];
            Random RNG = new Random();

            for (int x = 0; x < temp.GetLength(0); x++)
            {
                for (int y = 0; y < temp.GetLength(1); y++)
                {
                    temp[x, y] = RNG.Next(1, 100);
                }
            }
            return temp;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            int xAxisLength = matrix.GetLength(0);
            int yAxisLength = matrix.GetLength(1);

            


            for (int x = 0; x < xAxisLength; x++)
            {
                for (int y = 0; y < yAxisLength; y++)
                {
                    Console.Write(matrix[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void MatrixExample()
        {
            // Array.GetLength(dimension)


            int xAxisLength = intMatrix.GetLength(0);
            int yAxisLength = intMatrix.GetLength(1);

            intMatrix[0, 0] = 876;
            intMatrix[1, 0] = 123;


            for (int x = 0; x < xAxisLength; x++)
            {
                for (int y = 0; y < yAxisLength; y++)
                {
                    Console.WriteLine(intMatrix[x, y]);
                }
            }


        }
        #endregion
        public static void NestedLoopsExample()
        { 
            // Nested Loops and Matricies

            // Nested Loops
            for (int i = 0; i < 7; i++)
            {
                Console.Write(i + ": ");
                // Place another loop inside of the first loop
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        #region MoviePractice
        public static void PreloadMovie()
        {

            movies[0] = new Movie("KGI", 2022);
            movies[1] = new Movie("KGI", 2023);
            movies[2] = new Movie("KGI", 2024);

        }

       public static void MovieInformationInput()
        {
            
        }

        public static void DisplayMovie()
        {
            for (int i = 0; i < movies.Length; i++)
            {
                Movie currentMovie = movies[i];

                Console.WriteLine(currentMovie.DisplayMovie());
            }
        }

    }//Class

    public class Movie
    {
        
        public string Title;
        public int Year;

        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }

        public string DisplayMovie()
        {
            return $"{Title} , {Year}";
        }
    }
    #endregion


    #region Bubble
    //class BubbleSortExample
    //    {
    //        static void Main(string[] args)
    //        {
    //            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

    //            Console.WriteLine("Unsorted array:");
    //            PrintArray(array);

    //            BubbleSort(array);

    //            Console.WriteLine("\nSorted array:");
    //            PrintArray(array);
    //        }

    //        static void BubbleSort(int[] array)
    //        {
    //            int n = array.Length;
    //            for (int i = 0; i < n - 1; i++)
    //            {
    //                for (int j = 0; j < n - i - 1; j++)
    //                {
    //                    if (array[j] > array[j + 1])
    //                    {
    //                        // Swap array[j] and array[j+1]
    //                        int temp = array[j];
    //                        array[j] = array[j + 1];
    //                        array[j + 1] = temp;
    //                    }
    //                }
    //            }
    //        }

    //        static void PrintArray(int[] array)
    //        {
    //            foreach (int element in array)
    //            {
    //                Console.Write(element + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    #endregion
}//Name
