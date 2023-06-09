﻿using AutoMapper;
using EstoqueApp.Application.Models.Queries;
using EstoqueApp.Domain.Models;

namespace EstoqueApp.Application.Profiles;

public class ModelToQueryProfile : Profile
{
    public ModelToQueryProfile()
    {
        CreateMap<Estoque, EstoqueQuery>()
            .AfterMap((model, query) =>
            {
                query.DataHoraCriacao = DateTime.UtcNow;
            });

        CreateMap<Produto, ProdutoQuery>()
            .AfterMap((model, query) =>
            {
                query.DataHoraCriacao = DateTime.UtcNow;
            });
    }
}
