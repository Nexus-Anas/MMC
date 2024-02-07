using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Participant.Queries;

public class ParticipantFindQueryHandler : IRequestHandler<ParticipantFindQuery, ParticipantGetDTO>
{
    private readonly IUnitOfService _service;
    public ParticipantFindQueryHandler(IUnitOfService service) => _service = service;




    public async Task<ParticipantGetDTO> Handle(ParticipantFindQuery request, CancellationToken cancellationToken)
    {
        var participant = await _service.ParticipantService.FindAsync(request.Id);
        return participant;
    }
}