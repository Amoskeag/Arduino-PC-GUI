using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HidLibrary;
using System.Text;

namespace Arduino_Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //COMMENTED OUT BELOW TEXT TO TEST OUT WRITING TO DIAL INDICATOR

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new arduinoInterface());





            HidDevice device = HidDevices.Enumerate().FirstOrDefault(d => d.Attributes.VendorId == 1423 && d.Attributes.ProductId == 37920);

            device.OpenDevice();

            while (true)
            {
                String command = "\r";

                byte[] data = Encoding.ASCII.GetBytes(command);

                device.Write(data);

                Console.WriteLine("Made it");

                System.Threading.Thread.Sleep(3000);

            }

            device.CloseDevice();


        }
    }
}
