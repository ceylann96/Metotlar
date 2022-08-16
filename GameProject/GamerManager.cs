using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.validate(gamer)==true)
            {
                Console.WriteLine(" kayıt olundu");
            }
            else
            {
                Console.WriteLine("bilgiler uyuşmadı doğrulama başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(" silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(" güncellendi");
        }
    }
}
