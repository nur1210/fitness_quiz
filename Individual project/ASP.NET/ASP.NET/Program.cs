using DAL.DB;
using Logic.IDb;
using Logic.Managers;
using Logic.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebApp.Pages.Account;

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
builder.Services.AddSingleton<ExerciseManager>();
builder.Services.AddSingleton<ProgramManager>();
builder.Services.AddSingleton<AnswerStatisticManager>();
builder.Services.AddSingleton<ScoreManager>();
builder.Services.AddSingleton<ProgramTypeManager>();
builder.Services.AddSingleton<QuestionViewManager>();
builder.Services.AddSingleton<Validation>();

builder.Services.AddSingleton<IDbQuestions, DbQuestions>();
builder.Services.AddSingleton<IDbAnswers, DbAnswers>();
builder.Services.AddSingleton<IDbExercises, DbExercises>();
builder.Services.AddSingleton<IDbPrograms, DbPrograms>();
builder.Services.AddSingleton<IDbProgramType, DbProgramType>();
builder.Services.AddSingleton<IDbQuestionOptionScore, DbQuestionOptionScore>();
builder.Services.AddSingleton<IDbQuestionView, DbQuestionView>();
builder.Services.AddSingleton<IDbUsers, DbUsers>();
builder.Services.AddSingleton<IDbUserView, DbUserView>();
builder.Services.AddSingleton<IDbAnswersStatistics, DbAnswersStatistics>();


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
