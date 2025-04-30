using Base.Api;
using Base.Application;
using Base.Application.Services.Implementations;
using Base.Infrastructure;
using Hangfire;
using HangfireBasicAuthenticationFilter;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();


builder.Services
    .AddApiExtensions(builder.Configuration)
    .AddApplicationExtensions(builder.Configuration)
    .AddInfrastructureExtensions(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
app.MapOpenApi();
app.MapScalarApiReference();

app.UseHangfireDashboard("/jobs", new DashboardOptions()
{
    Authorization =
    [
        new HangfireCustomBasicAuthenticationFilter
        {
            User  = app.Configuration.GetValue<string>("HangfireSettings:Username"),
            Pass  = app.Configuration.GetValue<string>("HangfireSettings:Password")
        }
    ],
    DashboardTitle = "Base Dashboard",
    // IsReadOnlyFunc = (DashboardContext context) => true

});
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseCors("MyPolicy");

app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();

app.Run();
