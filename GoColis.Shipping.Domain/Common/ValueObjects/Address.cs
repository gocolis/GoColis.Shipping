namespace GoColis.Shipping.Domain.Common.ValueObjects;
public class Address
    {
        public Address(string street, string city, string state, string postalCode, string country)
        {
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }

        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string PostalCode { get; }
        public string Country { get; }

    public override string ToString() => $"{Street}, {City}, {State} {PostalCode}, {Country}";
}