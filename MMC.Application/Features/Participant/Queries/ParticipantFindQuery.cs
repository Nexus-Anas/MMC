using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Participant.Queries;

public record ParticipantFindQuery(Guid Id) : IRequest<ParticipantGetDTO>;