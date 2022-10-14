/*DoOperation(5, 4, Add);         // 9
DoOperation(5, 4, Subtract);    // 1
DoOperation(5, 4, Multiply);    // 20

void DoOperation(int a, int b, Operation op)
{
    Console.WriteLine(op(a, b));
}
int Add(int x, int y) => x + y;
int Subtract(int x, int y) => x - y;
int Multiply(int x, int y) => x * y;

delegate int Operation(int x, int y);*/

Account account = new Account(200);
// Добавляем в делегат ссылку на методы
account.RegisterHandler(PrintSimpleMessage);
account.RegisterHandler(PrintColorMessage);
// Два раза подряд пытаемся снять деньги
account.Take(100);
account.Take(150);

// Удаляем делегат
account.UnregisterHandler(PrintColorMessage);
// снова пытаемся снять деньги
account.Take(50);

void PrintSimpleMessage(string message) => Console.WriteLine(message);
void PrintColorMessage(string message)
{
    // Устанавливаем красный цвет символов
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    // Сбрасываем настройки цвета
    Console.ResetColor();
}