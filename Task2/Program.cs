// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Array2(array);

void Array2(int[] array)

{
    int size = array.Length;
    int Summ = 0;
   
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,10);  
            if(i % 2 != 0) 
            Summ += array[i];
    }
    Console.WriteLine($"Массив из {array.Length} чисел:");
    Console.WriteLine("[{0}]", string.Join(", ", array));
    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {Summ}");
}
