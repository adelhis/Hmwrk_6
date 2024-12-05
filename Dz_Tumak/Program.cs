
namespace Domashka
{

    class Dz_Tumak
    {
        static void Main()
        {
            Zadanie1();
            Zadanie2();
            Zadanie3();
            Zadanie4();


        }
        static void Zadanie1()
        {
            /*Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
            банковского счета (использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
            доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и
            вывести информацию об объекте класса на печать.*/
            Console.WriteLine("\nЗадание 7.1 Создать класс счет в банке\n");
            BankTumak bankTumak = new BankTumak(1122334455667788, 1000000, Bank.Сберегательный);
            bankTumak.PrintInfoShet();
            bankTumak.ChangeInfoShet();
        }
        static void Zadanie2()
        {
            /*Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
            номер счета генерировался сам и был уникальным. Для этого надо создать в классе
            статическую переменную и метод, который увеличивает значение этого переменной.*/
            Console.WriteLine("\nЗадание 7.2 Изменить класс\n");
            AutoBankTumak autoBankTumak = new AutoBankTumak(1000000, Bank.Сберегательный);
            autoBankTumak.PrintInfoShet();
            autoBankTumak.ChangeInfoShet();
            autoBankTumak.ChangeInfoShet();
        }
        static void Zadanie3()
        {
            /*Упражнение 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на
            счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
            положительного результата изменяет баланс.*/
            Console.WriteLine("\nЗадание 7.1 Создать класс счет в банке\n");
            BankTumak bankTumak = new BankTumak(1122334455667788, 1000000, Bank.Сберегательный);
            bankTumak.PrintInfoShet();
            bankTumak.ChangeInfoShet();
            bankTumak.GiveBalanceShet();
            bankTumak.TakeBalanceShet();
        }
        static void Zadanie4()
        {
            /*Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания,
            высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
            предусмотреть методы для заполнения полей и получения значений полей для печати.
            Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
            квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания
            генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы
            хранило последний использованный номер здания, и предусмотреть метод, который
            увеличивал бы значение этого поля.*/
            Console.WriteLine("Домашнее задание 7.1. Создать класс здания с уникальным номером");
            Console.WriteLine("\nЭкземляр #1");
            Building building = new Building();
            building.SetBuilding();
            Console.WriteLine("\nЭкземляр #2");
            building = new Building(100,10,2,100);
            building.InfoBuilding();
            building.SetBuilding();
        }

        //К упражнению 7.1
    }
    enum Bank
    {
        Сберегательный,
        Текущий,
        Необозначенный
    }

    class BankTumak
    {
        private long idShet;
        private decimal balanceShet;
        private Bank typeShet = Bank.Сберегательный;

