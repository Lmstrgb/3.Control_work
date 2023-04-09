// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Функция ввода и приветствия
string InputStr(string msg)
{
  Console.Write(msg);
  return Console.ReadLine()!;
}

//Функция подсчёта количества элементов во введенном массиве,длина которых <=3 символов.
int QuantSymbLess3(string[] array)
{
  int count = 0;
  int i = 0;
  while (i < array.Length)
  {
    count = array[i].Length <= 3 ? count + 1 : count + 0;
    i++;
  }
  return count;
}

//Функция наполнения выходного массива нужными элементами
void FillOutputMass(string[] arrayInput, string[] arrayOutput)
{
  int k = 0;
  for (int j = 0; j < arrayInput.Length; j++)
  {
    if (arrayInput[j].Length <= 3)
    {
      arrayOutput[k] = arrayInput[j];
      k++;
    }

  }
}

string StrInput = InputStr("Введите строки через запятую: ");
string[] StrMassInput = StrInput.Split(',');
int countsymbless3 = QuantSymbLess3(StrMassInput);
string[] StrMassOutput = new string[countsymbless3];
FillOutputMass(StrMassInput, StrMassOutput);

Console.WriteLine($"Введенный массив: [{String.Join(",", StrMassInput)}] --> полученный массив: [{String.Join(",", StrMassOutput)}]");