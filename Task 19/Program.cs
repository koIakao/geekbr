//Console.WriteLine("Введите пятизначное число: ");
//string number = Console.ReadLine();

//void CheckingNumber(string number)
//{
  //if (number[0]==number[4] || number[1]==number[3]){
    //Console.WriteLine($"Заданное число: {number} - палиндром!");
  //}
  //else Console.WriteLine($"Заданное число: {number} - НЕ палиндром!");
//}
//if (number!.Length == 5)
//{
  //CheckingNumber(number);
//}
//else Console.WriteLine($"Вы ввели некорректное число!");


Console.WriteLine("Введите пятизначное число: ");
int usernum = Convert.ToInt32(Console.ReadLine());

int digitCount = (int)Math.Log10(usernum) + 1;
if (digitCount == 5)
{
  int lastNum = usernum % 10;
  int preLast = usernum %100;
  
  if ((usernum / 10000 == lastNum) && (usernum / 1000 == preLast)) Console.WriteLine($"Заданное число: {usernum} - палиндром!");
  else Console.WriteLine($"Заданное число: {usernum} - НЕ палиндром!");
}
else Console.WriteLine($"Вы ввели некорректное число!");
