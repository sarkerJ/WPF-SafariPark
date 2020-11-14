using System;
using System.Collections.Generic;

namespace SafaryPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //var martin = new Person("Martin", "Beard") { Age = 25};

            //Person curtis; //simply declaring it so it is currently null
            //curtis = new Person("Curtis", "Beavan");
            //curtis.Age = 23;
            //martin.Age = -5; //this won't work because the if statement does not allow it, therefore it remains 25


            //Console.WriteLine(martin.GetFullName());
            //Console.WriteLine(martin.Age);
            //Console.WriteLine(curtis.GetFullName());
            //Console.WriteLine(curtis.Age);

            //var sList = new ShoppingList(){Bread = 2, Butter = 5, Eggs = 12, Milk = 3};
            //Console.WriteLine(sList.Bread);
            //sList.Bread = 3;
            //Console.WriteLine(sList.Bread);

            //Person sarker = new Person("Sarker", "Islam") { Age = 100 };
            //Point3D pt3d = new Point3D(5, 8, 2);
            //Console.WriteLine($"Sarker's Age Before: {sarker.Age}");
            //Console.WriteLine($"ptrd y: {pt3d.y}");
            //Demo(pt3d, sarker); //pt3d

            //Console.WriteLine($"Sarker's Age After: {sarker.Age}");
            //Console.WriteLine($"ptrd y: {pt3d.y}"); // still 8 because 1000 was never returned 


            //var myV = new Vehicle(5, 40);
            //myV.NumPassengers = 5;
            //Console.WriteLine(myV.NumPassengers);
            //Console.WriteLine(myV.Position);
            //Console.WriteLine(myV.Move());
            //Console.WriteLine(myV.Position);


            //var myV2 = new Vehicle();
            //Console.WriteLine(myV2.Position);
            //Console.WriteLine(myV2.Move(7));
            //Console.WriteLine(myV2.Position);

            //Hunter h = new Hunter("Monster", "Hunter", "Leica") { Age = 30}; //hunter has inherited the age property from the Person class
            //Console.WriteLine(h.Age);
            //Console.WriteLine(h.Shoot()); //gets thefull name from Person class and adds the rest of the info from the Shoot method

            //Hunter h2 = new Hunter();
            //Console.WriteLine(h2.Shoot());

            //Hunter h = new Hunter("Monster", "Hunter", "Leica") { Age = 30 }; //hunter has inherited the age property from the Person class
            //Hunter h2 = new Hunter("Martin", "Beard");
            //Hunter h3 = new Hunter("Monster", "Hunter", "Leica") { Age = 30 };// if you use Equals on this + h IT is still FALSE (due to hashcode being different) Equals checks the hashcode for objects 


            //Console.WriteLine(h.Equals(h2));
            //Console.WriteLine(h.GetHashCode());
            //Console.WriteLine(h2.GetHashCode());
            //Console.WriteLine(h.GetType());
            //Console.WriteLine(h2.ToString()); //this also returns the getType result

            //Console.WriteLine(h.ToString());

            //Airplane mine = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150};
            //Airplane mine = new Airplane(200) { NumPassengers = 150 };

            //mine.Ascend(500);
            //Console.WriteLine(mine.Move(3));
            //Console.WriteLine(mine);
            //mine.Descend(200);
            //Console.WriteLine(mine.Move());
            //mine.Move();
            //Console.WriteLine(mine);

            ////Makint a list of objects
            //var x = new Person("Nish", "Mandal");
            //List< Object> gameObjects = new List<object>() //all objectss can be stored, if you instead say <Person> then only Person objects can be saved
            //{
            //    x,
            //    new Airplane(400,200, "Boeing"),
            //    new Vehicle(12,30),
            //    new Hunter("Hunter", "Beard", "Pentax")
            //};

            //foreach(var item in gameObjects)
            //{
            //    Console.WriteLine(item); //prints the value in ToString() from each object
            //}


            //sending objects as paramater //// play around with it !
            //Person joel = new Person("Joel", "Docker");
            //Hunter rob = new Hunter("Robert", "Bentley", "Nikon");

            //var o = new Object();

            //SpartaWrite(rob);
            //SpartaWrite(joel);

            //you can cast down the object rank BUT NOT UP

            //List<IMoveable> movableObjects = new List<IMoveable>()
            //{
            //      new Person("Nish", "Mandal"),
            //      new Vehicle(12,30),
            //      new Hunter ("Sarker", "Islam", "Nikon"),
            //      new Airplane(200, 300, "Boeing")
            //};

            //foreach(IMoveable item in movableObjects)
            //{
            //    //Console.WriteLine(item.Move());
            //    Console.WriteLine(item.Move(2));

            //}

            /*List<IShootable> shootableList = new List<IShootable>()
            {
                new LaserGun("Acme"),
                new WaterPistol("SuperSoaker"),
                new LaserGun("LaserKing9001"),
                new WaterPistol("WaterGunBeta199"),
                new Camera("Nixon"),
                new Camera ("Cam900")
            };*/

            //List<Hunter> hunterList = new List<Hunter>()
            //{
            //    new Hunter("Sarker", "Islam", "Camera100"),
            //    new Hunter("Alex", "Marks", "Nixon"),
            //    new Hunter("Nish", "Mandal", "Camera900"),


            //};

            /*foreach (IShootable item in shootableList)
            {
                Console.WriteLine(item.Shoot());
            }*/

            Camera pentax = new Camera("Pentax");
            WaterPistol pistol = new WaterPistol("Supersoaker");
            LaserGun lasergun = new LaserGun("Acme");
            //Hunter nish = new Hunter("Nish", "Mandal", pentax);
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = pistol;          //since pistol uses the interface Ishootable we can assign shooter to pistol.
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = lasergun;
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = pistol;
            //Console.WriteLine(nish.Shoot());

            List<Hunter> hunterList = new List<Hunter>(){
                new Hunter("Sarker", "Islam", pentax),
                new Hunter("Martin", "Beard", lasergun),
                new Hunter("Alex", "Griffin", pistol),
                new Hunter("Alex", "Marks", lasergun),
                new Hunter("Oliver", "Tomkins", lasergun),
                new Hunter("James", "Smith", lasergun)


            };

            Ranger nish = new Ranger("Nish", "Mandal", pistol);
            Console.WriteLine(nish);

            foreach (Hunter item in hunterList)
            {Console.WriteLine(nish.ShootAt(item));}

            Console.WriteLine();

            Vaccine vaccine = new Vaccine("Blood101");
            Bandages bandages = new Bandages("RBandages");
            Ranger nish2 = new Ranger("Nish", "Mandal", pistol, bandages);
            Console.WriteLine(nish2.Heal());
            nish2.Healing = vaccine;
            Console.WriteLine(nish2.Heal());

        }

        //public static void SpartaWrite(Object obj) //passing an object as a parameter ////can only access methods on the base object class not on the person or hunter class
        //{                                           // to access the methods of a person or hunter the parameter should be Person obj or Hunter obj

        //    Console.WriteLine(obj.ToString()); //can only access the ToString() only similar to GetType but test it to make sure
        //    Console.WriteLine(obj.GetType());

        //    if (obj is Hunter) //is = is of Type Hunter
        //    {
        //        var hunterObj = (Vehicle)obj;         //casting the object class to a hunter class
        //        Console.WriteLine(hunterObj.Move());     //now we can use the hunter methods
        //    }

        //}

        //static void Demo(Point3D pt, Person p)
        //{
        //    pt.y = 1000; //from 8 to 1000 //but the pt3d= y is still 8! because STRUCT is VALUE CASE 
        //    p.Age = 90; //from 100 to 90  //CLass is reference type
        //}
    }
}
