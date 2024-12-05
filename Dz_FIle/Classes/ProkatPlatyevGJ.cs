

namespace Domashka
{
    internal class ProkatPlatyevGJ: ProkatPlatyev
    {
        static ClassUslug classUslug = ClassUslug.Стандарт;
        static string nameOfProkat = "Gloria Jeans";
        static private List<string> colorsGj = new List<string>() { "Белый", "Серый", "Бежевый" };
        static private List<Razmers> razmersGj = new List<Razmers>() { Razmers.S, Razmers.M, Razmers.L };
        public ProkatPlatyevGJ()
        {
            Next();
            Hello();
            this.razmerDress = UserRazChoice();
            this.colorDress = UserColorChoice();
            this.typeOfDress = UserTypeChoice();
            this.priceDress = Prices(razmerDress);
            this.Dress();


        }
        public void Hello()
        {
            Console.WriteLine($"Вас приветствует {nameOfProkat}, давайте я помогу вам выбрать свадебное платье. К сожалению класс наших услуг {classUslug}, но я постораюсь вам помочь");
        }
        
        public Razmers UserRazChoice()
        {
            Console.WriteLine("У нас есть только следующие размеры");
            int j = 1;
            foreach (Razmers i in razmersGj)
            {
                Console.WriteLine("{0}){1}",j,i);
                j++;
            }
            Console.WriteLine("Выберите один из них(1-3)");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    return Razmers.S;
                case '2':
                    return Razmers.M;
                case '3':
                    return Razmers.L;
                default:
                    throw new Exception("К сожалению у нас нет такого размера");
            }
        }
        public string UserColorChoice()
        {
            Console.WriteLine("ВЫберите один из следующй цветов платья(1-3):");
            int j = 1;
            foreach (string i in colorsGj)
            {
                Console.WriteLine("{0}){1}",j, i);
                j++;
            }
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    return "Белый";
                case '2':
                    return "Серый";
                case '3':
                    return "Бежевый";
                default:
                    throw new Exception("К сожалению у нас нет платья такого цвета");
            }
        }
        public TypeOfDress UserTypeChoice()
        {
            StiliPlatyev();
            Console.WriteLine($"К сожалению в данных момент у нас нет {TypeOfDress.Греческое} и {TypeOfDress.Русалка}, вы можете выбрать 1)прямое и 2)пышное");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    return TypeOfDress.Прямое;
                case '2':
                    return TypeOfDress.Пышное;
                default:
                    throw new Exception("Такого вида платья у нас нет");
            }
        }
        public decimal Prices(Razmers razmerDress)
        {
            return (decimal)(10 * ((int)razmerDress*0.1 + 1));
        }
    }
}
