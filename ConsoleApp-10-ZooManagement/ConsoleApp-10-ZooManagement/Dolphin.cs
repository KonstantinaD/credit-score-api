namespace ConsoleApp_10_ZooManagement
{
    class Dolphin : Fish
    {
        private string Description = "Dolphin";

        public override string GetDescription()
        {
            return "Description is: " + Description;
        }
    }
}
