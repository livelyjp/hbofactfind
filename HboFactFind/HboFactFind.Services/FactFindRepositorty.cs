using System;
using System.Data.Entity;
using System.Threading.Tasks;
using HboFactFind.Domain;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Services
{
    public class FactFindRepositorty
    {
        private readonly HboDbContext _dbContext;

        public FactFindRepositorty(HboDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public FactFind Create(int userId)
        {
            var factFind = new FactFind
            {
                PageOne = new PageOne(),
                PageTwo = new PageTwo(),
                PageThree = new PageThree(),
                PageFour = new PageFour(),
                PageFive = new PageFive(),
                PageSix = new PageSix(),
                PageSeven = new PageSeven(),
                PageEight = new PageEight(),
                PageNine = new PageNine(),
                PageTen = new PageTen(),
                UserId = userId
            };

            _dbContext.FactFinds.Add(factFind);
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return factFind;
        }

        public async Task<FactFind> Get(long id)
        {
            var factFind = await _dbContext.FactFinds.Include(x => x.PageOne)
                .Include(x => x.PageTwo)
                .Include(x => x.PageThree)
                .Include(x => x.PageFour)
                .Include(x => x.PageFive)
                .Include(x => x.PageSix)
                .Include(x => x.PageSeven)
                .Include(x => x.PageEight)
                .Include(x => x.PageNine)
                .Include(x => x.PageTen).FirstOrDefaultAsync(x => x.Id == (id));

            return factFind;
        }
    }
}