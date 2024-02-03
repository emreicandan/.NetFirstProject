using System;
using ExampleAPI.Core;

namespace ExampleAPI.Entities;
#nullable disable

public class User : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string BirthYear { get; set; }
    public short IdentificationNumber { get; set; }
}