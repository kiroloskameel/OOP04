using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    public class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"{shipment.GetType().Name} Insurance : {shipment.CalculateInsurance():0.00} EGP");
        }
    }
}
