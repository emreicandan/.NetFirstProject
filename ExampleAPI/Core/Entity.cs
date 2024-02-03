using System;
namespace ExampleAPI.Core;

public abstract class Entity
{

}

public class Entity<PKey> : Entity
{
    public PKey Id { get; set; }
}

