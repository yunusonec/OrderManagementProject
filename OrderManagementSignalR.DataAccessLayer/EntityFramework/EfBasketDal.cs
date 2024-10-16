using Microsoft.EntityFrameworkCore;
using OrderManagementSignalR.DataAccessLayer.Abstract;
using OrderManagementSignalR.DataAccessLayer.Concrete;
using OrderManagementSignalR.DataAccessLayer.Repositories;
using OrderManagementSignalR.DtoLayer.BasketDto;
using OrderManagementSignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSignalR.DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>,IBasketDal
    {
        public EfBasketDal(SignalRContext context) : base(context) 
        {
        }

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
            using var context = new SignalRContext();
            var values = context.Baskets.Where(x=>x.MenuTableID== id).Include(y=>y.Product).ToList(); 
            return values;
        }
        public List<Basket> GetBasketListByMenuTableWithProductName(int id)
        {
            using var context = new SignalRContext();
            return context.Baskets.Include(x => x.Product)
                                 .Where(y => y.MenuTableID == id)
                                 .ToList();
        }
    }
}
