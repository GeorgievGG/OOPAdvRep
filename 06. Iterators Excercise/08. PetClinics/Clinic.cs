using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Clinic : IEnumerable<Pet>
{
    public Clinic(string name, int rooms)
    {
        if (rooms % 2 == 0)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        this.Name = name;
        this.rooms = new Pet[rooms];
    }
    private string name;
    private Pet[] rooms;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public Pet[] Rooms
    {
        get
        {
            return rooms;
        }
    }

    internal string Release()
    {
        var reqIndex = Rooms.Length / 2;
        for (int i = 0; i < Rooms.Length; i++)
        {
            reqIndex %= Rooms.Length;
            if (rooms[reqIndex] != null)
            {
                rooms[reqIndex] = null;
                return "true";
            }
            reqIndex++;
        }
        return "false";
    }

    public string Add(Pet p)
    {
        var distance = 0;
        for (int i = 0; i < Rooms.Length; i++)
        {
            var reqIndex = Rooms.Length / 2;
            if (i % 2 == 1)
            {
                reqIndex -= distance;
                if (i == 0)
                {
                    distance++;
                }
            }
            else
            {
                reqIndex += distance;
                distance++;
            }
            if (rooms[reqIndex] == null)
            {
                rooms[reqIndex] = p;
                return "true";
            }
        }
        return "false";
    }

    public string HasEmptyRooms()
    {
        if (Rooms.Where(x => x == null).Count() != 0)
        {
            return "true";
        }
        return "false";
    }

    public string Print()
    {
        var sb = new StringBuilder();
        foreach (var room in Rooms)
        {
            if (room == null)
            {
                sb.AppendLine("Room empty");
            }
            else
            {
                sb.AppendLine(room.ToString());
            }
        }
        return sb.ToString().Trim();
    }

    public string Print(int index)
    {
        if (Rooms[index] == null)
        {
            return "Room empty";
        }
        else
        {
            return Rooms[index].ToString();
        }
    }

    public IEnumerator<Pet> GetEnumerator()
    {
        //var distance = 0;
        //for (int i = 0; i < Rooms.Length; i++)
        //{
        //    var reqIndex = Rooms.Length / 2 - 1;
        //    if (i % 2 == 1)
        //    {
        //        reqIndex -= distance;
        //        if (i == 0)
        //        {
        //            distance++;
        //        }
        //    }
        //    else
        //    {
        //        reqIndex += distance;
        //        distance++;
        //    }
        //    yield return rooms[reqIndex];
        //}
        for (int i = 0; i < Rooms.Length; i++)
        {
            yield return Rooms[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}