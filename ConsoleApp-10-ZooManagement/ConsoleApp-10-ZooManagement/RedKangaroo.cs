namespace ConsoleApp_10_ZooManagement
{
    class RedKangaroo : Mammal
    {
        private string Description = "Red Kangaroo";

        public override string GetDescription()
        {
            return "Description is: " + Description;
        }

        public override string Eat()
        {
            return "Kangaroos eat grass";
        }

        public override string Move()
        {
            return "Kangaroos move by jumping";
        }
    }
}
