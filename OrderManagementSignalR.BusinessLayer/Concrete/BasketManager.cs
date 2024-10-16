using OrderManagementSignalR.BusinessLayer.Abstract;
using OrderManagementSignalR.DataAccessLayer.Abstract;
using OrderManagementSignalR.DtoLayer.BasketDto;
using OrderManagementSignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSignalR.BusinessLayer.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void TAdd(Basket entity)
        {
            throw new NotImplementedException();
        }

        public List<ResultBasketListWithProductsDto> TGetBasketListByMenuTableWithProductName(int id)
        {
            var baskets = _basketDal.GetBasketListByMenuTableWithProductName(id);
            var result = baskets.Select(z => new ResultBasketListWithProductsDto
            {
                BasketID = z.BasketID,
                Count = z.Count,
                MenuTableID = z.MenuTableID,
                Price = z.Price,
                ProductID = z.ProductID,
                TotalPrice = z.TotalPrice,
                ProductName = z.Product.ProductName
            }).ToList();

            return result;
        }

        public void TDelete(Basket entity)
        {
            throw new NotImplementedException();
        }

        public List<Basket> TGetBasketByMenuTableNumber(int id)
        {
            return _basketDal.GetBasketByMenuTableNumber(id);   
        }

        public Basket TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Basket> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Basket entity)
        {
            throw new NotImplementedException();
        }
    }
}
