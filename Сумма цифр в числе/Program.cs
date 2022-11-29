// Сумма цифр в числе
void SummaTsifr()
{
Console.WriteLine("Введите число ");
int chislo = Convert.ToInt32(Console.ReadLine());
chislo = Math.Abs(chislo);
int sum = 0;
while (chislo > 0)
{
    sum = sum + chislo%10;
    chislo = chislo/10;
}
Console.WriteLine("Сумма цифр в числе равна " + sum);
}
SummaTsifr();