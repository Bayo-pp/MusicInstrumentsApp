namespace MusicInstrumentsApp.Domain.Entities;
public class Instrument : Entity, IAggregateRoot
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int ReleaseYear { get; set; }
    public Category Category { get; set; }
    public Manufacturer Manufacturer { get; set; }
}