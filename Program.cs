// Найдите сумму произведений пар чисел в одномерном целочисленном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Если кол-во элементов нечетное, то элемент посередине не учитывать.

int[] array1 = { 1, 3, 8, 3, 2 };
int[] array2 = { 8, 3, 4, 2 };
 
int sum1 = 0;
int sum2 = 0;

for (int i = 0; i <array1.Length / 2; i++)
    {
        sum1 += array1[i] * array1[array1.Length - 1 - i];
    }

for (int u = 0; u <array2.Length / 2; u++)
    {
        sum2 += array2[u] * array2[array2.Length - 1 - u];
    }

Console.WriteLine(sum1);
Console.WriteLine(sum2);        