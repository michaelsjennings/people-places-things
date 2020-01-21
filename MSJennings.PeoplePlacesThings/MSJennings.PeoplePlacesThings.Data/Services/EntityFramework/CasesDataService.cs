using Microsoft.EntityFrameworkCore;
using MSJennings.PeoplePlacesThings.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MSJennings.PeoplePlacesThings.Data.Services.EntityFramework
{
    public class CasesDataService : ICasesDataService
    {
        #region Private Fields

        private readonly AppDbContext _context;

        #endregion Private Fields

        #region Public Constructors

        public CasesDataService(AppDbContext context)
        {
            _context = context;
        }

        #endregion Public Constructors

        #region Public Methods

        public int CreateCase(Case @case)
        {
            if (@case is null)
            {
                throw new ArgumentNullException(nameof(@case));
            }

            _context.Add(@case);
            _context.SaveChanges();

            return @case.Id;
        }

        public async Task<int> CreateCaseAsync(Case @case)
        {
            if (@case is null)
            {
                throw new ArgumentNullException(nameof(@case));
            }

            _context.Add(@case);
            await _context.SaveChangesAsync().ConfigureAwait(false);

            return @case.Id;
        }

        public bool DeleteCase(int caseId)
        {
            var @case = RetrieveCase(caseId);

            if (@case is null)
            {
                return false;
            }

            _context.Remove(@case);
            _context.SaveChanges();

            return true;
        }

        public async Task<bool> DeleteCaseAsync(int caseId)
        {
            var @case = await RetrieveCaseAsync(caseId).ConfigureAwait(false);

            if (@case is null)
            {
                return false;
            }

            _context.Remove(@case);
            await _context.SaveChangesAsync().ConfigureAwait(false);

            return true;
        }

        public Case RetrieveCase(int caseId)
        {
            return _context.Cases.SingleOrDefault(x => x.Id == caseId);
        }

        public async Task<Case> RetrieveCaseAsync(int caseId)
        {
            return await _context.Cases.SingleOrDefaultAsync(x => x.Id == caseId).ConfigureAwait(false);
        }

        public IList<Case> RetrieveCases()
        {
            return _context.Cases.ToList();
        }

        public IList<Case> RetrieveCases(Expression<Func<Case, bool>> predicate)
        {
            return _context.Cases.Where(predicate).ToList();
        }

        public async Task<IList<Case>> RetrieveCasesAsync()
        {
            return await _context.Cases.ToListAsync().ConfigureAwait(false);
        }

        public async Task<IList<Case>> RetrieveCasesAsync(Expression<Func<Case, bool>> predicate)
        {
            return await _context.Cases.Where(predicate).ToListAsync().ConfigureAwait(false);
        }

        public IQueryable<Case> RetrieveCasesQuery()
        {
            return _context.Cases;
        }

        public bool UpdateCase(Case @case)
        {
            if (@case is null)
            {
                throw new ArgumentNullException(nameof(@case));
            }

            if (@case.Id == default)
            {
                throw new InvalidOperationException($"Cannot update {nameof(Case)} with no {nameof(Case.Id)}");
            }

            _context.Update(@case);
            return _context.SaveChanges() > 0;
        }

        public async Task<bool> UpdateCaseAsync(Case @case)
        {
            if (@case is null)
            {
                throw new ArgumentNullException(nameof(@case));
            }

            if (@case.Id == default)
            {
                throw new InvalidOperationException($"Cannot update {nameof(Case)} with no {nameof(Case.Id)}");
            }

            _context.Update(@case);
            return (await _context.SaveChangesAsync().ConfigureAwait(false)) > 0;
        }

        #endregion Public Methods
    }
}