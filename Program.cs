// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//-- Первый вариант решения --


// void Palindrome ()
// {
// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// while(number < 10000 || number > 99999)
// {
//   Console.Write("Введите пятизначное число: ");
//   number = Convert.ToInt32(Console.ReadLine());
// }
// int first = number / 1000;
// int second = number % 100;
// if((first / 10 == second % 10) && (first % 10 == second / 10)) 
//   Console.Write("Да");
// else
//   Console.Write("Нет");
// }
// Palindrome();


//-- Второй вариант решения --


// int[] number = {1,1,3,1,1};

// void Palindrome (int [] array)
// {
//   bool isPali = true;
//   for (int i = 0; i < array.Length/2; i++)
//   {
//     if(array[i]!=array[array.Length-1-i])
//     isPali = false;    
//   }    
//     if(isPali)
//       Console.Write("Да");
//     else  
//       Console.Write("Нет");    
//   }

// Palindrome(number);

//-- Третий вариант решения --

// bool Palindrome (string pali)
// {
//   for(int i = 0; i < pali.Length/2; i++)
//   {
//     if(pali[i] != pali[pali.Length-1-i])
//     return false;
//   }
//   return true;
// }

// Console.Write(Palindrome("aadaa"));


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// void calculationDistance ()
// {
// Console.WriteLine("Введите координаты точек: ");
// Console.Write("Введите X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double length = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2 - z1,2));
// Console.WriteLine("Расстояние между двумя точками в 3D пространстве: " + length);
// }

// calculationDistance();


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void cubeTable ()
// {
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for( int i = 1; i <= number; i++)
//   {
//     Console.WriteLine(Math.Pow(i,3));  //(i*i*i)
//   }
// }
// cubeTable();

//Дополнительная задача

Console.Write("Введите число дней: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N < 1 || N > 100)
{
  Console.Write("Введите число дней: ");
  N = Convert.ToInt32(Console.ReadLine());  
}
int result = 0;
int count = 0;
for (int i = 1; i <= N; i++)
{
  Console.Write("Введите температуру от -50 до 50: ");
  int temp = Convert.ToInt32(Console.ReadLine());
  if (temp < -50 || temp > 50)
  {
    Console.WriteLine("Введенная температура выходит за пределы -50 / 50");
    Console.Write("Введите температуру: ");
    temp = Convert.ToInt32(Console.ReadLine());
  }
  if ( temp <= 0)
    count = 0;
  else
    count++;
  if(result < count) 
    result = count;  
}
Console.Write("Колличество дней оттепели: " + result);
