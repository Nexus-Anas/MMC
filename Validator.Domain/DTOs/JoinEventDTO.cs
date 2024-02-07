namespace Validator.Domain.DTOs;

public record JoinEventGetDTO(int Id, Guid ParticipantId, Guid EventId, DateTime ParticipationDate, bool IsApproved);
public record JoinEventPostDTO(Guid ParticipantId, Guid EventId);
public record JoinEventPutDTO(int Id, Guid ParticipantId, Guid EventId, DateTime ParticipationDate, bool IsApproved);