        public void PrintInfoShet()
        {
            Console.WriteLine($"Номер счета: {idShet}\nБаланс счета: {balanceShet}\nТип счета: {typeShet}");
        }
        public BankTumak()
        {
            this.idShet = 0;
            this.balanceShet = 2200000000000000;
            this.typeShet = Bank.Необозначенный;
        }
        public BankTumak(long idShet, decimal balanceShet, Bank typeShet)
        {
            this.idShet = idShet;
            this.balanceShet = balanceShet;
            this.typeShet = typeShet;
        }
        public void ChangeInfoShet()
        {
            Console.Write("Введите новый номер счета:");
            bool isLong = long.TryParse(Console.ReadLine(), out long newIdShet);
            if (isLong && newIdShet.ToString().Length == 16)
            {
                this.idShet = newIdShet;
            }
            else
            {
                this.idShet = idShet;
                Console.WriteLine("Номер должен состоять из 16 цифр, оставлено заданное ранее значение");
            }
            Console.Write("Введите текущий баланс счета:");
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal newBalanceShet);
            if (isDecimal)
            {
                this.balanceShet = newBalanceShet;
            }
            else
            {
                this.balanceShet = balanceShet;
                Console.WriteLine("Такого баланса быть не может, оставлено заданное ранее значение");
            }
            Console.Write("На какой тип необходимо поменять(Сберегательный/текущий):");
            switch (Console.ReadLine().ToLower())
            {
                case "текущий":
                    typeShet = Bank.Текущий;
                    break;
                case "сберегательный":
                    typeShet = Bank.Сберегательный;
                    break;
                default:
                    this.typeShet = typeShet;
                    Console.WriteLine("Такого типа счета не существует, оставлено заданное ранее значение");
                    break;
            }
            this.PrintInfoShet();
        }
        //к упражнению 7.3
        public void TakeBalanceShet()
        {
            Console.Write("Введите сумму которую хотите снять:");
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal takenBalanceShet);
            if (isDecimal)
            {
                if (takenBalanceShet < this.balanceShet)
                {
                    balanceShet = balanceShet - takenBalanceShet;
                    Console.WriteLine($"Вы успешно сняли со счета\nТекущий баланс: {balanceShet}");
                }
                else
                {
                    Console.WriteLine("У вас недостаточно средств");
                }
            }
            else
            {
                Console.WriteLine("Вы вввели не сумму");
            }
        }
        public void GiveBalanceShet()
        {
            Console.Write("Введите сумму которую хотите положить:");
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal givenBalanceShet);
            if (isDecimal)
            {
                balanceShet = balanceShet + givenBalanceShet;
                Console.WriteLine($"Вы успешно пополнили счет\nТекущий баланс счета:{balanceShet}");
            }
            else
            {
                Console.WriteLine("Вы вввели не сумму");
            }
        }
    }

    //К упражнению 7.2
    class AutoBankTumak
    {
        static private long idShet = 2200000000000000;
        private decimal balanceShet;
        private Bank typeShet = Bank.Сберегательный;

        public void PrintInfoShet()
        {
            Console.WriteLine($"Номер счета: {idShet}\nБаланс счета: {balanceShet}\nТип счета: {typeShet}");
        }
        public AutoBankTumak()
        {
            this.Next();
            this.balanceShet = 0;
            this.typeShet = Bank.Необозначенный;
        }
        public AutoBankTumak(decimal balanceShet, Bank typeShet)
        {
            this.Next();
            this.balanceShet = balanceShet;
            this.typeShet = typeShet;
        }
        public void Next()
        {
            idShet++;
        }
        public void ChangeInfoShet()
        {
            this.Next();
            Console.WriteLine("Создан новый номер счета");
            Console.Write("Введите текущий баланс счета:");
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal newBalanceShet);
            if (isDecimal)
            {
                this.balanceShet = newBalanceShet;
            }
            else
            {
                this.balanceShet = balanceShet;
                Console.WriteLine("Такого баланса быть не может, оставлено заданное ранее значение");
            }
            Console.Write("На какой тип необходимо поменять(Сберегательный/текущий):");
            switch (Console.ReadLine().ToLower())
            {
                case "текущий":
                    this.typeShet = Bank.Текущий;
                    break;
                case "сберегательный":
                    this.typeShet = Bank.Сберегательный;
                    break;
                default:
                    this.typeShet = typeShet;
                    Console.WriteLine("Такого типа счета не существует, оставлено заданное ранее значение");
                    break;
            }
            this.PrintInfoShet();
        }
    }

    //к домашнему заданию 7.1
    class Building
    {
        static private uint numBuilding = 0;
        private ushort heightBuilding;
        private byte numOfFloors;
        private byte numOfPods;
        private ushort numOfAparts;

        public Building()
        {
            Next();
            this.heightBuilding = 1;
            this.numOfFloors = 1;
            this.numOfPods = 1;
            this.numOfAparts = 1;
        }
        public Building(ushort heightBuilding, byte numOfFloors, byte numOfPods, ushort numOfApart)
        {
            Next();
            this.heightBuilding = heightBuilding;
            this.numOfFloors = numOfFloors;
            this.numOfPods = numOfPods;
            this.numOfAparts = numOfApart;
        }
        public void Next()
        {
            numBuilding++;
        }
        public void InfoBuilding()
        {
            Console.WriteLine($"Номер здания: {numBuilding}\n" +
                $"Высота здания: {heightBuilding}\n" +
                $"Количество этажей: {numOfFloors}\n" +
                $"Количество подъездов: {numOfPods}\n" +
                $"Количество квартир: {numOfAparts}\n" +
                $"Высота 1 этажа: {this.HegightFloor()}\n" +
                $"Количество квартир в подъезде: {this.NumOfApartsInPods()}\n" +
                $"Количество квартир на этаже: {this.NumOfApartsInFloor()}");
        }
        public void SetBuilding()
        {
            Console.Write("Введите высоту здания: ");
            bool isValid = ushort.TryParse(Console.ReadLine(), out ushort newHeightBuilding);
            if (isValid)
            {
                this.heightBuilding = newHeightBuilding;
            }
            else
            {
                this.heightBuilding = 1;
                Console.WriteLine("Такой высоты не может быть, выставлено значение по умолчанию - 1");
            }
            Console.Write("Введите количество этажей в здании: ");
            isValid = byte.TryParse(Console.ReadLine(), out byte newNumOfFloors);
            if (isValid)
            {
                this.numOfFloors = newNumOfFloors;
            }
            else
            {
                this.numOfFloors = 1;
                Console.WriteLine("Такого количества этажей не может быть, выставлено значение по умолчанию - 1");
            }
            Console.Write("Введите количество подъездов в здании: ");
            isValid = byte.TryParse(Console.ReadLine(), out byte newNumOfPods);
            if (isValid)
            {
                this.numOfPods = newNumOfPods;
            }
            else
            {
                this.numOfPods = 1;
                Console.WriteLine("Такого количества подъездов не может быть, выставлено значение по умолчанию - 1");
            }
            Console.Write("Введите количество квартир в здании: ");
            isValid = ushort.TryParse(Console.ReadLine(), out ushort newNumOfAparts);
            if (isValid)
            {
                this.numOfAparts = newNumOfAparts;
            }
            else
            {
                this.numOfAparts = 1;
                Console.WriteLine("Такого количества квартир не может быть, выставлено значение по умолчанию - 1");
            }
            this.InfoBuilding();
        }
        public double HegightFloor()
        {
            return this.heightBuilding / this.numOfFloors;
        }
        public uint NumOfApartsInPods()
        {
            if (this.numOfAparts % this.numOfPods == 0)
            {
                return (uint)this.numOfAparts / this.numOfPods;
            }
            else
            {
                throw new Exception("С таким количеством кваритр здание не может иметь столько подъездов");
            }
        }
        public uint NumOfApartsInFloor()
        {
            if (this.numOfAparts % this.numOfFloors == 0)
            {
                return (uint)this.numOfAparts / this.numOfFloors;
            }
            else
            {
                throw new Exception("С таким количеством кваритр здание не может иметь столько этажей");
            }
        }
    }
}
