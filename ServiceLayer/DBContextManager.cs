using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public static class DBContextManager
    {
        private static GovernmentDbContext _context;
        private static PartyContext _partyContext;
        private static PoliticianContext _politicianContext;
        private static PositionContext _positionContext;

        #region DB Context

        public static GovernmentDbContext CreateContext()
        {
            _context = new GovernmentDbContext();
            return _context;
        }

        public static GovernmentDbContext GetContext()
        {
            return _context;
        }

        public static void SetChangeTracking(bool value)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
        }

        #endregion

        #region TContexts

        public static PartyContext CreatePartyContext(GovernmentDbContext context)
        {
            _partyContext = new PartyContext(context);
            return _partyContext;
        }

        public static PartyContext GetPartyContext()
        {
            return _partyContext;
        }

        public static PoliticianContext CreatePoliticianContext(GovernmentDbContext context)
        {
            _politicianContext = new PoliticianContext(context);
            return _politicianContext;
        }

        public static PoliticianContext GetPoliticianContext()
        {
            return _politicianContext;
        }

        public static PositionContext CreatePositionContext(GovernmentDbContext context)
        {
            _positionContext = new PositionContext(context);
            return _positionContext;
        }

        public static PositionContext GetPositionContext()
        {
            return _positionContext;
        }

        #endregion

    }
}
