
namespace Domashka
{
    internal class ProkatPlatyevLV: ProkatPlatyev
    {
        static public string nameOfProkat = "Louis Vuitton";
        static public ClassUslug classUslug = ClassUslug.Люкс;
        
        public ProkatPlatyevLV()
        {
            Next();
            Hello();
            Zakaz();
        }
        public void Hello()
        {
            Console.WriteLine($"Вас приветствует отдел проката свадебных платьев Louis Vuitton. Мы предоставляем {classUslug} услуги: шитье на заках с полным выбором свойств платья.");
        }
        public void Zakaz()
        {
            this.priceDress = 1000;
            Console.Write("Введите ваш бюджет(в долларах): ");
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal Userbalance);
            if (isDecimal)
            {
                if (IsUserHaveMoney(Userbalance))
                {
                    Console.WriteLine("Отлично, через неделю мы сделаем для вас платье, и вы сможете взять его в прокат на {0} дней", Userbalance / priceDress);
                    Console.WriteLine("Заполните небольшую анкету желаемого платья. И мы сделаем его лично для вас. Стандартная цена платья - 1000%/сут.");
                    StiliPlatyev();
                    Console.Write("Выберите вид платья платья(1-4, либо оставьте графу пустой, и выберите прямое):");
                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            this.typeOfDress = TypeOfDress.Прямое;
                            break;
                        case '2':
                            this.typeOfDress = TypeOfDress.Пышное;
                            break;
                        case '3':
                            this.typeOfDress = TypeOfDress.Русалка;
                            break;
                        case '4':
                            this.typeOfDress = TypeOfDress.Греческое;
                            break;
                        default:
                            this.typeOfDress = TypeOfDress.Прямое;
                            break;
                    }
                    
                    Console.Write("Выберите ваш размер\n1 - XS\n2-S\n3-M\n4-L\n5-XL\n6-XXL\n7-XXXL\nлибо оставьте графу пустой, и выберите XS\n");
                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            this.razmerDress = Razmers.XS;
                            break;
                        case '2':
                            this.razmerDress = Razmers.S;
                            break;
                        case '3':
                            this.razmerDress = Razmers.M;
                            break;
                        case '4':
                            this.razmerDress = Razmers.L;
                            break;
                        case '5':
                            this.razmerDress = Razmers.XL;
                            break;
                        case '6':
                            this.razmerDress = Razmers.XXL;
                            break;
                        case '7':
                            this.razmerDress = Razmers.XXXL;
                            break;
                        default:
                            this.razmerDress = Razmers.XS;
                            break;
                    }
                    Console.WriteLine("Давайте померим несколько платий чтобы убедиться, что платья такого размера вам подходит");
                    Razmers wantRazmer = Razmers.XS;
                    do
                    {
                        Console.Write("Выберите ваш размер\n1 - XS\n2-S\n3-M\n4-L\n5-XL\n6-XXL\n7-XXXL\nлибо оставьте графу пустой, и выберите XS\n");
                        switch (Console.ReadKey().KeyChar)
                        {
                            case '1':
                                wantRazmer = Razmers.XS;
                                break;
                            case '2':
                                wantRazmer = Razmers.S;
                                break;
                            case '3':
                                wantRazmer = Razmers.M;
                                break;
                            case '4':
                                wantRazmer = Razmers.L;
                                break;
                            case '5':
                                wantRazmer = Razmers.XL;
                                break;
                            case '6':
                                wantRazmer = Razmers.XXL;
                                break;
                            case '7':
                                wantRazmer = Razmers.XXXL;
                                break;
                        }
                    } while (!Primerka(wantRazmer));
                    Console.Write("Какой цвет платья вы бы хотели(Мы можем сделать для вас платье любого цвета):");
                    this.colorDress = Console.ReadLine();
                    DressZakaz();
                }
                else
                {
                    Console.WriteLine("К сожалению у нас нет предложений для вас");
                }
            }
            else
            {
                Console.WriteLine("Извините вы ввели не сумму");
            }       
        }
        public void DressZakaz()
        {
            Console.WriteLine($"Вы заказали платье\nВид: {this.typeOfDress}\nРазмер: {this.razmerDress}\nЦвет: {this.colorDress}\nОно будет готово ровно через неделю");
            Console.WriteLine("Как бы ва назвали это платье?");
            this.nameDress = Console.ReadLine();
            Console.WriteLine("Замечательное название. Информация о платье:");
            this.Dress();
        }
    }
}
