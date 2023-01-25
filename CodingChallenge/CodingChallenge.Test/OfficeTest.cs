using CodingChallenge.GraphQL;
using HotChocolate;
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
    public class OfficeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Office()
        {
            var result = await new ServiceCollection().AddGraphQLServer().AddQueryType<Query>().ExecuteRequestAsync("{query{offices{id,name,city,email,latitude,longitude}}}");
            result.ToJson().MatchSnapshot();
        }

        [Test]
        public async Task OfficeByLocation()
        {
            var result = await new ServiceCollection().AddGraphQLServer().AddQueryType<Query>().ExecuteRequestAsync("{query{officesByLocation(latitude: 50.822956, longitude:3.250962, radiusInKM: 20){id,name,city,email,latitude,longitude}}}");
            result.ToJson().MatchSnapshot();
        }
    }
}
