int[] TotalArray(int col)
{
    int[] array = new int[col];
    int i = 0;
    while (i < array.Length)
    {
        Random rand = new Random();
        array[i] = rand.Next(1, 100);
        Console.WriteLine(Convert.ToString(array[i]) + ", ");
        i++;
    }
    return array;
}


Console.WriteLine("Введите длинну массива: ");
int total = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int[] mass = TotalArray(total);
int minNumb = mass[0];
int maxNumb = mass[0];
for(int i = 0; i < mass.Length; i++){
    if(minNumb > mass[i]) minNumb =  mass[i];
    if(maxNumb < mass[i]) maxNumb =  mass[i];
}

Console.Write("Ответ: " + Convert.ToString(maxNumb - minNumb));
