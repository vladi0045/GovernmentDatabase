using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class PoliticianContext : IDB<Politician, int>
    {
        private GovernmentDbContext _context;

        public PoliticianContext(GovernmentDbContext context)
        {
            _context = context;
        }

        public void Create(Politician item)
        {
            try
            {
                Party partyFromDB = _context.Parties.Find(item.PartyId);

                if (partyFromDB != null)
                {
                    item.Party = partyFromDB;
                }

                Position positionFromDB = _context.Positions.Find(item.PositionId);

                if (positionFromDB != null)
                {
                    item.Position = positionFromDB;
                }


                _context.Politicians.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Politician Read(int key, bool noTracking = false, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Politician> query = _context.Politicians.AsNoTrackingWithIdentityResolution();

                return query.SingleOrDefault(k => k.Id == key);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Politician> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Politician> query = _context.Politicians.AsNoTracking();

                return query.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Politician> Read(int skip, int take, bool useNavigationProperties)
        {
            try
            {
                IQueryable<Politician> query = _context.Politicians.AsNoTrackingWithIdentityResolution();

                return query.Skip(skip).Take(take).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Politician item, bool useNavigationProperties = false)
        {
            try
            {
                Politician politicianFromDB = Read(item.Id, useNavigationProperties);

                if (useNavigationProperties)
                {
                    politicianFromDB.Party = item.Party;
                    politicianFromDB.Position = item.Position;
                }

                _context.Entry(politicianFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                _context.Politicians.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Politician Find(int id)
        {
            try
            {
                return _context.Politicians.FirstOrDefault(i => i.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
