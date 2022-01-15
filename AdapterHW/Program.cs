
namespace AdapterHW
{
    class program
    {
       
        static void Main(string[] args)
        {
            Dollar Adapter1 = new ConvertMoney();
            int Ran = new Random().Next(10);

            PaymentMethod(Adapter1,Ran);



        }

        public static void PaymentMethod(Dollar Convert, double Pay)
        {
            Console.WriteLine(Convert.DollarPayment(Pay));
        }
    }
}
