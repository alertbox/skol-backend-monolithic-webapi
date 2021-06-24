using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatR.Pipeline;
using Skol.Application.Cocktails.Commands;
using Skol.Domain.Models;

namespace Skol.Application.Cocktails.Triggers
{
    public class RebrandCocktailPostHandler : IRequestPostProcessor<RebrandCocktail, Cocktail>
    {
        private readonly ISender mediator;

        public RebrandCocktailPostHandler(ISender sender) => mediator = sender;

        public async Task Process(RebrandCocktail request, Cocktail response, CancellationToken cancellationToken = default)
        {
            Console.WriteLine($"Post rebrand triggered: {DateTime.UtcNow}");

            if (request.DiscontinueOrigin)
            {
                await mediator.Send(new DiscontinueCocktail(request.OriginCode), cancellationToken);
            }

            await Task.CompletedTask;
        }
    }
}