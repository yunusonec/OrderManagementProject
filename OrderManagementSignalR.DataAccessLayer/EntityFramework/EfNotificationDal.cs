﻿using OrderManagementSignalR.DataAccessLayer.Abstract;
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
    public class EfNotificationDal:GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationDal(SignalRContext context) : base(context) 
        {
        }

        public List<Notification> GetAllNotificationByFalse()
        {
            using var context = new SignalRContext();
            return context.Notifications.Where(x=>x.Status==false).ToList();
        }

        public int NotificationCountByStatusFalse()
        {
            using var context = new SignalRContext();   
            return context.Notifications.Where(x=>x.Status==false).Count();
        }
    }
}
