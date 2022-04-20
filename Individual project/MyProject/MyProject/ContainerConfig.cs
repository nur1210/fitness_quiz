using Autofac;
using DAL.DB;
using Logic.IDb;
using Logic.Managers;

namespace WinFormApp
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DbQuestions>().As<IDbQuestions>();
            builder.RegisterType<DbAnswers>().As<IDbAnswers>();
            builder.RegisterType<DbExercises>().As<IDbExercises>();
            builder.RegisterType<DbPrograms>().As<IDbPrograms>();
            builder.RegisterType<DbProgramType>().As<IDbProgramType>();
            builder.RegisterType<DbQuestionOptionScore>().As<IDbQuestionOptionScore>();
            builder.RegisterType<DbQuestionView>().As<IDbQuestionView>();
            builder.RegisterType<DbUsers>().As<IDbUsers>();
            builder.RegisterType<DbUserView>().As<IDbUserView>();
            builder.RegisterType<DbAnswersStatistics>().As<IDbAnswersStatistics>();
            builder.RegisterType<DbLogin>().As<IDbLogin>();

            builder.RegisterType<UserViewManager>().AsSelf().SingleInstance();
            builder.RegisterType<UserManager>().AsSelf().SingleInstance();
            builder.RegisterType<QuestionManager>().AsSelf().SingleInstance();
            builder.RegisterType<AnswerManager>().AsSelf().SingleInstance();
            builder.RegisterType<ExerciseManager>().AsSelf().SingleInstance();
            builder.RegisterType<ProgramManager>().AsSelf().SingleInstance();
            builder.RegisterType<AnswerStatisticManager>().AsSelf().SingleInstance();
            builder.RegisterType<ProgramTypeManager>().AsSelf().SingleInstance();
            builder.RegisterType<ScoreManager>().AsSelf().SingleInstance();
            builder.RegisterType<QuestionViewManager>().AsSelf().SingleInstance();
            builder.RegisterType<Validation>().AsSelf().SingleInstance();

            builder.RegisterType<Login>();
            builder.RegisterType<MainForm>();
            builder.RegisterType<AddExercises>();
            builder.RegisterType<AddProgram>();
            builder.RegisterType<AddQuestion>();
            builder.RegisterType<ViewPrograms>();
            builder.RegisterType<ViewQuestions>();
            builder.RegisterType<ViewUsers>();

            return builder.Build();
        }
    }
}
