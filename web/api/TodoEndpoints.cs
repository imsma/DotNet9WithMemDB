using System;
using DotNet9WithMemDB.DB;
using DotNet9WithMemDB.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet9WithMemDB.web.api;

public static class TodoEndpoints
{
    public static void MapToDoEndpoints(this IEndpointRouteBuilder app) {
        app.MapGet("/todos", GetAllToDos);
        app.MapGet("/todos/{id}", GetToDoById);
        app.MapPost("/todos", CreateToDo);
        app.MapPut("/todos/{id}", UpdateToDo);
        app.MapDelete("/todos/{id}", DeleteToDo);
        
    }
    

    private static async Task<IResult> GetAllToDos(ToDoDb db)
    {
        return Results.Ok(await db.ToDos.ToListAsync());
    }

    private static async Task<IResult> GetToDoById(int id, ToDoDb db) {
        var todo = await db.ToDos.FindAsync(id);
        return (todo is ToDo) ? Results.Ok(todo) : Results.NotFound();
    }

    private static async Task<IResult> CreateToDo(ToDo toDo, ToDoDb db) {
        db.ToDos.Add(toDo);
        await db.SaveChangesAsync();
        return Results.Created($"/todos/{toDo.Id}", toDo);
    }

    private static async Task<IResult> UpdateToDo(int id, ToDo updatedToDo, ToDoDb db) {
        var todo = await db.ToDos.FindAsync(id);
        if (todo is null) return Results.NotFound();

        todo.Title = updatedToDo.Title;
        todo.Description = updatedToDo.Description;
        await db.SaveChangesAsync();

        return Results.NoContent(); 
    }

    private static async Task<IResult> DeleteToDo(int id, ToDoDb db) {
        var todo = await db.ToDos.FindAsync(id);
        if (todo is null) return Results.NotFound();
        db.ToDos.Remove(todo); 
        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    
}
