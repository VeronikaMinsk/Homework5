// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[size];
// Array2(array);

// void Array2(double[] array)

// {
//     int size = array.Length;
//     double min = array[0];            // вычисляет , если задать =100
//     double max = array[0];            // если максимум array[0] - то не показывает первое число 
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1,100);  
//             if(min > array[i]) 
//             min = array[i];

//             else if(max < array[i]) 
//             max = array[i];
            
//          Console.WriteLine($"{min}"); //
//          Console.WriteLine($"{max}"); // Сюда переместила для удобства наблюдений
//     }
         
// }
 
//     Console.WriteLine($"Массив из {array.Length} чисел:");
//     Console.WriteLine("[{0}]", string.Join(", ", array));
    
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
Array2(array);

void Array2(double[] array)

{
    int size = array.Length;
    double min = 100;
    double max = array[0];    // не работает на array[0]
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,100); 
       
        {
            if(min > array[i]) 
            min = array[i];

            else if(max < array[i]) 
            max = array[i];
        }
    }
    Console.WriteLine($"Массив из {array.Length} чисел:");
    Console.WriteLine("[{0}]", string.Join(", ", array));
    Console.WriteLine($"Минимальный элемент массива {min}"); 
    Console.WriteLine($"Максимальный элемент массива {max}");         
}
 
    
