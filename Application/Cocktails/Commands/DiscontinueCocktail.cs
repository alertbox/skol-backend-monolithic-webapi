using MediatR;
using Skol.Domain.Models;

namespace Skol.Application.Cocktails.Commands
{
    public record DiscontinueCocktail(string Code) : IRequest<Cocktail>;
}