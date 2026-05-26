// Task 1
int[] febonachi = new int[8] {0, 1, 1, 2, 3, 5, 8, 13};

// Task 2
string[] monthes = new string[12] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

// Task 3
// 2 3 4
// 4 9 16
// 8 27 64
int[,] numbers = new int[3, 3] { {2, 3, 4}, {4, 9, 16}, {8, 27, 64} };

// Task 4

// Jagged array (ломанный массив)
double[][] jaggedArray = new double[3][];

// Первый массив - числа от 1 до 5
jaggedArray[0] = new double[] { 1, 2, 3, 4, 5 };

// Второй массив - константы e и pi
jaggedArray[1] = new double[] { Math.E, Math.PI };

// Третий массив - логарифм по основанию 10 чисел 1, 10, 100 и 1000
jaggedArray[2] = new double[]
{
	Math.Log10(1),
	Math.Log10(10),
	Math.Log10(100),
	Math.Log10(1000)
};

// Task 5
int[] array = { 1, 2, 3, 4, 5 }; 
int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

Array.Copy(array, 0, array2, 0, 3);

Console.WriteLine("Array2 after copy:");
foreach (int i in array2)
    Console.WriteLine(i);

//Task 6
Array.Resize(ref array, array.Length * 2);

Console.WriteLine("Array1 after resizing:");
foreach (int i in array)
    Console.WriteLine(i);