﻿using IncomeCalculator.Data;
using IncomeCalculator.Services;
using System;
using System.ComponentModel.DataAnnotations;

namespace IncomeCalculator.Models
{
    public class WorkDetails
    {
        private decimal _hourlyRate;
        private readonly MinWageService _minWageService;

        [Range(10, 120, ErrorMessage = "Please enter a valid age!")]
        public int Age { get; set; }
        [Range(2, 168)]
        public decimal HoursPW { get; set; }
        public bool IsMinWage { get; set; }
        public bool IsTaxCalculator { get; set; }
        public MinWage MinWage { get; set; } = new MinWage();
        [Required]
        public Period Period { get; set; }
        public decimal? Total { get { return GetTotal(); } set { } }
        public decimal HourlyRate
        {
            get
            {
                if (IsMinWage && HoursPW >= 1)
                    GetMinWage();

                return _hourlyRate;
            }
            set { _hourlyRate = value; }
        }

        public WorkDetails()
        {
            _minWageService = new MinWageService(new DAL.MinWagePersistence(new BenefitsContext()));
        }

        private decimal? GetTotal()
        {
            if (HoursPW <= 0 || HourlyRate <= 0)
                return null;

            var weeklyWage = HoursPW * HourlyRate;
            switch (Period)
            {
                case Period.Month:
                    return weeklyWage * 52 / 12;
                case Period.Year:
                    return weeklyWage * 52;
                default:
                    return weeklyWage;
            }
        }

        private void GetMinWage()
        {
            try
            {
                var minwage = _minWageService.GetMinWage(Age, MinWage.TaxYear);
                _hourlyRate = minwage.Wage;
            }
            catch (Exception) { }
        }
    }

    public enum Period
    {
        Week,
        Month,
        Year
    }
}