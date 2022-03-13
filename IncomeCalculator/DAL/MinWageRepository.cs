﻿using IncomeCalculator.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncomeCalculator.DAL
{
    public class MinWageRepository : IMinWageRepository
    {
        private BenefitsContext _dbContext;
        public MinWageRepository(BenefitsContext dbContext)
        {
            _dbContext = dbContext;
        }
        public MinWageRepository() { }

        public List<MinWage> GetMinWages()
        {
            try
            {
                var result = _dbContext.MinWages
                    .OrderBy(mw => mw.TaxYear)
                    .OrderByDescending(mw => mw.Age).ToList();
                return result;
            }
            catch (NullReferenceException)
            {
                throw new Exception("Sorry there doesn't exist any information for the min wage of your selection!");
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Please check your Database connection, and try again");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}