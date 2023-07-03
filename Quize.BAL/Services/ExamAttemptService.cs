using Quize.DAL.Models;
using Quize.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quize.BAL.Services
{
    internal class ExamAttemptService : IExamAttemptService
    {
        private readonly IGenericRepository<ExameAttempt> IExamAttemptRepository;
        public ExamAttemptService(IGenericRepository<ExameAttempt> IExamAttemptRepository)
        {
            this.IExamAttemptRepository = IExamAttemptRepository;
        }
        public void Delete(int id)
        {
            IExamAttemptRepository.Delete(id);
            IExamAttemptRepository.Save(); throw new NotImplementedException();
        }

        public IEnumerable<ExameAttempt> GetAll()
        {
            return IExamAttemptRepository.GetAll();
        }

        public ExameAttempt GetById(int id)
        {
            return IExamAttemptRepository.GetById(id);
        }

        public ExameAttempt GetByIdAsNoTracking(int id)
        {
            return IExamAttemptRepository.GetByIdAsNoTracking(id);
        }

        public void Insert(ExameAttempt exameAttempt)
        {
            IExamAttemptRepository.Insert(exameAttempt);
            IExamAttemptRepository.Save();
        }

        public void Update(ExameAttempt exameAttempt)
        {
            IExamAttemptRepository.Update(exameAttempt);
            IExamAttemptRepository.Save();
        }
    }
}
