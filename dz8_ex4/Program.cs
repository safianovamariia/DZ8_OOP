using System;

interface IItem
{
    void SetPrice(double price);
}

interface IDiscountable
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}

interface IWearable
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book : IItem, IDiscountable
{
    private double price;
    private String discount;
    private String promocode;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine("Book price: " + price);
    }

    public void ApplyDiscount(String discount)
    {
        this.discount = discount;
        Console.WriteLine("Book discount: " + discount);
    }

    public void ApplyPromocode(String promocode)
    {
        this.promocode = promocode;
        Console.WriteLine("Book promocode: " + promocode);
    }
}

class Outerwear : IItem, IDiscountable, IWearable
{
    private double price;
    private String discount;
    private String promocode;
    private byte color;
    private byte size;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine("Outerwear price: " + price);
    }

    public void ApplyDiscount(String discount)
    {
        this.discount = discount;
        Console.WriteLine("Outerwear discount: " + discount);
    }

    public void ApplyPromocode(String promocode)
    {
        this.promocode = promocode;
        Console.WriteLine("Outerwear promocode: " + promocode);
    }

    public void SetColor(byte color)
    {
        this.color = color;
        Console.WriteLine("Outerwear color: " + color);
    }

    public void SetSize(byte size)
    {
        this.size = size;
        Console.WriteLine("Outerwear size: " + size);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.SetPrice(250);
        book.ApplyDiscount("10%");
        book.ApplyPromocode("BOOK10");

        Console.WriteLine();

        Outerwear jacket = new Outerwear();
        jacket.SetPrice(1500);
        jacket.ApplyDiscount("20%");
        jacket.ApplyPromocode("WINTER20");
        jacket.SetColor(3);
        jacket.SetSize(48);

        Console.ReadKey();
    }
}