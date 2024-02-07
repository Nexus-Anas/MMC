using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Participant.Commands;

public class ParticipantCreateCmdHandler : IRequestHandler<ParticipantCreateCmd, ParticipantGetDTO>
{
    private readonly IUnitOfService _service;
    public ParticipantCreateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<ParticipantGetDTO> Handle(ParticipantCreateCmd request, CancellationToken cancellationToken)
    {
        var participantPostDTO = new ParticipantPostDTO
        (
            request.Firstname,
            request.Lastname,
            request.Email,
            request.Phone,
            request.Gender,
            request.CityId
        );
        var participant = await _service.ParticipantService.CreateAsync(participantPostDTO);
        return participant;
    }
}