using BusinessLayer;
using DataLayer;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;

namespace TestingLayer
{
    public class PositionContextUnitTest
    {
        private GovernmentDbContext dbContext;
        private PositionContext positionContext;
        private PoliticianContext politicianContext;
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
        }

        [Test]
        public void TestCreatePosition()
        {
            int positionBefore = positionContext.ReadAll().Count();

            positionContext.Create(new Position("Position"));

            int positionAfter = positionContext.ReadAll().Count();

            Assert.IsTrue(positionBefore != positionAfter);
        }

        [Test]
        public void TestReadPosition()
        {

            positionContext.Create(new Position("Position"));

            Position party = positionContext.Read(1);

            Assert.That(party != null, "There is no record with id 1!");
        }

        [Test]
        public void TestUpdatePosition()
        {
            positionContext.Create(new Position("Position"));

            Position position = positionContext.Read(1);

            position.PositionName = "New Position";

            positionContext.Update(position);

            Position position1 = positionContext.Read(1);

            Assert.IsTrue(position1.PositionName == "New Position", "Party Update() does not change name!");
        }

        [Test]
        public void TestDeletePosition()
        {
            positionContext.Create(new Position("Position"));

            int partiesBeforeDeletion = positionContext.ReadAll().Count();

            positionContext.Delete(1);

            int partiesAfterDeletion = positionContext.ReadAll().Count();

            Assert.AreNotEqual(partiesBeforeDeletion, partiesAfterDeletion);
        }

    }
}