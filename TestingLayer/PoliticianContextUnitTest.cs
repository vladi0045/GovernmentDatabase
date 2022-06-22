using BusinessLayer;
using DataLayer;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;

namespace TestingLayer
{
    public class PoliticianContextUnitTest
    {
        private GovernmentDbContext dbContext;
        private PositionContext positionContext;
        private PoliticianContext politicianContext;
        private PartyContext partyContext;
        DbContextOptionsBuilder builder;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // TODO: Add code here that is run before
            //  all tests in the assembly are run

        }

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

            dbContext = new GovernmentDbContext(builder.Options);
            positionContext = new PositionContext(dbContext);
            politicianContext = new PoliticianContext(dbContext);
            partyContext = new PartyContext(dbContext);
        }

        [Test]
        public void TestCreatePolitician()
        {
            int politicianBefore = politicianContext.ReadAll().Count();

            Party party = new Party("Party", "Ideology", new DateTime(2022, 06, 14));

            Position position = new Position("Position");

            politicianContext.Create(new Politician("Vlad", "Niskiq", "Kichev", 18, position, party, new DateTime(2022, 06, 14)));

            int politicianAfter = positionContext.ReadAll().Count();

            Assert.IsTrue(politicianBefore != politicianAfter);
        }

        [Test]
        public void TestReadPolitician()
        {
            Party party = new Party("Party", "Ideology", new DateTime(2022, 06, 14));

            Position position = new Position("Position");

            politicianContext.Create(new Politician("Vlad", "Niskiq", "Kichev", 18, position, party, new DateTime(2022, 06, 14)));

            Politician politician = politicianContext.Read(1);

            Assert.That(politician != null, "There is no record with id 1!");
        }

        [Test]
        public void TestUpdatePolitician()
        {
            Party party = new Party("Party", "Ideology", new DateTime(2022, 06, 14));

            Position position = new Position("Position");

            politicianContext.Create(new Politician("Vlad", "Niskiq", "Kichev", 18, position, party, new DateTime(2022, 06, 14)));

            Politician politician = politicianContext.Read(1);

            politician.FirstName = "Vladimir";

            politicianContext.Update(politician);

            Politician politician1 = politicianContext.Read(1);

            Assert.IsTrue(politician1.FirstName == "Vladimir", "Politician Update() does not change name!");
        }

        [Test]
        public void TestDeletePolitician()
        {
            Party party = new Party("Party", "Ideology", new DateTime(2022, 06, 14));

            Position position = new Position("Position");

            politicianContext.Create(new Politician("Vlad", "Niskiq", "Kichev", 18, position, party, new DateTime(2022, 06, 14)));

            int politiciansBeforeDeletion = politicianContext.ReadAll().Count();

            politicianContext.Delete(1);

            int politiciansAfterDeletion = politicianContext.ReadAll().Count();

            Assert.AreNotEqual(politiciansBeforeDeletion, politiciansAfterDeletion);
        }

    }
}