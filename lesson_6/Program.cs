// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Console.Write("Сколько будет чисел: ");
// int num = int.Parse(Console.ReadLine());

// Console.Write(SumBigNul(num));


// int SumBigNul(int num){
//     int sum = 0;
//     int[] arr = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         Console.Write($"Ведите число {i+1}: ");
//         arr[i] = int.Parse(Console.ReadLine());
//         if(arr[i]>0){
//             sum++;
//         }
//     }
    

//     return sum;
// }




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//y = 5 * x + 2;
//y = 9 * x + 4;

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b первой линии: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k первой линии: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b второй линии: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k второй линии: ");
double k2 = Convert.ToDouble(Console.ReadLine());


Findcoordinat(b1,k1,b2,k2);

bool Findcoordinat(double b1,double k1,double b2,double k2){
    if(b1 == b2){
        if(k1 == k2){
            Console.Write("Прямые одинаковые");
        }else{
            Console.Write("Прямые паролельны");
        }
    }else{
        double[] arr = new double[2];
        arr[0]= (b2 - b1) / (k1 - k2);
        arr[1]= k1 * arr[0] + b1;
        Console.WriteLine($"Точка пересечения ({arr[0]}, {arr[1]})");
    }
    return true;
}