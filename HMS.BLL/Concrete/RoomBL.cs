using POS.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.Domain.DomainClasses;
using HMS.DAL;
using HMS.Domain;

namespace POS.BLL.Concrete
{
    public class RoomBL : IRoomBL
    {
        UnitOfWork unitOfWork;
        public RoomBL()
        {
            unitOfWork = new UnitOfWork(new HMSContext());
        }
        public void Add(Room room)
        {
            unitOfWork.GetRepository<Room>().Add(room);
            unitOfWork.Commit();
        }

        public void Delete(Room room)
        {
            unitOfWork.GetRepository<Room>().Delete(room);
            unitOfWork.Commit();
        }

        public Room GetRoomByGuest(Guest guest)
        {
            //Return all records
            IEnumerable<RoomManagment> roomManagements = unitOfWork.GetRepository<RoomManagment>().List;
            //Return records relevant to specified guest
            roomManagements = roomManagements.Where(c => c.Reservation.Guest.GuestID == guest.GuestID);
            //Return room
            return roomManagements.FirstOrDefault().RoomsAssigned.FirstOrDefault();
            
        }

        public Room GetRoomByID(int RoomID)
        {
            return unitOfWork.GetRepository<Room>().FirstOrDefalult(RoomID);
        }

        public IEnumerable<Room> RoomsList()
        {
            return unitOfWork.GetRepository<Room>().List;
        }

     
        public void Update(Room room)
        {
            unitOfWork.GetRepository<Room>().Update(room);
            unitOfWork.Commit();
        }
    }
}
