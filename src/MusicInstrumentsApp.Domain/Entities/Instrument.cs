using System.Collections.Generic;

namespace MusicInstrumentsApp.Domain.Entities;
public class Instrument : Entity, IAggregateRoot
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public int ReleaseYear { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public int ManufacturerId { get; set; }
    public Manufacturer? Manufacturer { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
}