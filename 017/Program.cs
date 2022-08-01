// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int day=Convert.ToInt32(Console.ReadLine());
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (day > 5) txtResult = $". Это выходной день!";
else txtResult = $", Это рабочий день.";

System.Console.WriteLine($"{day}-й день недели - это {Days[day - 1]}{txtResult}");