using oxuAz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oxuAz.Abstractions
{
    public interface INewsRepo
    {
        List<News> GetAllNews();
        News GetNewsById(int id);
        /// /// 
        /// 
        void Add(News news);
        void Edit(News news);
        void Delete(News news);
        /// /// 
        ///
        bool AddLike(int id);
        bool AddDislike(int id);
        bool AddView(int id);     
    }
}
