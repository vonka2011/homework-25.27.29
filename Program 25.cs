// Напишите цикл, кот.принимает на вход 2 числа (А и В) и возводит число А в натуральную степень В
int Number(int a, int b)
{
    int res =1;
    for (int i = 0; i < b; i++)
    {
        res = res * a;

    }
return res;
}
Console.Write( "Введите число A: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите число B: ");
int b =Convert.ToInt32(Console.ReadLine());
int res=Number(a, b);
Console.Write($"Число {a} в степени {b} = {res}");








