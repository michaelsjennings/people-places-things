using MSJennings.PeoplePlacesThings.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MSJennings.PeoplePlacesThings.Data.Services
{
    public interface ICasesDataService
    {
        #region Public Methods

        public int CreateCase(Case @case);

        public Task<int> CreateCaseAsync(Case @case);

        public bool DeleteCase(int caseId);

        public Task<bool> DeleteCaseAsync(int caseId);

        public Case RetrieveCase(int caseId);

        public Task<Case> RetrieveCaseAsync(int caseId);

        public IList<Case> RetrieveCases();

        public IList<Case> RetrieveCases(Expression<Func<Case, bool>> predicate);

        public Task<IList<Case>> RetrieveCasesAsync();

        public Task<IList<Case>> RetrieveCasesAsync(Expression<Func<Case, bool>> predicate);

        public IQueryable<Case> RetrieveCasesQuery();

        public bool UpdateCase(Case @case);

        public Task<bool> UpdateCaseAsync(Case @case);

        #endregion Public Methods
    }
}