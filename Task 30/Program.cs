int[] result = FillArray(8, 0, 2);
PrintArr(result);

int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

//void PrintArr(int[] array)
//{
  //  Console.Write("[");
    //for (int i = 0; i < array.Length; i++)
    //{
      //if (i < array.Length - 1) Console.Write(array[i] + ",");
        //if (i < array.Length) Console.Write(array[i]);
    //}
    //Console.Write(array[array.Length - 1]);
    //Console.Write("]");
//}
