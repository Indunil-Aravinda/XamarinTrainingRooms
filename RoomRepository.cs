using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinTrainingRooms
{
    /// <summary>
    /// retrieve data for the model class from the local stored
    /// </summary>
    public class RoomRepository
    {

        /// <summary>
        /// locally stored list of XamarinTrainingRooms list
        /// </summary>       
        private List<XamarinTrainingRooms> _rooms = new List<XamarinTrainingRooms>
        {
            new XamarinTrainingRooms
            {
                id = 1,
                name = "Level One",
                location = "Building 1",
                numComputers = 25
            },
            new XamarinTrainingRooms
            {
                id = 2,
                name = "Level Two",
                location = "Building 1",
                numComputers = 20
            },
            new XamarinTrainingRooms
            {
                id = 3,
                name = "Level Three",
                location = "Building 1",
                numComputers = 15
            }
        };

        /// <summary>
        /// retrieve the local stored room list     
        /// </summary>
        /// <returns>List of XamarinTrainingRooms model class items stored</returns>
        public List<XamarinTrainingRooms> GetRooms()
        {
            return _rooms;
        }

        ///<summary>
        /// method to retrieve single room from id using Linq queries
        /// </summary>
        /// <param name="id">integer id of the class room</param>
        /// <returns>XamarinTrainingRooms model List item</returns>
        public XamarinTrainingRooms getRooms(int id)
        {
            return (from r in _rooms
                    where r.id == id
                    select r).FirstOrDefault();
        }
    }
}
