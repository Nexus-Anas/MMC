﻿namespace MMC.Application.Interfaces;

public interface IUnitOfService
{
    ICityService CityService { get; }
    IEventService EventService { get; }
    IModeService ModeService { get; }
    IParticipantService ParticipantService { get; }
    IPartnerService PartnerService { get; }
    ISessionService SessionService { get; }
    ISpeakerService SpeakerService { get; }
    ISponsorService SponsorService { get; }
    IThemeService ThemeService { get; }
    IUserService UserService { get; }
}