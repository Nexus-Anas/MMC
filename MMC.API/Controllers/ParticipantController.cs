using Microsoft.AspNetCore.Mvc;
using MMC.Application.Features.Participant.Queries;
using MMC.Application.Features.Participant.Commands;

namespace MMC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ParticipantController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> FindAll()
    {
        var participant = await Mediator.Send(new ParticipantFindAllQuery());
        return Ok(participant);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Find(Guid id)
    {
        var participant = await Mediator.Send(new ParticipantFindQuery(id));
        return participant is null ? NotFound() : Ok(participant);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ParticipantCreateCmd cmd)
    {
        var participant = await Mediator.Send(cmd);
        return CreatedAtAction(nameof(Find), new { id = participant.Id }, participant);
    }

    [HttpPut]
    public async Task<IActionResult> Update(ParticipantUpdateCmd cmd)
    {
        var participant = await Mediator.Send(cmd);
        return Ok(participant);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var success = await Mediator.Send(new ParticipantDeleteCmd(id));
        return success ? Ok(success) : NotFound();
    }
}