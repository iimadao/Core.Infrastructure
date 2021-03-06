﻿using AutoMapper;
using Core.Infrastructure.Application.Contract.DTO.RefType;
using Core.Infrastructure.Domain.Aggregate.RefTypeValue;

namespace Core.Infrastructure.Presentation.API.Extensions
{
    public static class Mapping
    {
        public static void ConfigureMapping()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<RefType, RefTypeDTO>();
                cfg.CreateMap<AddRefTypeResponseDTO, AddRefTypeRequestDTO>();
            });
        }
    }
}