using Application;
using Application.DTO;
using Application.UseCases;
using Application.Wrappers;
using HexagonalArchitectureApp.Middleware;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLogging();

//Dependency injection
builder.Services.AddInfrastructure();
builder.Services.AddAplication();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ExceptionMiddleware>();

app.MapPost("/SendEmailMessage", async (SendEmailUseCase sendEmailUseCase, EmailMessageDTO messageDTO) =>
{
    try
    {
        await sendEmailUseCase.ExecuteAsync(messageDTO);
        return Results.Ok(ApiResponse<EmailMessageDTO>.SuccessResponse(messageDTO, "Email has been sent successfully"));
    }
    catch (ArgumentException)
    {
        return Results.BadRequest(ApiResponse<object>.ErrorResponse("Input is bad"));
    }
    
})
.WithName("SendEmailMessage")
.WithOpenApi()
.Accepts<EmailMessageDTO>("application/json");

app.Run();