﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes.ModelWithLookup;

namespace Recipes.Ado.ModelWithLookup
{
    [TestClass]
    public class ModelWithLookupSimpleTests : ModelWithLookupSimpleTests<EmployeeSimple>
    {
        protected override IModelWithLookupSimpleRepository<EmployeeSimple> GetRepository()
        {
            return new ModelWithLookupSimpleRepository(Setup.ConnectionString);
        }
    }
}
