var builder = DistributedApplication.CreateBuilder(args);


var postgres = builder.AddPostgres("postgres")
    .WithDataVolume()
    .AddDatabase("CinePick-db");

var cache = builder.AddRedis("cache");


var apiService = builder.AddProject<Projects.CinePick_ApiService>("apiservice")
    .WithHttpHealthCheck("/health")
    .WithReference(postgres)
    .WithReference(cache)
    .WaitFor(postgres)
    .WaitFor(cache);


builder.AddProject<Projects.CinePick_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();