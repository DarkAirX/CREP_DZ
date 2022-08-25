// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0


 int c = 0;
            Random Rand = new Random();
            int[] a = new int[4];
            Console.WriteLine("");


            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Rand.Next(0, 100);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("");
int result = 0;
 for (int i = 0; i < a.Length; i++)
 

            {
                if (a[i] % 2 != 0)
                {
                    result += a[i];
                }
              
            }
            Console.WriteLine(result);