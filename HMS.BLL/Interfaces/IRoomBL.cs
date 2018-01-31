using HMS.Domain.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Abstraction for Room Management Business Logics 
/// </summary>
namespace POS.BLL.Interfaces
{
    public interface IRoomBL
    {
        /// <summary>
        /// Return all rooms
        /// </summary>
        /// <returns></returns>
        IEnumerable<Room> RoomsList();
        /// <summary>
        /// Add New room
        /// </summary>
        /// <param name="room"></param>
        void Add(Room room);
        /// <summary>
        /// Update Room
        /// </summary>
        /// <param name="room"></param>
        void Update(Room room);
        /// <summary>
        /// Remove Room
        /// </summary>
        /// <param name="room"></param>
        void Delete(Room room);
        /// <summary>
        /// Get Room by Given ID
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        Room GetRoomByID(int RoomID);
        /// <summary>
        /// Return the activated room for given guest
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        Room GetRoomByGuest(Guest guest);
    }
}
