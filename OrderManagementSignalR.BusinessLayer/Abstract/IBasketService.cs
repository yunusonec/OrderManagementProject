using OrderManagementSignalR.DtoLayer.BasketDto;
using OrderManagementSignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSignalR.BusinessLayer.Abstract
{
    public interface IBasketService : IGenericService<Basket>
    {
        List<Basket> TGetBasketByMenuTableNumber(int id);
        public List<ResultBasketListWithProductsDto> TGetBasketListByMenuTableWithProductName(int id);
    }
}
