using Quize.DAL.Models;
using Quize.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quize.BAL.Services
{
    public class QuestionService:IQuestionsService
    {
        private readonly IGenericRepository<Questions> IQuestionRepository;
        public QuestionService(IGenericRepository<Questions> IQuestionRepository)
        {
            this.IQuestionRepository = IQuestionRepository;
        }
        public void Delete(int id)
        {
            IQuestionRepository.Delete(id);
            IQuestionRepository.Save();

        }

        public IEnumerable<Questions> GetAll()
        {
            return IQuestionRepository.GetAll();
        }

        public Questions GetById(int id)
        {
            return IQuestionRepository.GetById(id);
        }

        public Questions GetByIdAsNoTracking(int id)
        {
            return IQuestionRepository.GetByIdAsNoTracking(id);
        }

        public void Insert(Questions questions)
        {
            IQuestionRepository.Insert(questions);
            IQuestionRepository.Save();
        }

        public void Update(Questions questions)
        {
            IQuestionRepository.Update(questions);
            IQuestionRepository.Save();
        }
    }
}
