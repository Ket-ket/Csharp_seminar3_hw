// Задача 4. Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен 
// быть равен количеству цифр.

// Например:
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

System.Console.WriteLine("Введите число от 1 до 100 000: ");
string n = Console.ReadLine()!;
int len = n.Length; 


int[] arr = new int[len];
for (int i = 0; i < len; i++)
{
    arr[i] = Convert.ToInt32(Convert.ToString(n[len - 1 - i])); // обраение к последнему элементу -1 не отнимаем, а указывает на послений элемент
}
PrintMas(arr);