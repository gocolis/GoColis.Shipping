namespace GoColis.Shipping.Domain.Common.ValueObjects;

public record Address(string street, string city, string state, string postalCode, string country);