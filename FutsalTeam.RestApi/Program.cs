using Cantracts;
using FutsalTeam.Persistanc;
using FutsalTeam.Persistanc.Players;
using FutsalTeam.Persistanc.Teams;
using FutsalTeam.Services.Players;
using FutsalTeam.Services.Players.Cantarcts;
using FutsalTeam.Services.Teams;
using FutsalTeam.Services.Teams.Catnract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EFDataContext>();
builder.Services.AddScoped<TeamRepository, EFTeamRepository>();
builder.Services.AddScoped<TeamService, TeamAppService>();
builder.Services.AddScoped<PlayerRepository, EFPlayersRepository>();
builder.Services.AddScoped<PlayersServices, PlayerAppService>();
builder.Services.AddScoped<UnitOfWork, EFUnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
