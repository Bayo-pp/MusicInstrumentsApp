using System;

namespace MusicInstrumentsApp.Domain.Entities;
public class Comment : Entity
{
    public string Content { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public int InstrumentId { get; set; }
    public DateTime CreatedAt { get; set; }
    public Instrument? Instrument { get; set; }
}