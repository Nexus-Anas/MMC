namespace MMC.Domain.DTOs;

public record ParticipantGetDTO(Guid Id, string Firstname, string Lastname, string Email, string Phone, char Gender, int CityId);
public record ParticipantPostDTO(string Firstname, string Lastname, string Email, string Phone, char Gender, int CityId);
public record ParticipantPutDTO(Guid Id, string Firstname, string Lastname, string Email, string Phone, char Gender, int CityId);