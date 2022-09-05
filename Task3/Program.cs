// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

    
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
Array2(array);

void Array2(double[] array)
   
{
    int size = array.Length;
    for(int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(1,100);
        }
        Console.WriteLine($"Массив из {array.Length} чисел:");
        Console.WriteLine("[{0}]", string.Join(", ", array));

    double max = array[0];  
    double min = 100;
       
    for(int i = 0; i < size; i++)
        {
            if(min > array[i]) 
                 min = array[i];

            else if(max < array[i]) 
                 max = array[i];
            
        }
        Console.WriteLine($"Минимальный элемент массива: {min}"); 
        Console.WriteLine($"Максимальный элемент массива: {max}"); 
        
    double result = max - min;  
    Console.WriteLine($"Разница между между максимальным ({max}) и минимальным({min}) элементами: {result}");         
}


