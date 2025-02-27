//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CarParkingManagementProject
//{
//    internal class test
//    {
//        static void Main(string[] args)
//        {

//            Infor a = new Infor("VoVanNgan", "123", "1", "Nam", new DateTime(2000, 8, 11));
//            Infor b = new Infor("VoVanNgan", "13", "2", "Nu", new DateTime(2000, 8, 21));
//            Infor c = new Infor("VoVanNgan", "123", "3", "Nam", new DateTime(2005, 8, 22));
//            Infor d = new Infor("LinhTrung", "081234213", "4", "Nam", new DateTime(2005, 4, 10));
//            Manager manager = new Manager("Long", a);
//            Attendant attendant = new Attendant("Hoang", b, new DateTime(2022, 10, 2));
//            Customer customer = new Customer("Hieu", c, "74A 4747474", "Gray", "Koeniggseg", new DateTime(2024, 11, 21, 10, 30, 1), new DateTime(2024, 11, 21, 12, 30, 1), Settings.TYPE_CAR);
//            Customer customer2 = new Customer("Hoang", d, "74A 4747474", "White", "Porches", new DateTime(2024, 11, 21, 10, 30, 1), new DateTime(2024, 11, 21, 12, 30, 1), Settings.TYPE_CAR);
//            Console.WriteLine("----CUSTOMER---");
//            customer.PrintDetails();
//            customer2.PrintDetails();

//            attendant.ParkCar(customer.Type, customer.Infor.ID);
//            attendant.AddCustomer(customer);
//            attendant.RetrieveCar(customer.Type, customer.Infor.ID);
//            customer.HandlePayment("Momo", 90);
//            customer.AddFeedBack("Hieu dep trai vcl, Hoang thi ngu");
//            customer2.AddFeedBack("Giu xe nhu con cac");
//            customer.ParkCar(customer.Type, customer.Infor.ID);
//            customer.RetrieveCar();
//            Console.WriteLine("-------------");
//            customer2.ParkCar(2, 2);
//            customer2.HandlePayment("CK", 200);
//            customer2.RetrieveCar();
//            manager.ViewReports("feedback", new DateTime(2024, 11, 11, 10, 30, 1), new DateTime(2024, 12, 21, 11, 30, 1));
//            manager.AddParkingSpace(10, 10, Settings.TYPE_CAR);
//            Console.WriteLine("-----------");
//            Settings.BAI_XE_OTO.ShowSpace();
//            manager.RemoveParkingSpace(5, 5, Settings.TYPE_CAR);
//            Settings.BAI_XE_OTO.ShowSpace();
//            Console.WriteLine("----------------------");
//            manager.UpdateParkingSpace(3, 3, Settings.TYPE_CAR, "lamtrong");
//            Settings.BAI_XE_OTO.ShowSpace();
//            Console.WriteLine(Settings.KHACH_HANG.Count());

//        }
//    };
//}
