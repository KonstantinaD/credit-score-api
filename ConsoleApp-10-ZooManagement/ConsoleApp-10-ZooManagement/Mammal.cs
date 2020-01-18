namespace ConsoleApp_10_ZooManagement
{
    class Mammal : Animal
    {
        private string Description = "Mammal";

        public override string GetDescription()
        {
            return "Description is: " + Description;
        }
        public override string Eat()
        {
            return "Mammals eat various food";
        }

        public override string Move()
        {
            return "Mammals move by walking";
        }
    }
}
