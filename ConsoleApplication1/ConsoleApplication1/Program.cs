using HMS.Common;
using HMS.Domain.DomainClasses;
using POS.BLL.Concrete;
using POS.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (UnityFactory uFactory = new UnityFactory())
            {
                IRoomBL RoomObj = uFactory.CreateRoomObject();
                Room room = new Room { Narration = "Test" };
                RoomObj.Add(room);

            }

        }
    }
}
