using Flower.DAL.Interface;
using Task5_EF.Context;

namespace Flower.DAL.Repositories
{
    class FlowerRepository :IFlowerRepository
    {
        private readonly FlowerContext _flowerContext;
        public FlowerRepository(FlowerContext flowerContext)
        {
            _flowerContext = flowerContext;
        }
    }
}
