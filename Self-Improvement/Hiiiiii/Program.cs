using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var personGroup = app.MapGroup("/api/person");
var person = new Person("yal");
personGroup.MapGet("", () => new Person[] {person});
personGroup.MapGet("{id:int}", (int id) => person);

app.Run();

public class Person
{
    public Person(string name)
    {
        Name = name;
    }
    public string Name { get; init; }
}