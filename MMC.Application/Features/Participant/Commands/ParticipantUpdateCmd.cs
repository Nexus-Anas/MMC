using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Participant.Commands;

public record ParticipantUpdateCmd
(
    Guid Id,
    string Firstname,
    string Lastname,
    string Email,
    string Phone,
    char Gender,
    int CityId
) : IRequest<ParticipantGetDTO>;