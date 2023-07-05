



using PropertyTypes;

AddressModel address = new AddressModel();
address.StreetAddress = "ABC";
address.City = "Casa";
address.State = "Casablanca";
address.ZipCode = "20120";

Console.WriteLine(address.FullAddress);