/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
(можно указать любой промежуток)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] arr = FillArray(8);
PrintArray(arr);

int[] FillArray(int size){
    int[] arr = new int[size];
    for(int i = 0; i < size; i++) {
        arr[i] = new Random().Next(1,50);
    }
    return arr;
}

void PrintArray(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
    Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}