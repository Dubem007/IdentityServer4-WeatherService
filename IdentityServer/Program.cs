using IdentityServer.IdentityConfiguration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddIdentityServer()
        .AddInMemoryClients(Clients.Get())
        .AddInMemoryIdentityResources(Resources.GetIdentityResources())
        .AddInMemoryApiResources(Resources.GetApiResources())
        .AddInMemoryApiScopes(Scopes.GetApiScopes())
        .AddTestUsers(Users.Get())
        .AddDeveloperSigningCredential();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseIdentityServer();
app.UseAuthorization();
app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());

//app.MapGet("/", () => "Hello World!");

app.Run();
