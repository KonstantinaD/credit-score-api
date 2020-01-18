namespace ConsoleApp_10_ZooManagement
{
    class Bird : Animal
    {
        private string Description = "Bird";

        public override string GetDescription()
        {
            return "Description is: " + Description;
        }

        public override string Eat()
        {
            return "Birds eat seeds";
        }

        public override string Move()
        {
            return "Birds move by flying";
        }
    }
}
