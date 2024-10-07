using OrderManagementSignalR.DataAccessLayer.Abstract;
using OrderManagementSignalR.DataAccessLayer.Concrete;
using OrderManagementSignalR.DataAccessLayer.Repositories;
using OrderManagementSignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSignalR.DataAccessLayer.EntityFramework
{
    public class EfMenuTableDal : GenericRepository<MenuTable>, IMenuTableDal
    {
        public EfMenuTableDal(SignalRContext context) : base(context) 
        {
        }

        public int MenuTableCount()
        {
            using var context = new SignalRContext();
            return context.MenuTables.Count();
        }
    }
}
