using MediatR;
using MMC.Application.Features.Partner.Commands;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Participant.Commands;

public class ParticipantUpdateCmdHandler : IRequestHandler<ParticipantUpdateCmd, ParticipantGetDTO>
{
    private readonly IUnitOfService _service;
    public ParticipantUpdateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<ParticipantGetDTO> Handle(ParticipantUpdateCmd request, CancellationToken cancellationToken)
    {
        var participantPutDTO = new ParticipantPutDTO
        (
            request.Id,
            request.Firstname,
            request.Lastname,
            request.Email,
            request.Phone,
            request.Gender,
            request.CityId
        );
        var participant = await _service.ParticipantService.UpdateAsync(participantPutDTO);
        return participant;
    }
}