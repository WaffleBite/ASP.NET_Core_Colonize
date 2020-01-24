using System;

namespace Colonize.Website.Data.Entities
{
    public class Voyage
    {
        public int Id { get; protected set; }
        public Destination Destination { get; protected set; }
        public Ship Ship { get; protected set; }
        public DateTime DepartureAt { get; protected set; }
        public DateTime ArrivalAt { get; protected set; }
        public int DestinationId { get; protected set; }
        public int ShipId { get; protected set; }

        public Voyage(int destinationId, int shipId, DateTime departureAt, DateTime arrivalAt)
        {
            DestinationId = destinationId;
            ShipId = shipId;
            DepartureAt = departureAt;
            ArrivalAt = arrivalAt;
        }

        public Voyage(int id, int destinationId, int shipId, DateTime departureAt, DateTime arrivalAt) :
            this(destinationId, shipId, departureAt, arrivalAt)
        {
            Id = id;
        }

        public Voyage(Destination destination, Ship ship, DateTime departureAt, DateTime arrivalAt)
        {
            Destination = destination;
            Ship = ship;
            DepartureAt = departureAt;
            ArrivalAt = arrivalAt;
        }
    }
}
