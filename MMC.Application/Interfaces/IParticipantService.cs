using MMC.Domain.DTOs;

namespace MMC.Application.Interfaces;

public interface IParticipantService
{
    Task<ParticipantGetDTO> FindAsync(Guid id);
    Task<IEnumerable<ParticipantGetDTO>> FindAllAsync();
    Task<ParticipantGetDTO> CreateAsync(ParticipantPostDTO participantPostDTO);
    Task<ParticipantGetDTO> UpdateAsync(ParticipantPutDTO participantPutDTO);
    Task<bool> DeleteAsync(Guid id);
}