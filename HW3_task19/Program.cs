// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число:");
string? line = Console.ReadLine();
if (line != null) {
    char[] array = line.ToCharArray();
    for (int i = 0; i< 2; i+=1){
        if(array[i] != array[4-i]){
            Console.WriteLine("нет");
            Environment.Exit(0);
        }
    }
    Console.WriteLine("да");

}

