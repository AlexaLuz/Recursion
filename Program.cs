// Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.

//Console.Write("Введите m: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите n: ");
//int n = Convert.ToInt32(Console.ReadLine());
//void Even(int m, int n)
//{
//if (m > n)
//return;
//if (m % 2 == 0)
//{
//Console.Write($"{m}, ");
//}
//Even(m+1,n);

//}
//Even(m,n);



//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

//Console.Write("Введите m: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите n: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int akkerman(int m, int n)
//{
//if (m == 0) return n + 1;
//else if (n == 0) return akkerman(m - 1, 1);
//else return akkerman(m - 1, akkerman(m, n - 1));
//}

//Console.Write($"{akkerman(m, n)} ");



//Задайте произвольный массив. Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.

 int Rev(int array[], int len) 
{
  if (len < 0) 
  {
return 0;
  } 
  else
  {
    array[len];
    cout = array[len];
    Rev(array, len-1);
  }
}
    
int main() 
{
  int arr[6] = { new arr [56, 8, 15, 17, 26, 27]};

Rev(arr, 5);

  return 0;
}