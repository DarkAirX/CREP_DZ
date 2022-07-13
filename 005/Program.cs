double a,b,c;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
b=Convert.ToDouble(s);
c=Convert.ToDouble(s);
s=Console.ReadLine();
   if (a > b && b > c)
                    Console.WriteLine("Nubmer Max = " + a); 
                else if (a > c)
                    Console.WriteLine("Number Max = " + b); 
                else 
                    Console.WriteLine("Number Max = " + c); 
            
            Console.ReadLine();
              