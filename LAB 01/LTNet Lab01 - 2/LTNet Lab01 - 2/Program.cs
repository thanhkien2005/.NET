using System;
using System.Collections.Generic;

namespace SportListManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Sport> sports = new List<Sport>();

            sports.Add(new Football(20, 90, "Football Ball"));
            sports.Add(new Tennis(2, 30, "Tennis Ball"));
            sports.Add(new Volleyball(12, 60, "Volleyball Ball"));


            foreach (var sport in sports)
            {
                sport.InputInfo();  
            }

            foreach (var sport in sports)
            {
                sport.DisplayInfo();  
            }
        }
    }
}

public class Sport
{
    public int members;
    public int time;
    public string ballType;

    public Sport(int members, int time, string ballType)
    {
        this.members = members;
        this.time = time;
        this.ballType = ballType;
    }

    public virtual void InputInfo()
    {
        Console.WriteLine("Nhập thông tin cho Sport (cơ bản):");
        Console.Write("Members: ");
        members = int.Parse(Console.ReadLine());
        Console.Write("Play Time: ");
        time = int.Parse(Console.ReadLine());
        Console.Write("Ball Type: ");
        ballType = Console.ReadLine();
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Sport - Members: {0}, Time: {1}, Ball Type: {2}", members, time, ballType);
    }
}

public class Football : Sport
{
    public Football(int members, int time, string ballType) : base(members, time, ballType) { }

    public override void InputInfo()
    {
        Console.WriteLine("Football:");
        Console.Write("Members: ");
        members = int.Parse(Console.ReadLine());
        Console.Write("Play Time: ");
        time = int.Parse(Console.ReadLine());
        Console.Write("Ball Type: ");
        ballType = Console.ReadLine();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Football - Members: {0}, Time: {1}, Ball Type: {2}", members, time, ballType);
    }
}

public class Tennis : Sport
{
    public Tennis(int members, int time, string ballType) : base(members, time, ballType) { }

    public override void InputInfo()
    {
        Console.WriteLine("Tennis:");
        Console.Write("Members: ");
        members = int.Parse(Console.ReadLine());
        Console.Write("Play Time: ");
        time = int.Parse(Console.ReadLine());
        Console.Write("Ball Type: ");
        ballType = Console.ReadLine();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Tennis - Members: {0}, Time: {1}, Ball Type: {2}", members, time, ballType);
    }
}

public class Volleyball : Sport
{
    public Volleyball(int members, int time, string ballType) : base(members, time, ballType) { }

    public override void InputInfo()
    {
        Console.WriteLine("Volleyball:");
        Console.Write("Members: ");
        members = int.Parse(Console.ReadLine());
        Console.Write("Play Time: ");
        time = int.Parse(Console.ReadLine());
        Console.Write("Ball Type: ");
        ballType = Console.ReadLine();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Volleyball - Members: {0}, Time: {1}, Ball Type: {2}", members, time, ballType);
    }
    public interface IReferee
    {
        int NumberOfReferees { get; set; }
        void RefereeInfo();
    }

    public class Football : Sport, IReferee
    {
        public int NumberOfReferees { get; set; }

        public Football(int members, int time, string ballType, int referees)
            : base(members, time, ballType)
        {
            this.NumberOfReferees = referees;
        }

        public void RefereeInfo()
        {
            Console.WriteLine("Football - Number of Referees: {0}", NumberOfReferees);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            RefereeInfo();
        }
    }

}

