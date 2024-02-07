﻿using AutoMapper;
using MMC.Domain.DTOs;
using MMC.Domain.Entities;

namespace MMC.Application.Mapping;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        //City Mapping
        CreateMap<City, CityGetDTO>();
        CreateMap<CityPostDTO, City>();
        CreateMap<CityPutDTO, City>();

        //Event Mapping
        CreateMap<Event, EventGetDTO>();
        CreateMap<EventPostDTO, Event>();
        CreateMap<EventPutDTO, Event>();

        //Mode Mapping
        CreateMap<Mode, ModeGetDTO>();
        CreateMap<ModePostDTO, Mode>();
        CreateMap<ModePutDTO, Mode>();

        //Participant Mapping
        CreateMap<Participant, ParticipantGetDTO>();
        CreateMap<ParticipantPostDTO, Participant>();
        CreateMap<ParticipantPutDTO, Participant>();

        //Partner Mapping
        CreateMap<Partner, PartnerGetDTO>();
        CreateMap<PartnerPostDTO, Partner>();
        CreateMap<PartnerPutDTO, Partner>();

        //Session Mapping
        CreateMap<Session, SessionGetDTO>();
        CreateMap<SessionPostDTO, Session>();
        CreateMap<SessionPutDTO, Session>();

        //Speaker Mapping
        CreateMap<Speaker, SpeakerGetDTO>();
        CreateMap<SpeakerPostDTO, Speaker>();
        CreateMap<SpeakerPutDTO, Speaker>();

        //Sponsor Mapping
        CreateMap<Sponsor, SponsorGetDTO>();
        CreateMap<SponsorPostDTO, Sponsor>();
        CreateMap<SponsorPutDTO, Sponsor>();

        //Theme Mapping
        CreateMap<Theme, ThemeGetDTO>();
        CreateMap<ThemePostDTO, Theme>();
        CreateMap<ThemePutDTO, Theme>();

        //User Mapping
        CreateMap<User, UserGetDTO>();
    }
}