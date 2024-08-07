using MC_Shop.Models;

namespace MC_Shop.Services
{
    public class ArticuloService
    {
        public class ArticuloService
        {
            private List<ArticuloModel> _rooms;

            public ArticuloService()
            {
                _rooms = new List<ArticuloModel>
                {
                    new ArticuloModel
                    {
                    
                    },
                };
            }

            public List<ArticuloModel> GetAllRooms()
            {
                return _rooms;
            }

            public ArticuloModel? GetRoom(int id)
            {
                return _rooms.FirstOrDefault(r => r.Id == id);
            }
        }
    }
}
