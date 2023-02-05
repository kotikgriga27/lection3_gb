// Цикл for

string Method4(int count, string text) {
    string result = String.Empty; // пустая строка
    for(int i = 0; i < count; i++) {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "pdf");
Console.WriteLine(res);
