using MediatR;
using MMC.Application.Features.Partner.Queries;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Participant.Queries;

public class ParticipantFindAllQueryHandler : IRequestHandler<ParticipantFindAllQuery, IEnumerable<ParticipantGetDTO>>
{
    private readonly IUnitOfService _service;
    public ParticipantFindAllQueryHandler(IUnitOfService service) => _service = service;




    public async Task<IEnumerable<ParticipantGetDTO>> Handle(ParticipantFindAllQuery request, CancellationToken cancellationToken)
    {
        var participant = await _service.ParticipantService.FindAllAsync();
        return participant;
    }
}