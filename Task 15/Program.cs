Console.WriteLine("Укажите день недели [1-7]: ");
int usernum = Convert.ToInt32(Console.ReadLine());
if (usernum >= 8 || usernum <= 0)
{
    Console.WriteLine("Вы изобрели новый день недели?");
}
else
{
    bool Del(int num)
    {
        return num == 6 || num == 7;
    }
    bool result = Del(usernum);
    Console.WriteLine(result ? "День выходной!" : "Опять на работу :(");
}
