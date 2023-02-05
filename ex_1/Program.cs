// Вид 1:
// ничего не принимают, ничего не возвращают (тип void)

void Method1() {
    Console.WriteLine("Автор Daria Grigorenko");
}

Method1();

// Вид 2:
// что-то принимают, ничего не возвращают (тип void)

void Method2(string msg) {
    Console.WriteLine(msg);
}

Method2("Text SMS");

//Method2(msg: "Text doc");

void Method21(string msg, int count) {
    int i = 0;
    while (i < count) {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21("Text", 4);
Method21(msg: "txt", count: 4);
//Method21(count: 4, msg: "txt");

// Вид 3:
// ничего не принимают, что-то возвращают (генерировать случайные данные)

int Method3() {
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4:
// что-то принимают, что-то возвращают

string Method4(int count, string text) {
    int i = 0;
    string result = String.Empty; // пустая строка
    while (i < count) {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "pdf");
Console.WriteLine(res);