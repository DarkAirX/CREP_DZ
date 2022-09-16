// 5. Определить являются ли введенные с клавиатуры символы правильной записью целого числа.
// Вычислить сумму цифр введенного числа


string num = Console.ReadLine();

            int temp = 0;
            if (!Int32.TryParse(num, out temp))
                Console.WriteLine("Это не является верной записью целого числа");
            else {
                int sum = 0;
                foreach (char digit in num)
                    sum += digit - 48;
                Console.WriteLine("Сумма цифр = " + sum);
            }