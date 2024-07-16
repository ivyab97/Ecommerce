using Microsoft.EntityFrameworkCore;

namespace Application.DTO.Pagination
{
    public class Paged<T> where T : class
    {
        public List<T> Data { get; set; }
        
        public Paged(List<T> items) 
        {
            Data = items;
        }

        public static async Task<Paged<T>> ToPagedAsync(IQueryable<T> entity, int offset, int? limit) 
        {
            List<T> items = new();
            int count;

            if (offset >= 0 && limit == null)
            {
                count = await entity.CountAsync();
                items = await entity.Skip(offset).ToListAsync();
                return new Paged<T>(items);
            } else
            {
                items = await entity.Skip(offset)
                                    .Take((int)limit).ToListAsync();
                count = await entity.CountAsync();
                return new Paged<T>(items);
            }
        }
    }
}
