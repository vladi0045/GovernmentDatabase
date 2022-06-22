using BusinessLayer;
using DataLayer;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;

namespace TestingLayer
{
    public class PartyContextUnitTest
    {
        private GovernmentDbContext dbContext;
        private PartyContext partyContext;
        private PoliticianContext politicianContext;
        DbContextOptionsBuilder builder;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        //TODO: Add code here that is run before
        //      all tests in the assembly are run

        }

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

            dbContext = new GovernmentDbContext(builder.Options);
            partyContext = new PartyContext(dbContext);
            politicianContext = new PoliticianContext(dbContext);
        }

        [Test]
        public void TestCreateParty()
        {
            int partiesBefore = partyContext.ReadAll().Count();

            partyContext.Create(new Party("Party", "Ideologiq", new DateTime(2022, 06, 14)));

            int partiesAfter = partyContext.ReadAll().Count();

            Assert.IsTrue(partiesBefore != partiesAfter);
        }

        [Test]
        public void TestReadParty()
        {

            partyContext.Create(new Party("Party", "Ideologiq", new DateTime(2022, 06, 14)));

            Party party = partyContext.Read(1);

            Assert.That(party != null, "There is no record with Id 1!");
        }

        [Test]
        public void TestUpdateParty()
        {
            partyContext.Create(new Party("Party", "Ideologiq", new DateTime(2022, 06, 14)));

            Party party = partyContext.Read(1);

            party.Name = "New Party";

            partyContext.Update(party);

            Party party1 = partyContext.Read(1);

            Assert.IsTrue(party1.Name == "New Party", "Party Update() does not change name!");
        }

        [Test]
        public void TestDeleteParty()
        {
            partyContext.Create(new Party("Party", "Ideology", new DateTime(2022, 06, 14)));

            int partiesBeforeDeletion = partyContext.ReadAll().Count();

            partyContext.Delete(1);

            int partiesAfterDeletion = partyContext.ReadAll().Count();

            Assert.AreNotEqual(partiesBeforeDeletion, partiesAfterDeletion, partiesBeforeDeletion.ToString() + " " + partiesAfterDeletion.ToString());

        }

    }
}