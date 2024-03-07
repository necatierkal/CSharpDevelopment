using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class UserManager
    {
        //private ICacheService _cacheService; /// <summary>
        /// Interface i Constructor ile alıp sınıfın içerisinden başka bir yerde ulaşırsak buna dependency injection denir.
        /// </summary>
        /// <param name="cacheService"></param>
        /// 
        private readonly ICacheService _cacheService;
        public UserManager(ICacheService cacheService)
        {
                _cacheService = cacheService;
        }
        public void DeleteUser(int id)
        {
            //kullanıcı silindi (VT işlemi yapıldığının simülesi)
            _cacheService = new RedisCache();
            _cacheService.Remove(CacheKeys.USER_CACHE_KEY);//Cachi temizle. Buradaki user_cache key value pair olarak verilir.
            _cacheService.Clear();
        }
        public void AddNewUser (User user) 
        {
            //kullanıcı eklendi
            _cacheService.Remove("user_cache");//Cachi temizle
        }   
        public List<User> GetUsers()
        {
            // Cache mekanizmaların hepsinde vardır. 
            if (_cacheService.isExist("user_chache")) //Cache de varsa onu getir bir daha vt den alma.
                return (List<User>)_cacheService.Get("user_cache");
            //kullanıcılar db den getirildi
            var dataFromDb = new List<User>()//Databas den gelmiş gibi düşünüp object initiliazer ile oluşturuldu.
            {
                new User() { id= 1,Name = "Salih DEMİROĞ"},
                new User() { id= 2,Name = "Zeynep Liya DEMİROĞ"}
            };
            _cacheService.Add("user_cache",dataFromDb);//Gelen veriyi cache'e at.

            return dataFromDb;
        }
        
    }
}
