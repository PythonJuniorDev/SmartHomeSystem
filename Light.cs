namespace SMARTHOMESYSTEM
{
    
    // Light class inheriting from SmartDevice and IAdjustable
    class Light : SmartDevice, IAdjustable
    {
        // Overriding the TurnOn method of the SmartDevice class
        public override void TurnOn()
        {
            Console.WriteLine("\nLight is now on.");
        }

        // Overriding the TurnOff method of the SmartDevice class
        public override void TurnOff()
        {
            Console.WriteLine("\nLight is now off");
        }

        // Implementing the Adjustlevel method from the interface IAdjustable (not obligated)
        public void AdjustLevel(int level)
        {   
            Console.WriteLine($"\nLight brightness adjusted to {level}.");
        }


    }

}
