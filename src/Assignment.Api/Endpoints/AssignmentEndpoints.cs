using Assignment.Api.Data;
using Assignment.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Api.Endpoints;

public static class AssignmentEndpoints
{
    public static void MapAssignmentEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/api/assignments")
            .WithTags("Assignments")
            .WithDescription("Handles endpoints for assignments");

        group.MapGet("/", GetAll);
        group.MapGet("/{id}", GetById);
        group.MapPost("/", Create);
        group.MapPut("/{id}", Update);
        group.MapDelete("/{id}", Delete);
    }

    private static async Task<IResult> GetAll(AssignmentDbContext db) =>
        Results.Ok(await db.Assignments.ToListAsync());

    private static async Task<IResult> GetById(int id, AssignmentDbContext db) =>
        await db.Assignments.FindAsync(id) is AssignmentModel assignment
            ? Results.Ok(assignment)
            : Results.NotFound();

    private static async Task<IResult> Create(AssignmentModel assignment, AssignmentDbContext db)
    {
        db.Assignments.Add(assignment);
        await db.SaveChangesAsync();

        return Results.Created($"/api/assignments/{assignment.Id}", assignment);
    }

    private static async Task<IResult> Update(int id, AssignmentModel updated, AssignmentDbContext db)
    {
        var existing = await db.Assignments.FindAsync(id);
        if (existing is null) return Results.NotFound();

        existing.Name = updated.Name;
        existing.Level = updated.Level;
        existing.Hours = updated.Hours;
        existing.Status = updated.Status;

        await db.SaveChangesAsync();
        return Results.Ok(existing);
    }

    private static async Task<IResult> Delete(int id, AssignmentDbContext db)
    {
        var existing = await db.Assignments.FindAsync(id);
        if (existing is null) return Results.NotFound();

        db.Assignments.Remove(existing);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }
}
