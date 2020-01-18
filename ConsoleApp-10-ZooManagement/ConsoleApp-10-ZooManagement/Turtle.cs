namespace ConsoleApp_10_ZooManagement
{
    class Turtle : Reptile
    {
        private string Description = "Turtle";

        public override string GetDescription()
        {
            return "Description is: " + Description;
        }

        public override string Eat()
        {
            return "Turtles eat fruit";
        }

        public override string Move()
        {
            return "Turtles move by walking";
        }
    }
}
