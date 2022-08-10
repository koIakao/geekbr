Console.WriteLine("Write your number: ");
int usernum = Convert.ToInt32(Console.ReadLine());

bool Del(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
bool result = Del(usernum);
Console.WriteLine(result ? "Yes" : "No");