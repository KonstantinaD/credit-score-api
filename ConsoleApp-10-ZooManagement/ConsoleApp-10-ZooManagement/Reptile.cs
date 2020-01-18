namespace ConsoleApp_10_ZooManagement
{
    class Reptile : Animal
    {
        private string Description = "Reptile";

        public override string GetDescription()
        {
            return "Description is: " + Description;
        }

        public override string Eat()
        {
            return "Reptiles eat insects";
        }

        public override string Move()
        {
            return "Reptiles move by crawling";
        }
    }
}
