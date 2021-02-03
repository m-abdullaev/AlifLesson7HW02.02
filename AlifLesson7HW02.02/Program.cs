using System;

namespace AlifLesson7HW02._02
{
    class Program
    {
        static void Main(string[] args)
        {
            int titleID = Convert.ToInt32(Console.ReadLine());
            string titleB = Console.ReadLine();
            string type = Console.ReadLine();
            double price = Convert.ToDouble(Console.ReadLine());
            double advance = Convert.ToDouble(Console.ReadLine());
            double ytdSale = Convert.ToDouble(Console.ReadLine());
            Titles title = new Titles(titleID,titleB,type,price,advance,ytdSale);
            title.titleInformation();
        }
    }
    class Titles
    {
        public int titleID { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public double price { get; set; }
        public double advance { get; set; }
        public double ytdSales { get; set; }
        public Titles(int titleID, string title, string type, double price, double advance, double ytdSales)
        {
            this.titleID = titleID;
            this.title = title;
            this.type = type;
            this.price = price;
            this.advance = advance;
            this.ytdSales = ytdSales;
        }
        public void titleInformation()
        {
            Console.WriteLine($"TitleID: {titleID}\nTitle: {title}\n" +
                $"Type: {type}\nPrice: {price}\nAdvance: {advance}\nYear to date sale: {ytdSales}");
        }
    }
}
