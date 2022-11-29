// Используя определение степени числа, напишите цикл, 
//который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
void StepenAotB()
{
    Console.WriteLine("Введите два целых числа, в ином случае возникнет ошибка");
    Console.WriteLine("Введите число А");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число В");    
    int B = Convert.ToInt32(Console.ReadLine());
    if (A >=1 && B >= 1)
    {
        double stepen = Math.Pow(A, B);
        Console.WriteLine("А в степени В = " + stepen);
    }
    else Console.WriteLine("Ошибка. Введите натуральное число (>0)");
}
StepenAotB();