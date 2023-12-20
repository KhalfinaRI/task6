// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

string GetStringFromCharArray(char [,] chars){
    string res = "";
    foreach (char elem in chars){ // в каждом элементе масссива мы будем что-то делать, еще один вида функции цикла
        res += elem;
    } 
    return res;
}

char [,] chars = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
string str = GetStringFromCharArray(chars);
Console.WriteLine(str);



// string GetStringFromCharArray(char [] chars){
//     string res = "";
//     foreach (char elem in chars){ // в каждом элементе масссива мы будем что-то делать, еще один вида функции цикла
//         res += elem;
//     } 
//     return res;
// }

// char [] chars = {'a', 'b', 'c', 'd'};
// string str = GetStringFromCharArray(chars);
// Console.WriteLine(str);