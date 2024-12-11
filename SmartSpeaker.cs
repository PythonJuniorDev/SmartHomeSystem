namespace SMARTHOMESYSTEM
{
    
    // SmartSpeaker class inheriting from SmartDevice and IAdjustable
    class SmartSpeaker : SmartDevice, IAdjustable
    {

        // Overriding the TurnOn method of the SmartDevice class
        public override void TurnOn()
        {
            Console.WriteLine("\nSmart speaker is now on.");
        }

        // Overriding the TurnOff method of the SmartDevice class
        public override void TurnOff()
        {
            Console.WriteLine("\nSmart speaker is now off");
        }

        // Implementing the Adjustlevel method from the interface IAdjustable (not obligated)
        public void AdjustLevel(int level)
        {   
            Console.WriteLine($"\nVolume set to {level}.");
        }


    }
}
