// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Array2(array);

void Array2(int[] array)

{
    int size = array.Length;
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,999);   
        if(array[i] % 2 == 0)
            count++;  
    }
    {
            Console.Write("[ ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("]");   
    }       
    Console.WriteLine($" массив из {array.Length} чисел, {count} из них чётные");
}


