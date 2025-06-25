using System.Collections.Generic;

namespace MusicInstrumentsApp.Domain.Entities;
public class Manufacturer : Entity, IAggregateRoot
{
    public string? Name { get; set; }
    public string? Country { get; set; }
    public List<Instrument> Instruments { get; set; } = new List<Instrument>();
}