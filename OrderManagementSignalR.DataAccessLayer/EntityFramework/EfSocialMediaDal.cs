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
    public class EfSocialMediaDal : GenericRepository<SocialMedia>,ISocialMediaDal
    {
        public EfSocialMediaDal(SignalRContext context) : base(context)
        {
        }
    }
}
