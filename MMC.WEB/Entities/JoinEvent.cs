namespace MMC.WEB.Entities;

public class JoinEvent
{
    public int Id { get; set; }
    public Guid ParticipantId { get; set; }
    public Guid EventId { get; set; }
    public DateTime ParticipationDate { get; set; }
    public bool IsApproved { get; set; }
}