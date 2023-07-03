using Quize.DAL.Models;
using Quize.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quize.BAL.Services
{
    public class ExamService : IExamService
    {
        private readonly IGenericRepository<Exame> IExamRepository;
        public ExamService(IGenericRepository<Exame> IExamRepository)
        {
            this.IExamRepository = IExamRepository;
        }
        public void Delete(int id)
        {
            IExamRepository.Delete(id);
            IExamRepository.Save();
        }

        public IEnumerable<Exame> GetAll()
        {
            return IExamRepository.GetAll();
        }

        public Exame GetById(int id)
        {
            return IExamRepository.GetById(id);

        }

        public Exame GetByIdAsNoTracking(int id)
        {
            return IExamRepository.GetByIdAsNoTracking(id);
        }

        public void Insert(Exame exam)
        {
            IExamRepository.Insert(exam);
            IExamRepository.Save();
        }

        public void Update(Exame exam)
        {
            IExamRepository.Update(exam);
            IExamRepository.Save();
        }
    }
}
