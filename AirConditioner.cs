namespace SMARTHOMESYSTEM
{
    
    // AirConditioner class inheriting from SmartDevice and IAdjustable
    class AirConditioner : SmartDevice, IAdjustable
    {
        // Overriding the TurnOn method of the SmartDevice class
        public override void TurnOn()
        {
            Console.WriteLine("\nAir conditioner is now on.");
        }

        // Overriding the TurnOff method of the SmartDevice class
        public override void TurnOff()
        {
            Console.WriteLine("\nAir conditioner is now off");
        }

        // Implementing the Adjustlevel method from the interface IAdjustable (not obligated)
        public void AdjustLevel(int level)
        {   
            Console.WriteLine($"\nCooling level set to {level}.");
        }


    }

    
}