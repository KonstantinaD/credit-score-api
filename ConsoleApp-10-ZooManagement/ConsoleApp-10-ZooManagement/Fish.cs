namespace ConsoleApp_10_ZooManagement
{
    class Fish : Animal
    {
        private string Description = "Fish";

        public override string GetDescription()
        {
            return "Description is: " + Description;
        }
        public override string Eat()
        {
            return "Fish eat flies";
        }

        public override string Move()
        {
            return "Fish move by swimming";
        }
    }
}
