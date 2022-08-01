// See Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int Number = 0;
int x = new Random().Next(-100, 101);
int y = new Random().Next(-100, 101);
System.Console.WriteLine($"Координаты точки: ({x}, {y})");

if (x * y == 0) Number = 0;
else if (x > 0 && y > 0) Number = 1;
else if (x < 0 && y > 0) Number = 2;
else if (x < 0 && y < 0) Number = 3;
else Number = 4;

System.Console.Write($"Точка с координатами ({x}, {y}) находится ");
if (Number == 0) System.Console.WriteLine("на одной из оси координат");
else System.Console.WriteLine($"в {Number}-й четверти");
System.Console.WriteLine();