using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainData;

namespace HotelManagement
{
    class Program
    {
        static void UpdateNumberOfRooms(Hotel hotel)
        {
            hotel.ValNumberOfRoom = hotel.Rooms.Count;
        }
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            hotel.ValName = "Ngoi Sao";

            hotel.HotelAddorRemoveEnvent += new Hotel.HotelHandler(UpdateNumberOfRooms);

            hotel.Rooms.Add(new Room("R001", ConditionType.Standard, BedType.DoubleBedRoom, 2));
            hotel.Rooms.Add(new Room("R002", ConditionType.Superior, BedType.TripleBedRoom, 3));
            hotel.Rooms.Add(new Room("R003", ConditionType.Deluxe, BedType.ExtraBedRoom, 4));

            Room room = hotel.SearchRoom("R001");
            hotel.RemoveRoom(room);

            hotel.HotelInfo();

            Console.ReadKey();

            //Console.WriteLine("Searching Process:");
            //hotel.SearchRoom("R001").RoomInfo();
            //hotel.SearchRoom("R004").RoomInfo();
            //hotel.SearchRoom(2).RoomInfo();
            //hotel.SearchRoom(3).RoomInfo(); 

            //Console.WriteLine("Searching Process:");
            //Console.WriteLine(hotel.SearchRoom("R001").ConvertToString());
            //Console.WriteLine(hotel.SearchRoom("R004").ConvertToString());
            //Console.WriteLine(hotel.SearchRoom(2).ConvertToString());
            //Console.WriteLine(hotel.SearchRoom(3).ConvertToString());

            //Console.ReadKey();
        }
    }
}


namespace MainData
{
    public enum ConditionType { Standard, Superior, Deluxe, Suite };
    public enum BedType { ConnectingRoom, SingleBedRoom, TwinBedRoom, DoubleBedRoom, TripleBedRoom, ExtraBedRoom };
    public class Room
    {
        string RoomID = "RM000";
        ConditionType condition = ConditionType.Standard;
        BedType bedtype = BedType.DoubleBedRoom;
        int Capacity = 2;

        public Room() { }
        public Room(string roomID, ConditionType condition, BedType bedType, int Capacity)
        {
            this.RoomID = roomID;
            this.condition = condition;
            this.bedtype = bedType;
            this.Capacity = Capacity;
        }

        public string ValRoomID
        {
            get { return RoomID; }
            set { RoomID = value; }
        }

        public ConditionType Valcondition
        {
            get { return condition; }
            set { condition = value; }
        }
        public BedType Valbedtype
        {
            get { return bedtype; }
            set { bedtype = value; }
        }
        public int ValCapacity
        {
            get { return Capacity; }
            set { Capacity = value; }
        }

        public void RoomInfo()
        {
            string conditionName = Enum.GetName(typeof(ConditionType), condition);
            string bedtypeName = Enum.GetName(typeof(BedType), bedtype);

            if (RoomID != "RM000")
                Console.WriteLine("Phong: {0} - {1} - {2} for {3} persons", RoomID, conditionName, bedtypeName, Capacity);
        }
    }
    public class Hotel
    {
        public List<Room> Rooms { get; set; }
        Dictionary<ConditionType, string> conditionInfo = new Dictionary<ConditionType, string>();

        public delegate void HotelHandler(Hotel hotel);
        public event HotelHandler HotelAddorRemoveEnvent;

        string Name;
        int NumberOfRoom = 0;

        public int ValNumberOfRoom
        {
            get {  return NumberOfRoom;}
            set { NumberOfRoom = value;}
        }
        public Hotel()
        {
            Rooms = new List<Room>();
            Name = "Not Assigned";
            conditionInfo.Add(ConditionType.Standard, "Phong Standard la phong co chat luong va gia thap nhat.");
            conditionInfo.Add(ConditionType.Superior, "Phong Superior co dien tich lon hoac huong nhin dep.");
            conditionInfo.Add(ConditionType.Deluxe, "Phong Deluxe co chat luong cao, thuong o tang cao.");
            conditionInfo.Add(ConditionType.Suite, "Phong Suite o tang cao nhat voi cac trang bi va dich vu dac biet.");
        }
        public string ValName
        {
            get { return Name; }
            set { Name = value; }
        }
        public void HotelInfo()
        {
            Console.WriteLine("Khach San {0} co {1} phong. Gom cac phong nhu sau:\n", Name, NumberOfRoom);
            foreach (Room rm in Rooms)
            {
                KeyValuePair<ConditionType, string> info = conditionInfo.FirstOrDefault(o => o.Key == rm.Valcondition);
                rm.RoomInfo();
                Console.WriteLine("---Thong Tin Phong: {0}\n", info.Value);
            }
        }

        public void AddRoom(Room room)

        {
            Rooms.Add(room);
            OnHotelChanger(this);
        }

        public void RemoveRoom(Room room)
        {
            Rooms.Remove(room);
            OnHotelChanger(this);
        }

        public void OnHotelChanger(Hotel hotel)
        {
            if (HotelAddorRemoveEnvent !=  null)
            {
                HotelAddorRemoveEnvent(this);
            }
        }
        public Room SearchRoom<T>(T search)
        {
            Room r = new Room();
            if (typeof(T) == typeof(string))
            {
                r = Rooms.FirstOrDefault(o => o.ValRoomID == search.ToString());
                if (r != null)
                    return r;
            }
            else if (typeof(T) == typeof(int))
            {
                if (Convert.ToInt32(search) < Rooms.Count)
                    return Rooms[Convert.ToInt32(search)];
            }
            Console.WriteLine("Room is not found");
            return new Room(); // Room 004 ko tồn tại, tại sao ko kiếm thấy room(3) vì chỉ số index bắt đầu từ 0,1,2.
                               // vậy room 3 sẽ vượt quá chỉ số phòng nên ko tồn taijl.
        }
    }

    public static class MyExtensions
    {
        public static string ConvertToString(this Room room)
        {
            string conditionName = Enum.GetName(typeof(ConditionType), room.Valcondition);
            string bedtypeName = Enum.GetName(typeof(BedType), room.Valbedtype);

            if (room.ValRoomID != "RM000")
                return String.Format("Phong: {0} - {1} - {2} for {3} persons",
                    room.ValRoomID, conditionName, bedtypeName, room.ValCapacity);
            else
                return " ";
        }
    }
}
