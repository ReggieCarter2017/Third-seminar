string Reverse(int number)
{
    int[] array = number.ToString().Select(o=> Convert.ToInt32(o) - 48 ).ToArray();
    string arrayReversed = String.Empty;
    int length = array.Length;
    for (int i = length; i > 0; i--)
    {
        arrayReversed += array[i-1];

    }
    return arrayReversed;
}
int num = 0;
int.TryParse(Console.ReadLine(), out num);
string checkNumber = Reverse(num);
string num_string = "";
num_string = num.ToString();

string Check(string B)
{
    string a = "true";
    string b = "false";
    if (B == num_string)
    return a;
    else
    return b;
}

Console.Write($"{num} -> {Reverse(num)} -> {Check(checkNumber)}");