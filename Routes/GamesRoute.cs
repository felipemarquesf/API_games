namespace Games.Routes;
using Games.Models;
using Games.Data;
using Microsoft.EntityFrameworkCore;

public static class GamesRoute{
    public static void GamesRoutes(this WebApplication app)
    {
        var route = app.MapGroup("games");
        route.MapPost("", async (GamesRequest req, GamesContext context) =>
        {
            var game = new GamesModel(req.nomeDoJogo ,req.nomeDaEmpresa ,req.estiloDoJogo,req.situacao);
            await context.AddAsync(game);
            await context.SaveChangesAsync();
        });

        route.MapGet("", async (GamesContext context) =>
        {
            var games = await context.Game.ToListAsync();
            return Results.Ok(games);
        });

        route.MapGet("{id:guid}", async (Guid id,GamesContext context) =>
        {
            var game = await context.Game.FirstOrDefaultAsync(x => x.Id == id);

            return Results.Ok(game);
        });

        route.MapPut("{id:guid}", 
        async (Guid id, GamesRequest req, GamesContext context) =>
        {
            var game = await context.Game.FirstOrDefaultAsync(x => x.Id == id);

            if(game == null)
                return Results.NotFound();

            game.ChangeName(req.nomeDoJogo,req.nomeDaEmpresa,req.estiloDoJogo,req.situacao);
            await context.SaveChangesAsync();
            return Results.Ok(game);

        });
        route.MapDelete("{id:guid}", async (Guid id, GamesContext context) =>
        {
            
            var game = await context.Game.FirstOrDefaultAsync(x => x.Id == id);

            if (game == null)
                return Results.NotFound($"Game com Id {id} não encontrado.");

            context.Game.Remove(game);
            await context.SaveChangesAsync();
            var gamesAtualizados = await context.Game.ToListAsync();

            return Results.Ok(gamesAtualizados);
        });
    }

}