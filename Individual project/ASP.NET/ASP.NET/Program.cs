using ASP.NET.Pages;
using DAL.DB;
using Logic.IDb;
using Logic.Interfaces;
using Logic.Managers;
using Logic.Models;
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
builder.Services.AddSingleton<ExerciseManager>();
builder.Services.AddSingleton<ProgramManager>();
builder.Services.AddSingleton<AnswerStatisticManager>();


builder.Services.AddTransient<IDbQuestions, DbQuestions>();
builder.Services.AddTransient<IQuestionDb, QuestionManager>();
builder.Services.AddTransient<IAnswerDb ,AnswerManager>();
builder.Services.AddTransient<IDbAnswers, DbAnswers>();
builder.Services.AddTransient<IExerciseDb, ExerciseManager>();
builder.Services.AddTransient<IDbExercises, DbExercises>();
builder.Services.AddTransient<IProgramDb, ProgramManager>();
builder.Services.AddTransient<IDbPrograms, DbPrograms>();
builder.Services.AddTransient<IProgramTypeDb, ProgramTypeManager>();
builder.Services.AddTransient<IDbProgramType, DbProgramType>();
builder.Services.AddTransient<IScoreDb, ScoreManager>();
builder.Services.AddTransient<IDbQuestionOptionScore, DbQuestionOptionScore>();
builder.Services.AddTransient<IQuestionViewDb, QuestionViewManager>();
builder.Services.AddTransient<IDbQuestionView, DbQuestionView>();
builder.Services.AddTransient<IUserDb, UserManager>();
builder.Services.AddTransient<IDbUsers, DbUsers>();
builder.Services.AddTransient<IUserViewDb, UserViewManager>();
builder.Services.AddTransient<IDbUserView, DbUserView>();
builder.Services.AddTransient<IAnswerStatisticDb, AnswerStatisticManager>();
builder.Services.AddTransient<IDbAnswersStatistics, DbAnswersStatistics>();




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
