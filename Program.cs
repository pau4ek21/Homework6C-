//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[m];

void Inputnum1bers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massive[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massive)
{
  int count = 0;
  for (int i = 0; i < massive.Length; i++)
  {
    if(massive[i] > 0 ) count += 1; 
  }
  return count;
}

Inputnum1bers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massive)} ");
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] num1 = new double[2, 2];
double[] num2 = new double[2];

void Inputnum1icients(){
  for (int i = 0; i < num1.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < num1.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      num1[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] num1)
{
  num2[0] = (num1[1,1] - num1[0,1]) / (num1[0,0] - num1[1,0]);
  num2[1] = num2[0] * num1[0,0] + num1[0,1];
  return num2;
}

void OutputResponse(double[,] num1)
{
  if (num1[0,0] == num1[1,0] && num1[0,1] == num1[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (num1[0,0] == num1[1,0] && num1[0,1] != num1[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(num1);
    Console.Write($"\nТочка пересечения прямых: ({num2[0]}, {num2[1]})");
  }
}

Inputnum1icients();
OutputResponse(num1);
