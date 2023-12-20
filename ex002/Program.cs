// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

//  void CreateString(string[] args)
// {
// // Входная строка со смешанными буквами обоих регистров
// string input = " ";
// // Преобразование всех заглавных букв в строчные
// string result = input.ToLower();
// // Вывод результата
// Console.WriteLine(result);
// }

// Console.WeiteLine("Задайте строку, содержащую латинские буквы в обоих регистрах: ");

string GetString(string arg){
     string res = "";
     
     for (int i = 0; i < arg.Length; i++){
        res += Char.ToLower(arg[i]);
    } 
    return res;
}
Console.WriteLine();
Console.Write("Задайте строку, содержащую латинские буквы в обоих регистрах: ");
string input = Console.ReadLine() + " ";
Console.WriteLine($"Все заглавные буквы были заменены на строчные: {GetString(input)}");
Console.WriteLine();