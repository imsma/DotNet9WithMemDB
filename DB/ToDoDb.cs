using System;
using DotNet9WithMemDB.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet9WithMemDB.DB;

public class ToDoDb : DbContext
{
    public ToDoDb(DbContextOptions<ToDoDb> options) : base(options) {}

    public DbSet<ToDo> ToDos { get; set; } = null!;

}
