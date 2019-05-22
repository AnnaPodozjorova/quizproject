using TestApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.DataAccess
{
    public class ITestRepository : IRepository<Answer>
    {
        Answer GetAnswerByID(int id);
        IQueryable<Answer> GetAnswerByQuestion(string question);
    }
}
