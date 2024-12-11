namespace SMARTHOMESYSTEM
{

     // ABSTRACT Class SmartDevice
     abstract class SmartDevice
     {

        // TurnOn(): Abstract method that turns on the device. 
        public abstract void TurnOn();


       // TurnOff(): Abstract method that turns off the device.
       public abstract void TurnOff();


        // Concrete Method
        // DeviceStatus(): Prints "Device status checked." 

        public void DeviceStatus()
        {
           Console.WriteLine("\nDevice status checked."); 
        }

     }

}
