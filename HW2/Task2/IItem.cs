namespace Task2
{
    public interface IItem
    {
        void SetDiscount( double discount ); 
        void SetPromocode( string promocode);

        void SetColor(Color color);
        void SetSize(Size size);

        void SetPrice(double price);
    }
}