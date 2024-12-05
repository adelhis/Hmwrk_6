
namespace Domashka
{
    internal class ProkatUBabiZini : ProkatPlatyev
    {
        static public string nameOfProkat = "Baba Zina";
        static public ClassUslug classUslug = ClassUslug.Эконом;
        public ProkatUBabiZini()
        {
            Next();
            nameDress = "Прабабушкино";
            colorDress = "Белое";
            razmerDress = Razmers.XXL;
            BabiZinaZovet();
        }
        public void BabiZinaZovet()
        {
            Console.WriteLine("Внученька пора замуж тебе, подойди сюда");
            Console.WriteLine("Вот посмотри какое платье есть");
        }
        public void BabiZinaChoice()
        {
            Console.WriteLine("Какой у тебя размер внученька");
            Console.ReadKey();
            Primerka(Razmers.XXL);
            Console.WriteLine("Немного ушьем и пойдет");
        }
        public void BabiZinaTorg()
        {
            Console.WriteLine($"За {priceDress} забирай навсегда, еще внучкам передашь");
        }
    }
}
