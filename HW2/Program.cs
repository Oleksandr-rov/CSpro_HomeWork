namespace HW2
{
    // Базовий клас для персонажів
    class Character
    {
        public string Name { get; set; }
        public string Strength { get; set; }

        public Character(string name, string strength)
        {
            Name = name;
            Strength = strength;
        }
        public void pull()
        {
            // TODO
            //ripka.DecreaseStrength();
        }
        public void Help()
        {
            Console.WriteLine($"{Name} допомагає витягти ріпку!");
        }
    }

    // Клас Ріпка
    class Ripka
    {
        private int strength;

        public Ripka(int initialStrength)
        {
            strength = initialStrength;
        }

        public void Grow()
        {
            Console.WriteLine("Ріпка росте...");
            strength += 10;
        }

        public void DecreaseStrength()
        {
            strength -= 5;
        }

        public bool IsPulled()
        {
            return strength <= 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо персонажів
            var grandpa = new Character("Дід");
            var grandma = new Character("Бабця");
            var granddaughter = new Character("Онучка");
            var dog = new Character("Жучка");

            // Створюємо ріпку
            var ripka = new Ripka(30); // Початкова "міцність" ріпки

            // Додаємо персонажів до списку
            var characters = new List<Character> { grandpa, grandma, granddaughter, dog };

            // Садимо ріпку
            Console.WriteLine("Дід садить ріпку...");

            // Ростемо ріпку
            ripka.Grow();

            // Витягуємо ріпку, поки не буде витягнута або не закінчаться персонажі
            foreach (var character in characters)
            {
                while (!ripka.IsPulled())
                {
                    character.HelpPull(ripka);
                }

                if (ripka.IsPulled())
                {
                    Console.WriteLine($"{character.Name} витягнув ріпку!");
                    break;
                }
            }

            Console.WriteLine("Кінець казки!");
        }
    }
    }
