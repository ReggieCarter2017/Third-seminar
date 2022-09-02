string Cube(int a)
{
    double result = 0;
    string numbers = "";
    for (int i = 1; i <= a; i++)
    {
    result = Math.Pow(i, 3);
    numbers = numbers + result + " ";
    }
    return numbers;
}
int num = 0;
int.TryParse(Console.ReadLine(), out num);

Console.Write(Cube(num));