using celilcavus.Market.Model.Interfaces;
using Microsoft.AspNetCore.Http;

namespace celilcavus.Market.Model.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>, Images where T : class, new()
    {
        private readonly MarketContext _context;

        public BaseRepository(MarketContext context)
        {
            _context = context;
        }

        public T Add(T item)
        {
            _context.Set<T>().Add(item);
            return item;
        }

        public T Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return item;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id)!;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public int Update(T item)
        {
            _context.Set<T>().Update(item);
            return SaveChanges();
        }
        public string ImageUpload(IFormFile formFile, ConstLocation constLocation)
        {
            string[] fileExtentions = { "jpg", "png", "jpeg" };
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/{constLocation}");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FileInfo fileInfo = new FileInfo(formFile.FileName);
            foreach (var item in fileExtentions)
            {
                if (fileInfo.Extension == string.Concat(".", item))
                {
                    string fileName = Guid.NewGuid().ToString() + fileInfo.Extension;
                    string fileNameWithPath = Path.Combine(path, fileName);
                    using var stream = new FileStream(fileNameWithPath, FileMode.Create);

                    formFile.CopyTo(stream);
                    return fileName;
                }
            }
            return String.Empty;
        }

        public int DeleteImage(string ImageName, ConstLocation imageLocation)
        {
            FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", imageLocation.ToString(), ImageName));
            if (file.Exists)
            {
                file.Delete();
                return 1;
            }
            return 0;

        }
    }
}
