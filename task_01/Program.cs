/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
 степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


Console.WriteLine(Pow(2,4));

int Pow(int a, int b){    ///// 2 3    2*2*2
int res = a;
for(int i = 1; i < b; i++) {
res *= a;
}

return res;
}