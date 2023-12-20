// Проверка на полиндром


public class Task3
{
public static void Main(string[] args)
{

string input = "шалаш";

bool isPalindrome = IsPalindrome(input);

Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
public static bool IsPalindrome(string str){
string normalized = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
return normalized.SequenceEqual(normalized.Reverse());
}
}

