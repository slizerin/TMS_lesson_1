namespace TMS_lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  ЗАДАНИЕ 1:=============================================================================

            // комментарий
            Console.WriteLine("Введите вашу фамилию: ");
            var LastName = Console.ReadLine();

            Console.WriteLine("Введите ваше имя: ");
            var Name = Console.ReadLine();

            Console.WriteLine("Введите ваше отчество: ");
            var FirstName = Console.ReadLine();

            Console.WriteLine("Введите дату рождения: ");
            var Data = Console.ReadLine();

            Console.WriteLine($"Ваши данные:{LastName} {Name} {FirstName} ({Data})");
            Console.ReadKey();


            //  ЗАДАНИЕ 2:==============================================================================

            Random rnd = new Random();
            string[] mass =  {"осень", "пришла", "ветер", "летает",
                                          "листья", "кружат", "сердце", "мечтает",
                                          "вдали", "костер", "вечер", "зовет",
                                          "звездный", "ветер", "шепчет", "что-то"};
            for (int i = 0; i < mass.Length; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(mass[rnd.Next(i)] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

            //  ЗАДАНИЕ 3: =============================================================================

            Console.WriteLine("Вас приветствует игра в пару ходов, " +
                "где 1 - налево, а 2 - направо.");
            Console.WriteLine("Выбрав правильный путь вы сможете выжить - выберите ход(налево/направо)?");

            var x = Console.ReadLine();

            switch (x)
            {
                case "1":
                    Console.WriteLine("Вы смогли скрыться от медведя!");
                    Console.WriteLine("Нужно дойти до конца - выберите следующий шаг");
                    var y = Console.ReadLine();
                    if (y == "1")
                    {
                        Console.WriteLine("Вы смогли выжить, поздравляем!");
                    }
                    else if (y == "2")
                    {
                        Console.WriteLine("Вы проиграли(");
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не корректные данные.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Вы проиграли(");
                    break;

                default:
                    Console.WriteLine("Вы ввели не корректные данные.");
                    break;
            }
        }
    }
}
