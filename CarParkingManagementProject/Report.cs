using System;
using System.Linq;

namespace CarParkingManagementProject
{
    public static class Report
    {
        public static void GenerateOccupancyReport()
        {
            Console.WriteLine("=== Occupancy Report ===");
            Console.WriteLine("Car Parking Status:");
            Settings.BAI_XE_OTO.ShowSpace();
            Console.WriteLine("Motor Parking Status:");
            Settings.BAI_XE_MOTO.ShowSpace();
        }

        public static void GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            double totalRevenue = 0;
            var relevantTickets = Settings.HISTORY_TICKET.Where(ticket =>
            {
                var customer = Settings.HISTORY_KHACH_HANG.FirstOrDefault(c => c.Infor.ID == ticket.IdKhachHang);
                if (customer != null)
                {
                    return customer.TimeIn >= startDate && customer.TimeOut <= endDate;
                }
                return false;
            });

            foreach (var ticket in relevantTickets)
            {
                var customer = Settings.HISTORY_KHACH_HANG.FirstOrDefault(c => c.Infor.ID == ticket.IdKhachHang);
                if (customer != null)
                {
                    totalRevenue +=customer.PricePayment ;
                }

            }
            

            Console.WriteLine($"=== Revenue Report ===");
            Console.WriteLine($"From {startDate.ToShortDateString()} to {endDate.ToShortDateString()}: Total Revenue = {totalRevenue:C}");
        }

        public static void GenerateCustomerFeedbackReport()
        {
            Console.WriteLine("=== Customer Feedback Report ===");
            // Giả định phản hồi được lưu trữ trong danh sách tĩnh
            var feedbacks = Settings.FEEDBACK; 
            if (feedbacks.Count == 0)
            {
                Console.WriteLine("No feedback available.");
            }
            else
            {
                foreach (var feedback in feedbacks)
                {
                    Console.WriteLine(feedback);
                }
            }
        }
    }
}
