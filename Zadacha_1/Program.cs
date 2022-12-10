int n = insertNumber("Введите колличество строк в массиве:");

Console.WriteLine();

if (n<=0) Console.WriteLine("Данные введены неправильно.");
else
{
   string [] beginArray = insertArray(n);
   Console.WriteLine();
   Console.WriteLine("Введенный массив:");
   printArray(beginArray);
   Console.WriteLine();

   string [] desiredArray = createArray(beginArray);
   Console.WriteLine("Полученный массив:");
   printArray(desiredArray);
   Console.WriteLine();

}
 


//Метод ввода данных int
int insertNumber (string message)
{

    Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

//Метод ввода данных string
string []  insertArray (int n )
{
    string [] array = new string [n];
for (int i = 0; i<n ; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива:");
    array[i] = Console.ReadLine();
}
return array;
}

//Метод создания нового массива
string [] createArray(string [] array)
{
    int count = 0;
    int lengthNewArray = 0;
   for (int i = 0; i<array.GetLength(0); i++) if (array[i].Length <= 3) count++;
   string [] newArray = new string [count];
   for (int i = 0; i<array.GetLength(0); i++)
   {
     if (array[i].Length <= 3)
     {
        newArray[lengthNewArray] = array[i];
        lengthNewArray++;
     } 
   }
   return newArray;
}


//Метод вывода массива
void printArray( string[] array)
{
    for (int row = 0; row < array.GetLength(0) ; row++) Console.Write($"{array[row]}  ");
    Console.WriteLine();
}

