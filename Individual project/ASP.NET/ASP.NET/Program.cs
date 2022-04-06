using ASP.NET.Pages;
using ClassLibrary.Logic;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
    options =>
    {
        options.LoginPath = new PathString("/Index");
        options.AccessDeniedPath = new PathString("/Index");
    });

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<UserViewManager>();
builder.Services.AddSingleton<UserManager>();
builder.Services.AddSingleton<QuestionManager>();
builder.Services.AddSingleton<AnswerManager>();
builder.Services.AddSingleton<ProgramManager>();
builder.Services.AddSingleton<AnswerStatisticManager>();
builder.Services.AddSingleton<TrainigProgram>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapRazorPages();
});

app.MapRazorPages();

app.Run();
