/*Основной класс содержащий, цвет, размер, длину(перечесление), вид платья*/
namespace Domashka
{
    enum Razmers
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL,
        XXXL
    }
    enum TypeOfDress
    {
        Прямое,
        Пышное,
        Русалка,
        Греческое
    }

    enum ClassUslug
    {
        Люкс,
        Стандарт,
        Эконом
    }

    abstract internal class ProkatPlatyev
    {
        static private uint numOfDress = 0;
        public string nameDress;
        public string colorDress;
        public decimal priceDress;
        public Razmers razmerDress;
        public TypeOfDress typeOfDress;
        public void Next()
        {
            numOfDress++;
        }
        public bool IsUserHaveMoney(decimal UserBalance)
        {
            if (UserBalance >= priceDress)
            {
                return true;
            }
            return false;
        }
        public bool Primerka(Razmers UserRazmer)
        {
            if (razmerDress == UserRazmer)
            {
                Console.WriteLine($"Свадебное платье с размером {razmerDress} вам подходит");
                return true;
            }
            else
            {
                Console.WriteLine("Давайте примерим другое платье");
                return false;
            }
        }
        public void StiliPlatyev()
        {
            Console.WriteLine("Так выглядят виды платьев:\n" +
                "1)Прямое:\n" +
                "   #####\n" +
                "   #####\n" +
                "    ### \n" +
                "   #####\n" +
                "   #####\n" +
                "   #####\n" +
                "   #####\n" +
                "2)Пышное:\n" +
                "   #####   \n" +
                "   #####   \n" +
                "    ###    \n" +
                "  #######  \n" +
                " ######### \n" +
                "###########\n" +
                "###########\n" +
                "3)Русалка:\n" +
                "   #####  \n" +
                "   #####  \n" +
                "    ###   \n" +
                "   #####  \n" +
                "   #####  \n" +
                "    ###   \n" +
                "  ####### \n" +
                "4)Греческое:\n" +
                "   #####   \n" +
                "   #####   \n" +
                "    ###    \n" +
                "   #####   \n" +
                "  #######  \n" +
                " ######### \n" +
                "###########\n");
        }
        public void Dress()
        {
            Console.WriteLine($"Платье: {nameDress}\nНомер: {numOfDress}\nРазмер:{razmerDress}\nЦвет:{colorDress}\nВид: {typeOfDress}\nЦена:{priceDress}$");
        }


    }
}
