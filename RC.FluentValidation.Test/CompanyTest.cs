using NUnit.Framework;
using RC.FluentValidation.Domains;
using RC.FluentValidation.Validation;
using System;

namespace RC.FluentValidation.Test
{
    public class Tests
    {

        CompanyValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new CompanyValidator();
        }

        [Test]
        public void Company_FluentValidation_Return_OK()
        {
            var company = new Company { Id = 1, Name = "Robert", DateRegister = DateTime.Now };
            var result = validator.Validate(company);
            Assert.AreEqual(result.IsValid, true);

        }

        [Test]
        public void Company_FluentValidation_Validate_Name_Return_Error()
        {
            var company = new Company { Id = 1, DateRegister = DateTime.Now };
            var result = validator.Validate(company);
            Assert.AreEqual(result.IsValid, false);
        }

        [Test]
        public void Company_FluentValidation_Validate_Date_Return_Error()
        {
            var company = new Company { Id = 1, Name = "Robert" };
            var result = validator.Validate(company);
            Assert.AreEqual(result.IsValid, false);
        }
    }
}