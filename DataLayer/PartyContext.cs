using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class PartyContext : IDB<Party, int>
    {
        private GovernmentDbContext _context;

        public PartyContext(GovernmentDbContext context)
        {
            this._context = context;
        }

        public void Create(Party item)
        {
            try
            {
                _context.Parties.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Party Read(int key, bool noTracking = false, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Party> query = _context.Parties;

                if (noTracking)
                {
                    query = query.AsNoTrackingWithIdentityResolution();
                }

                if (useNavigationProperties)
                {
                    query = query.Include(a => a.Politicians);
                }

                Party partyFromDB = query.SingleOrDefault(a => a.Id == key);

                if (partyFromDB == null)
                {
                    throw new ArgumentException("There is no party with that key!");
                }

                return partyFromDB;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Party> Read(int skip, int take, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Party> query = _context.Parties.AsNoTrackingWithIdentityResolution();

                if (useNavigationProperties)
                {
                    query = query.Include(a => a.Politicians);
                }

                return query.Skip(skip).Take(take).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Party> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Party> query = _context.Parties.AsNoTracking();

                if (useNavigationProperties)
                {
                    query = query.Include(p => p.Politicians);
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Party item, bool useNavigationProperties = false)
        {
            try
            {
                Party partyFromDB = Read(item.Id, useNavigationProperties);

                _context.Entry(partyFromDB).CurrentValues.SetValues(item);

                if (useNavigationProperties)
                {
                    List<Politician> partyPreviousPoliticians = partyFromDB.Politicians.ToList();
                    List<Politician> politicians = new List<Politician>(item.Politicians.Count());

                    foreach (Politician politician in item.Politicians)
                    {
                        Politician politicianFromDB = _context.Politicians.SingleOrDefault(p => p.Id == politician.Id);

                        if (politicianFromDB == null)
                        {
                            _context.Entry(politician);
                            politicians.Add(politician);
                        }
                        else
                        {
                            //_context.Entry(bookFromDB).CurrentValues.SetValues(book);
                            politicians.Add(politicianFromDB);
                            partyPreviousPoliticians.Remove(politicianFromDB);
                        }
                    }

                    partyFromDB.Politicians = politicians;

                    Party unknownParty = Find("Unknown", useNavigationProperties);

                    foreach (Politician politician in partyPreviousPoliticians)
                    {
                        politician.Party = unknownParty;
                    }

                }

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
                _context.Parties.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Party Find(string name, bool useNavigationProperties = false)
        {
            try
            {
                return _context.Parties.SingleOrDefault(a => a.Name == name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
