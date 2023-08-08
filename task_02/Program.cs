/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine(Sum(2222));

int Sum (int n) {
   
    string nStr = n.ToString();
    int sum = 0;
    
    for(int i = 0; i < nStr.Length; i++) {
        sum+= Convert.ToInt32("" + nStr[i]);
    }
return sum;
}