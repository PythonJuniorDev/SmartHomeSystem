namespace SMARTHOMESYSTEM
{
    class Program
    {

        static void Main()
        {
            // List containing different smart devices: light, airconditioner & smart speaker
            List<SmartDevice> smartDevicesList = new();

            // Creating instances from SmartDevice subclasses
            Light light1 = new();
            AirConditioner airConditioner1 = new();
            SmartSpeaker smartSpeaker1 = new();

            // Adding all the instances to the smartDevicesList
            smartDevicesList.Add(light1);
            smartDevicesList.Add(airConditioner1);
            smartDevicesList.Add(smartSpeaker1);


            // Looping through the list of smart devices
            foreach (SmartDevice smartDevice in smartDevicesList)
            {
                // Display the device status
                smartDevice.DeviceStatus();

                // Turn the device on
                smartDevice.TurnOn();

                // Turn the device off
                smartDevice.TurnOff();

                // Check if the device supports the IAdjustable interface
                if (smartDevice is IAdjustable adjustableDevice)
                {
                    // Adjust the device's level to 50
                    adjustableDevice.AdjustLevel(50);
                }
                else
                {
                    // Inform that the device does not support adjustments
                    Console.WriteLine("This device does not support adjustments.");
                }
            }




        }

    }
}       
