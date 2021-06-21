using System;
using static System.Console;
namespace PaintingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("### Painting Demonstration ###");
            Write("Please eneter the number of rooms: ");
            int numRooms = int.Parse(ReadLine());
            Room[] rooms = new Room[numRooms];
            int len, wid, hei;

            for (int x = 0; x < rooms.Length; x++)
            {
                WriteLine("PLEASE ENTER LENGTH, WIDTH AND HEIGHT OF ROOM");
                Write("Enter Length: "); len = int.Parse(ReadLine());
                Write("Enter Width: "); wid = int.Parse(ReadLine());
                Write("Enter Hieght: "); hei = int.Parse(ReadLine());
            }

            for (int x = 0; x < rooms.Length; x++)
            {
                WriteLine();
                WriteLine("To paint room no. {0} with area {1}/{2}{3}" +
                    "becomes {4} sqft, so we need {5} gallons of paint.", x + 1, rooms[x].Length, rooms[x].Width, rooms[x].Height, rooms[x].Area, rooms[x].Gallons);
            }
        }
    }
    class Room
    {
        int length, width, height, area, gallons;

        public int Length { get { return length; } }
        public int Width { get { return width; } }
        public int Height { get { return height; } }
        public int Area { get { return area; } }
        public int Gallons { get { return gallons; } }

        public Room(int len, int wid, int hei)
        {
            length = len;
            width = wid;
            height = hei;
            ComputeArea();
            ComputerGallons();

        }

        private void ComputeArea()
        {
            area = 2 * Length * Height + 2 * Width * Height;
        }
        private void ComputerGallons()
        {
            const int GALL_SQFT = 350;
            gallons = Area / GALL_SQFT;
            if (Area % GALL_SQFT !=0)
            {
                gallons++;
            }
        }
    }
}