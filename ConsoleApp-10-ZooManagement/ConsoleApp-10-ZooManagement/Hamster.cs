namespace ConsoleApp_10_ZooManagement
{
    class Hamster : Mammal
    {
        private string Description = "Hamster";

        public override string GetDescription()
        {
            return "Description is: " + Description;
        }

        public override string Eat()
        {
            return "Hamsters eat seeds";
        }

        public override string Move()
        {
            return "Hamsters move by walking";
        }
    }
}
