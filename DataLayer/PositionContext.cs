using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class PositionContext : IDB<Position, int>
    {
        GovernmentDbContext _context;

        public PositionContext(GovernmentDbContext context)
        {
            _context = context;
        }

        public void Create(Position item)
        {
            try
            {
                _context.Positions.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Position Read(int key, bool noTracking = false, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Position> query = _context.Positions;
               
                if (noTracking)
                {
                    query = query.AsNoTrackingWithIdentityResolution();
                }

                if (useNavigationProperties)
                {
                    query = query.Include(p => p.Politicians);
                }

                Position positionFromDB = query.SingleOrDefault(p => p.Id == key);

                if (positionFromDB == null)
                {
                    throw new ArgumentException("There is no position with that key!");
                }

                return query.SingleOrDefault(k => k.Id == key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Position> Read(int skip, int take, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Position> query = _context.Positions.AsNoTrackingWithIdentityResolution();

                if (useNavigationProperties)
                {
                    query = query.Include(p => p.Politicians);
                }

                return query.Skip(skip).Take(take).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Position> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Position> query = _context.Positions.AsNoTracking();

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

        public void Update(Position item, bool useNavigationProperties = false)
        {
            try
            {
                Position positionFromDB = Read(item.Id, useNavigationProperties);

                _context.Entry(positionFromDB).CurrentValues.SetValues(item);

                if (useNavigationProperties)
                {
                    List<Politician> positionPreviousPoliticians = positionFromDB.Politicians.ToList();
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
                            positionPreviousPoliticians.Remove(politicianFromDB);
                        }
                    }

                    positionFromDB.Politicians = politicians;

                    Position unknownPosition = Find("Unknown", useNavigationProperties);

                    foreach (Politician politician in positionPreviousPoliticians)
                    {
                        politician.Position = unknownPosition;
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
                _context.Positions.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Position Find(string positionName, bool useNavigationProperties = false)
        {
            try
            {
                return _context.Positions.SingleOrDefault(p => p.PositionName == positionName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
