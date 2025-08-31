using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [
    new (
        1,
        "Steet Fighter II",
        "Fighting",
        19.99M,
        new DateOnly(1992, 7, 15)),
    new (
        2,
        "Final Fantasy XIV",
        "Roleplaying",
        59.99M,
        new DateOnly(2023, 6, 15)),
    new (
        3,
        "NHL 25",
        "Sports",
        6.65M,
        new DateOnly(2024, 2, 15))
];

app.MapGet("games", ()=> games);

app.MapGet("/", () => "Hello World!");

app.Run();
