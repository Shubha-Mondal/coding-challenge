using CodingChallenge.Data;
using HotChocolate.Execution;
using Microsoft.Extensions.DependencyInjection;
using Snapshooter.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Test
{
    public class SchemaTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task OfficeSchemaTest()
        {
            var schema = await new ServiceCollection().AddGraphQLServer().AddQueryType<Query>().BuildSchemaAsync();
            schema.ToString().MatchSnapshot();
        }
    }
}
