namespace ConsoleApp_10_ZooManagement
{
    class GoldenEagle : Bird
    {
        private string Description = "Golden Eagle";

        public override string GetDescription()
        {
            return "Description is: " + Description;
        }
    }
}
