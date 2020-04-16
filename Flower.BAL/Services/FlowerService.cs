using Flower.BAL.Interface;
using Flower.DAL.Interface;

namespace Flower.BAL.Services
{
    class FlowerService : IFlowerService
    {
        private readonly IFlowerRepository _flowerRepository;
        public FlowerService(IFlowerRepository flowerRepository)
        {
            _flowerRepository = flowerRepository;
        }
    }
}
