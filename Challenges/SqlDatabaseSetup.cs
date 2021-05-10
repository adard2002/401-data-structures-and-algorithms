using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using System;

namespace Challenges
{
    [TestClass]
    public class SqlDatabaseSetup
    {

        [AssemblyInitialize]
        public static void InitializeAssembly(TestContext ctx)
        {
            // Setup the test database based on setting in the
            // configuration file
            SqlDatabaseTestClass.TestService.DeployDatabaseProject();
            SqlDatabaseTestClass.TestService.GenerateData();
        }

    }

    public class TestContext
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}
