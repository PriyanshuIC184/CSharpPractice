using System;
namespace RideFare
{

    enum VType
    {
        BUS = 101,
        BIKE,
        RICKSHAW,
        SEDAN,
    }
    abstract class Vehicle
    {
        private int farePerKm;

        public int Fare { get { return farePerKm; } set { farePerKm = value; } }
        public abstract void vehicleSound();

        public void finalFare(int distance)
        {
            Console.WriteLine($"Your Cost for {distance} km is Rs. {distance*farePerKm}");
        }

       public Vehicle(int cost) { Fare = cost; }
    }

    class Sedan : Vehicle
    {
        int nodjf = 1;
        public Sedan() : base(18) { }
        public override void vehicleSound()
        {
            Console.WriteLine("Peep Peep! Your Sedan is Ready to guide you to your destination!");
        }
    }
    class Bike : Vehicle
    {
        public Bike() : base(8) { }
        public override void vehicleSound()
        {
            Console.WriteLine("Vroom Vroom! Your Bike is Ready to guide you to your destination!");
        }
    }

    class Rickshaw : Vehicle
    {
        public Rickshaw() : base(12) { }
        public override void vehicleSound()
        {
            Console.WriteLine("Kiik kiii! Your Rickshaw is Ready to guide you to your destination!");
        }
    }

    class Bus : Vehicle
    {

        public Bus() : base(6) { }
        public override void vehicleSound()
        {
            Console.WriteLine("Poon poon! Your Bus is Ready to guide you to your destination!");
        }
    }

    class RideFare
    {
        static int checkAndReadInput(int[] arr)
        {
            int myChoice = Convert.ToInt32(Console.ReadLine());
            foreach(int i in arr)
            {
                if (i == myChoice)
                    return myChoice;
            }
            Console.WriteLine("Wrong Choice! Enter Your Choice Again");
            return checkAndReadInput(arr);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Metaverse of Rides!!");
            Console.WriteLine("Please Enter the distance (in KM) ");
            int distanceInKm = Convert.ToInt32(Console.ReadLine());
            int optionsCase, choice = -1;
            Vehicle vh;
            if (distanceInKm > 0 && distanceInKm <= 1) { Console.WriteLine("Sorry!! We couldn't find perfect vehicle for you. You may Prefer walking."); }
            else { 
                if (distanceInKm < 10) { optionsCase = 1; }
                else if (distanceInKm < 30) { optionsCase = 2; }
                else if (distanceInKm < 60) { optionsCase = 3; }
                else /*if (distanceInKm < 60)*/ { optionsCase = 4; }

                switch(optionsCase)
                {
                    case 1:
                        {
                            int[] a = { 102, 103 };
                            Console.WriteLine("We have Found 2 Options. Please Select:");
                            Console.WriteLine("102. BIKE \n103. RICKSHAW");
                            choice = checkAndReadInput(a);
                            break;
                        }
                    case 2:
                        {
                            int[] a = { 101, 102, 103, 104 };
                            Console.WriteLine("We have Found 4 Options. Please Select:");
                            Console.WriteLine("101. BUS \n102. BIKE \n103. RICKSHAW \n104. SEDAN");
                            choice = checkAndReadInput(a);
                            break;
                        }
                    case 3:
                        {
                            int[] a = { 101, 102, 104 };
                            Console.WriteLine("We have Found 3 Options. Please Select:");
                            Console.WriteLine("101. BUS \n102. BIKE \n104. SEDAN");
                            choice = checkAndReadInput(a);
                            break;
                        }
                    case 4:
                        {
                            int[] a = { 101, 104 };
                            Console.WriteLine("We have Found 2 Options. Please Select:");
                            Console.WriteLine("101. BUS \n104. SEDAN");
                            choice = checkAndReadInput(a);
                            break;
                        }

                }

                switch (choice)
                {
                    case (int)VType.BUS:
                        {
                            vh = new Bus();
                            vh.vehicleSound();
                            vh.finalFare(distanceInKm);
                            break;
                        }
                    case (int)VType.BIKE:
                        {
                            vh = new Bike();
                            vh.vehicleSound();
                            vh.finalFare(distanceInKm);
                            break;
                        }
                    case (int)VType.RICKSHAW:
                        {
                            vh = new Rickshaw();
                            vh.vehicleSound();
                            vh.finalFare(distanceInKm);
                            break;
                        }
                    case (int)VType.SEDAN:
                        {
                            vh = new Sedan();
                            vh.vehicleSound();
                            vh.finalFare(distanceInKm);
                            break;
                        }
                }
            }

        }

    }
}
