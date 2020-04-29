using System.Drawing;
namespace Task2
{
    public class Clothes : IItem, IDiscount, IPromo
    {
        public void SetColor(Color color)    {    }
        public void SetDiscount(double discount)    {    }
        public void SetPrice(double price)    {    }
        public void SetPromocode(string promocode)    {    }
        public void SetSize(Size size)    {    }
    }
}