﻿namespace MMC.WEB.Entities;

public class EventPartner
{
    public Guid EventId { get;  set; }
    public Event Event { get; set; }

    public Guid PartnerId { get; set; }
    public Partner Partner { get; set; }
}