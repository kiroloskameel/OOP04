using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    public class DeliveryCenter
    {
        public string CenterName { get; set; }
        private Shipment[] _shipments;
        private int _count;

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            _shipments = new Shipment[20];
            _count = 0;
        }

        public bool AddShipment(Shipment shipment)
        {
            if (_count >= 20) return false;
            _shipments[_count] = shipment;
            _count++;
            return true;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine("==========================================");

            for (int i = 0; i < _count; i++)
            {
                _shipments[i].PrintShipment();
                Console.WriteLine("------------------------------------------");
            }
        }

        public void PrintTrackingStatuses()
        {
            for (int i = 0; i < _count; i++)
            {
                if (_shipments[i] is ITrackable trackable)
                {
                    Console.WriteLine(trackable.GetTrackingStatus());
                }
            }
        }
    }
}
