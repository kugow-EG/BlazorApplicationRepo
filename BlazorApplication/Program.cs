using BlazorApplication.Components;
using BlazorApplication.Data.Data;
using BlazorApplication.Mappings;
using BlazorApplication.Repository;
using BlazorApplication.Repository.Interfaces;
using BlazorApplication.Services;
using BlazorApplication.Services.Interfaces;
using BlazorApplication.ViewModel;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<ISignUpService,SignUpService>();
builder.Services.AddScoped<SignUpViewModel>();
builder.Services.AddScoped<ISignUpRepository,SignUpRepository>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<LoginViewModel>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddDbContext<BlazorDBContext>(options =>
	options.UseSqlite("Data Source=C:\\Users\\pohit\\source\\repos\\BlazorApplicationRepo\\BlazorApplication.db/Data.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
