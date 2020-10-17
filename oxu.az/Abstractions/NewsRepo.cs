using Microsoft.EntityFrameworkCore;
using oxuAz.Abstractions;
using oxuAz.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oxuAz.Models
{
    public class NewsRepo : INewsRepo
    {
        NewsAppContext _db;

        public NewsRepo(NewsAppContext db)
        {
            _db = db;
        }

        public List<News> GetAllNews()
        {
            return _db.News.ToList();
        }
        public News GetNewsById(int id)
        {
            News news = _db.News.Find(id);
            if (news != null)
            {
                return news;
            }
            return null;
        }
        public void Add(News news)
        {
            _db.News.Add(news);
            _db.SaveChanges();
        }
        public void Edit(News news)
        {
            _db.ChangeTracker.Entries().Where(e => e.Entity != null).ToList().ForEach(e => e.State = EntityState.Detached);
            _db.Entry(news).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public void Delete(News news)
        {
            _db.News.Remove(news);
            _db.SaveChanges();
        }
        public bool AddLike(int id)
        {
            News news = _db.News.Find(id);
            news.Likes += 1;
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddDislike(int id)
        {
            News news = _db.News.Find(id);
            news.Dislikes += 1;
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddView(int id)
        {
            News news = _db.News.Find(id);
            news.Views += 1;
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
