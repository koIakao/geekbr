int numb = new Random().Next(10, 100);
Console.WriteLine($"New random number from [10 - 99] => {numb}");

int firstSymb = numb / 10;
int secondSymb = numb % 10;

if (firstSymb == secondSymb) Console.WriteLine($"Numbers {firstSymb} & {secondSymb} are equial!");
else
{
    int max = firstSymb > secondSymb ? firstSymb : secondSymb;
    Console.WriteLine($"Greatest number of {numb} is {max}");
}

//
// int MaxDigit(int num)
//{
   //  int firstSymb = num / 10;
   // int secondSymb = num % 10;
   // return firstSymb > secondSymb ? firstSymb : secondSymb;
//}

//int MaxDigit = MaxDigit (numb);
//Console.WriteLine($"Greatest number of {numb} is {MaxDigit}");
// }