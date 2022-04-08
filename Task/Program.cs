// Написать программу, которая из имеющегося массива строк формирует 
// массив строк, длина которых меньше либо равна 3 символа

int index = 0;
string [] arr = new string [] {"Hello", "World", "123", ".", "Holidays", "Day"};
int count = 0;


for (int i = 0; i < arr.Length; i++)
{
    if(arr[i].Length<=3)
        count++;
}

Console.WriteLine(count);

string [] newArr = new string [count];

for (int i = 0; i < arr.Length; i++)
{
    if(arr[i].Length<=3)
    {
        newArr[index] = arr[i];
        index++;
    }
}

for (int i = 0; i < newArr.Length; i++)
{
    Console.Write($"{newArr[i]}, ");
}