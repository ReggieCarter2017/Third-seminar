double Distance()
{
    int[] size = new int[3];
    int[] size2 = new int[3];
    double result = 0;
        for (int i = 0; i < size.Length; i++) size[i] = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < size.Length; i++) size2[i] = Convert.ToInt32(Console.ReadLine());
    result = Math.Sqrt((Math.Pow(size[0] - size2[0], 2)) + (Math.Pow(size[1] - size2[1], 2)) + (Math.Pow(size[2] - size2[2], 2)));
    return result;
}

Console.Write(Distance());