
using ChainOfresponsibiltyHW;

namespace ChainOfResponsibiltyHW
{
    class program
    {
        static void Main(string[] args)
        {
            Cars first_Checkup = new FirstCheckUp();
            Cars second_Checkup = new Car_Assemblies();
            Cars third_Checkup = new Electric_CheckUp();
            Cars fourth_Checkup = new Diagnostic_CheckUp();


            first_Checkup.SetNext(second_Checkup);
            second_Checkup.SetNext(third_Checkup);
            third_Checkup.SetNext(fourth_Checkup);
            fourth_Checkup.SetNext(null);

            first_Checkup.Handle();
        }
    }
}
