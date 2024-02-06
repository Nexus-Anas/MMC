namespace MMC.WEB.Entities;

public class JoinEvent
{
    public int Id { get; set; }
    public int ParticipantId { get; set; }
    public int EventId { get; set; }
    public DateTime ParticipationDate { get; set; }
    public bool IsApproved { get; set; }
}