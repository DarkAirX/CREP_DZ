﻿// 3. С клавиатуры вводится строка, разделенная точкой.
// Подсчитать количество символов до точки
{
    string str = "1243342.34534";
    
    int before = str.IndexOf('.');
 
    Console.WriteLine($"До точки {before} символов");
}


