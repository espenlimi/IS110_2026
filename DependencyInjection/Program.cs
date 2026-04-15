using DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//https://learn.microsoft.com/en-us/dotnet/core/extensions/generic-host?tabs=appbuilder

Console.WriteLine("Hello, World!");
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<StudentProgram>();
builder.Services.AddLogging();
//Putter avhengigheten i "sekken"
builder.Services.AddSingleton<IStudentStorage, StudentStorage>();


IHost host = builder.Build();
host.Run();

