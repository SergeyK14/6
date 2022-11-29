// Сортировка значений массива по модулю
int size = 8;
int[] numbers = new int[size];

void FillArray(int[] nums)
{
Random rand = new Random();
int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
    nums[i] = rand.Next (-99, 100);
    }
}
void PrintArray(int[] nums)
{   
int length = nums.Length;
Console.WriteLine ("Вывод массива: ");
    for (int i = 0; i < length; i++)
    {
    Console.Write (nums[i] + " ");
    }
Console.WriteLine();
Console.WriteLine();
}

FillArray(numbers);
PrintArray(numbers);

int vremper = 0;
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size - 1; j++)
    {
        if (Math.Abs(numbers[j]) > Math.Abs(numbers[i]))
        {
           vremper = numbers[j];
           numbers[j] = numbers[i];
           numbers[i] = vremper;
        }
    }
}
PrintArray(numbers);