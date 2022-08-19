// See https://aka.ms/new-console-template for more information
class Program
{
        struct Product
        {
                static void Main(string[] args){
                        Product mouse = new Product(1, "mouse gamer", 34.65, EProductType.Product);
                        Console.WriteLine(mouse.Id);
                        Console.WriteLine(mouse.Name);
                        Console.WriteLine(mouse.Price);
                        Console.WriteLine(mouse.Type);
                }
                public Product(int id, string name, double price, EProductType type){
                        Id = id;
                        Name = name;
                        Price = price;
                        Type = type;
                }
                public int Id;
                public string Name;
                public double Price;
                public EProductType Type;

                public double PriceInDolar(double dolar){
                        return Price * dolar;
                }
        }

        enum EProductType{
                Product = 1,
                Service = 2
        }
}
