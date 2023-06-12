using AutoMapper;
using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Domain.Models;

namespace EstoqueApp.Application.Profiles;

public class CommandToModelProfile : Profile
{
    public CommandToModelProfile()
    {
        CreateMap<EstoqueCreateCommand, Estoque>()
            .AfterMap((command, model) =>
            {
                model.Id = Guid.NewGuid();
            });

        CreateMap<ProdutoCreateCommand, Produto>()
            .AfterMap((command, model) =>
            {
                model.Id = Guid.NewGuid();
            });
    }
}
