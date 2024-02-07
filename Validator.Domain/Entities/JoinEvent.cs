namespace Validator.Domain.Entities;

public class JoinEvent
{
    public int Id { get; private set; }
    public Guid ParticipantId { get; private set; }
    public Guid EventId { get; private set; }
    public DateTime ParticipationDate { get; private set; }
    public bool IsApproved { get; private set; }

    public JoinEvent(Guid participantId, Guid eventId)
    {
        ParticipantId = participantId;
        EventId = eventId;
        ParticipationDate = DateTime.Now;
        IsApproved = false;
    }

    public void ApproveRequest() => IsApproved = true;
}