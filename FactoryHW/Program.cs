using FactoryHW;
namespace FactoryHW
{
    class program
    {
        static void Main(string[] args)
        {
            var Diet1 = DietFactory.AllDietBase(52,150, 1.72);
            var Diet2 = DietFactory.AllDietBase(52, 69, 1.72);
            var Diet3 = DietFactory.AllDietBase(32, 100, 1.72);
            var Diet4 = DietFactory.AllDietBase(25, 100, 1.72);
            Console.WriteLine(Diet1.GetDiet());
            Console.WriteLine(Diet2.GetDiet());
            Console.WriteLine(Diet3.GetDiet());
            Console.WriteLine(Diet4.GetDiet());


            


        }
    }
}
