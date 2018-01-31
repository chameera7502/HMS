using Microsoft.Practices.Unity;
using POS.BLL.Concrete;
using POS.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Common
{
    public class UnityFactory : IDisposable
    {
        IUnityContainer container;
        public UnityFactory()
        {
            container = new UnityContainer();
        }

        public  IRoomBL CreateRoomObject()
        {
            container.RegisterType(typeof(IRoomBL), typeof(RoomBL));
            IRoomBL obj = container.Resolve<IRoomBL>();
            return obj;
        } 

      /*  public IItemsBLC CreateItemObject()
        {
            container.RegisterType(typeof(IItemsBLC), typeof(ItemBLC));
            IItemsBLC obj = container.Resolve<IItemsBLC>();
            return obj;
        }

        public ICategoryBL CreateCategoryObject()
        {
            container.RegisterType(typeof(ICategoryBL), typeof(CategoryBLC));
            ICategoryBL obj = container.Resolve<ICategoryBL>();
            return obj;
        }*/

        public void Dispose()
        {
            container.Dispose();
            //throw new NotImplementedException();
        }
    }
}
