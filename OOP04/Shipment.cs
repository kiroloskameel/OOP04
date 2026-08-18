using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    public abstract class Shipment
    {
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }
        public DeliveryAddress Destination { get; set; }

        public abstract decimal EstimatedCost { get; }
        public abstract void PrintShipment();

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateWeight(decimal newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            Weight = newWeight + extraPackingWeight;
        }
    }
}
