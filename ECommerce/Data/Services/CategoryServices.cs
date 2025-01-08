using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly EcommerceDbContext _context;
        public CategoryServices(EcommerceDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Category entity)
        {
            await _context.Categories.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAllAsycn()
        {
           return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        => await _context.Categories.FirstOrDefaultAsync(x=>x.Id==id);

        public async Task UpdateAsync(Category entity)
        {
            var CategoryId = await _context.Categories.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (CategoryId != null)
            {
                CategoryId.Id = entity.Id;
                CategoryId.Name = entity.Name;
                CategoryId.Description = entity.Description;
                await _context.SaveChangesAsync();
            }


        }
    }
}
