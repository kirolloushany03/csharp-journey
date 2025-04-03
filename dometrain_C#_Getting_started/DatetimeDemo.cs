using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dometrain_C__Getting_started
{
    internal class DatetimeDemo
    {
        public static void Rundate_time()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //jsut to enable emojies 🤫
            // 📌 DateTime, DateOnly, and TimeOnly in C#

            // 🔑 **Introduction**
            // C# provides three structures to handle date and time:
            // 1️⃣ `DateTime`  → Stores both date and time.
            // 2️⃣ `DateOnly`  → Stores only the date (Introduced in .NET 6).
            // 3️⃣ `TimeOnly`  → Stores only the time (Introduced in .NET 6).

            // 📜 Declaring Variables
            DateTime myDateTime; // Stores date and time
            DateOnly myDate;     // Stores only the date
            TimeOnly myTime;     // Stores only the time

            // 📜 Assigning Values
            myDateTime = DateTime.Now;       // Gets current date and time
            myDate = new DateOnly(2024, 12, 04);  // Stores only the date (YYYY, MM, DD)
            myTime = new TimeOnly(1, 23, 23);     // Stores only the time (HH, MM, SS)

            // 📜 Initializing (Declaring and Assigning in One Step)
            DateTime myDateTime2 = DateTime.Now;
            DateOnly myDate2 = new DateOnly(2025, 12, 03);
            TimeOnly myTime2 = new TimeOnly(2, 30, 20);

            // 📜 Re-assigning Values
            myDateTime = DateTime.Now;
            myDate = new DateOnly(2024, 1, 23);
            myTime = new TimeOnly(1, 23, 45);

            // 🧩 **Combining DateOnly and TimeOnly into a DateTime**
            DateTime dateTimeCombination = new DateTime(myDate, myTime);

            // 🖨️ Printing Results
            Console.WriteLine($"📅 Date only: {myDate}");
            Console.WriteLine($"⏰ Time only: {myTime}");
            Console.WriteLine($"📆 Date and Time: {dateTimeCombination}");

        }
    }
}
