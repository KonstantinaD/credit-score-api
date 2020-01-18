namespace ConsoleApp_09_StaticClass
{
    public static class JaguarCars
    {
        //initialised at runtime
        internal static readonly string companyName = "Jaguar";
        internal static readonly string companyRegOffice;

        //static constructor initialises field
        static JaguarCars()
        {
            companyRegOffice = "Whitley, Coventry, England.";
        }
    }
}