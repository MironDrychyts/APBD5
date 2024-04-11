namespace Tutorial4.Endpoints;

public static class VisitMappings
{
    public static void MapVisitEndpoints(this WebApplication app)
    {
        app.MapGet("/visits-minimalApi", () =>
        {
            return Results.Ok();
        });
    }
}