﻿using AutoMapper;
using VaRuta.API.Publishing.Domain;
using VaRuta.API.Publishing.Resources;

namespace VaRuta.API.Publishing.Mapping;

public class ResourceToModelProfile: Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveFeedbackResource, Feedback>();
    }
}