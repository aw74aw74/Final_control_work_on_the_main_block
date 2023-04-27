/*
Задача: Написать программу, которая из имеющегося массива строк
формирует новый массив из строк, длина которых меньше, либо
равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

using static System.Console;

string[] OperationArray(string[] inArray)
{
  string str = string.Empty;
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    if (inArray[i].Length <= 3)
    {
      if (str == string.Empty)
      {
        str = inArray[i];
      }
      else
      {
        str += ",,," + inArray[i];
      }
    }
  }
  string[] result = str.Split(",,,");
  return result;
}

void PrintArray(string[] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    Write($"{inArray[i]} ");
  }
}

string[] array = {"Hello", "2", "world", ":-)",
                  "1234", "1567", "-2", "computer science"};

PrintArray(array);
WriteLine();
PrintArray(OperationArray(array));