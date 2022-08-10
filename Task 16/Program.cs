Console.WriteLine("Write your 1st number: ");
int usernum1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your 2nd number: ");
int usernum2 = Convert.ToInt32(Console.ReadLine());

bool Del(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}
bool result = Del(usernum1, usernum2);
Console.WriteLine(result ? "Yes" : "No");