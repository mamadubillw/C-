// See https://aka.ms/new-console-template for more information
class Program
{
        struct Product
        {
                static void Main(string[] args){
                        Product mouse = new Product(1, "mouse gamer", 34.65);
                        Console.WriteLine(mouse.Id);
                        Console.WriteLine(mouse.Name);
                        Console.WriteLine(mouse.Price);
                }
                public Product(int id, string name, double price){
                        Id = id;
                        Name = name;
                        Price = price;
                }
                public int Id;
                public string Name;
                public double Price;

                public double PriceInDolar(double dolar){
                        return Price * dolar;
                }
        }
}