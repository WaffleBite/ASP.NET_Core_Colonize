using System;

namespace Colonize.Website.Data.Entities
{
    public class Ship
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public ushort PassengerCapacity { get; protected set; }
        public Uri ImageUrl { get; protected set; }

        //public Ship()
        //{

        //}

        public Ship(string name, string description, ushort passengerCapacity, Uri imageUrl)
        {
            Name = name;
            Description = description;
            PassengerCapacity = passengerCapacity;
            ImageUrl = imageUrl;
        }

        public Ship(int id, string name, string description, ushort passengerCapacity, Uri imageUrl) :
            this(name, description, passengerCapacity, imageUrl)
        {
            Id = id;
        }
    }
}