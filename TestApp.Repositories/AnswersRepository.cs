using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.DataAccess;
using TestApp.Domain.Entities;

namespace TestApp.Persistence
{
    public class AnswersRepository : ITestRepository
    {
        TestAppDbContext context;

        public AnswersRepository(string connectionName)
        {
            context = new TestAppDbContext(connectionName);
        }

        public AnswersRepository()
        {
            context = new TestAppDbContext();
        }

        public AnswersRepository(TestAppDbContext dbContext)
        {
            context = dbContext;
        }

        public Answer GetAnswerByID(int id)
        {
            return GetAll().Where(b => b.AnswerId == id).SingleOrDefault();
        }

        public IQueryable<Answer> GetAll()
        {
            return context.Answers.AsQueryable<Answer>();
        }

        public IQueryable<Answer> FindBy(System.Linq.Expressions.Expression<Func<Answer, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public void Add(Answer entity)
        {
            context.Answers.Add(entity);
        }

        public void Delete(Answer entity)
        {
            context.Answers.Find(entity.AnswerId);
            context.Answers.Remove(entity);
        }

        public void Edit(Domain.Entities.Answer entity)
        {
            var originalEntity = context.Answers.Find(entity.AnswerId);
            context.Entry(originalEntity).CurrentValues.SetValues(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}
