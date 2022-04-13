using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DAL.DB;
using Logic.Interfaces;
using Logic.Managers;
using MyProject;

namespace WinFormApp
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<QuestionManager>().As<IQuestionDb>();
            builder.RegisterType<DbQuestions>().As<IDbQuestions>();
            builder.RegisterType<QuestionManager>().As<IQuestionDb>();
            builder.RegisterType<AnswerManager>().As<IAnswerDb>();
            builder.RegisterType<DbAnswers>().As<IDbAnswers>();
            builder.RegisterType<ExerciseManager>().As<IExerciseDb>();
            builder.RegisterType<DbExercises>().As<IDbExercises>();
            builder.RegisterType<ProgramManager>().As<IProgramDb>();
            builder.RegisterType<DbPrograms>().As<IDbPrograms>();
            builder.RegisterType<ProgramTypeManager>().As<IProgramTypeDb>();
            builder.RegisterType<DbProgramType>().As<IDbProgramType>();
            builder.RegisterType<ScoreManager>().As<IScoreDb>();
            builder.RegisterType<DbQuestionOptionScore>().As<IDbQuestionOptionScore>();
            builder.RegisterType<QuestionViewManager>().As<IQuestionViewDb>();
            builder.RegisterType<DbQuestionView>().As<IDbQuestionView>();
            builder.RegisterType<UserManager>().As<IUserDb>();
            builder.RegisterType<DbUsers>().As<IDbUsers>();
            builder.RegisterType<UserViewManager>().As<IUserViewDb>();
            builder.RegisterType<DbUserView>().As<IDbUserView>();
            builder.RegisterType<AnswerStatisticManager>().As<IAnswerStatisticDb>();
            builder.RegisterType<DbAnswersStatistics>().As<IDbAnswersStatistics>();
            builder.RegisterType<UserViewManager>().SingleInstance();
            builder.RegisterType<UserManager>().SingleInstance();
            builder.RegisterType<QuestionManager>().AsSelf().SingleInstance();
            builder.RegisterType<AnswerManager>().AsSelf().SingleInstance();
            builder.RegisterType<ExerciseManager>().AsSelf().SingleInstance();
            builder.RegisterType<ProgramManager>().AsSelf().SingleInstance();
            builder.RegisterType<AnswerStatisticManager>().AsSelf().SingleInstance();
            builder.RegisterType<Login>();
            builder.RegisterType<MainForm>();

            return builder.Build();
        }
    }
}
