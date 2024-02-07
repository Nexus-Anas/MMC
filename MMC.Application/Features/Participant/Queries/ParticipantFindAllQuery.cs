using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Participant.Queries;

public record ParticipantFindAllQuery : IRequest<IEnumerable<ParticipantGetDTO>>;