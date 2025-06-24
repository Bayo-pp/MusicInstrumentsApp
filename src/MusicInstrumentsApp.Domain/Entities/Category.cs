namespace MusicInstrumentsApp.Domain.Entities;
public class Category : Entity, IAggregateRoot
{
    public string Name { get; set; }
    public List<Instrument> Instruments { get; set; } = new List<Instrument>();
}