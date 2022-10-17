//Задача 1. напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

/*
int Stepen(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
        res *= a;
    return res;
}
Console.WriteLine("Введите число А:");
int a =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В :");
int b = Convert.ToInt32(Console.ReadLine());

int numresult = Stepen(a,b);

Console.WriteLine(numresult);
 System.Console.WriteLine();
*/
//Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

/*
 int GetSumm(int number)
 {

     int sum=0;
       
      for (int cur=1; number>1; cur++ )
      {
      int num= number %  10 ;
      int a = num;
      number = number /10;
      sum = sum + a;
     }

      return sum;
}

  Console.WriteLine("Введите положительное целое число");
  int number= Convert.ToInt32(Console.ReadLine());
int summ = GetSumm(number) ;

Console.Write("Сумма элементов вашего числа:\t" + summ);

*/

// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
//Вводим значения в ручную.

/*
int [] CreateArray(int size)
{
if(size < 0)
Console.Write("Некоррекиный ввод, но..");

size= size*-1;

 
    int[] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {

      Console.Write($"Введите  {i}-й элемент\t");
      newArray[i] = Convert.ToInt32(Console.ReadLine());

    }      
      return newArray;

}

void ShowArray(int []array)
{
    for(int i=0; i<array.Length; i ++)
    {
      Console.Write(array[i] + " ");
      
    }


}
Console.WriteLine("Введите число элементов массива : ");
int num = Convert.ToInt32(Console.ReadLine());
     
int [] myArray = CreateArray(num);

Console.WriteLine("Ваш массив :");
ShowArray(myArray);
*/
// Напишите программу, которая задаёт массив из m рандомных элементов от 1 до 100 и выводит их на экран.
/*
int[]CreateArray(int size)
{
    int[]newArray = new int [size];

    for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(1,101);
    
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

    Console.WriteLine();   

}

Console.WriteLine("input a number of elements : ");
int size =Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateArray(size);
ShowArray(myArray);
*/