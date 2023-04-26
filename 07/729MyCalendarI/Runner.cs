using System;
using System.Collections.Generic;

namespace LeetCodeTasks._729MyCalendarI
{
    public class Runner
    {
        public void Run()
        {
            var myCalendar = new MyCalendar();
            var result = new List<bool>();
            result.Add(myCalendar.Book(10, 20)); // return True
            result.Add(myCalendar.Book(15, 25)); // return False, It can not be booked because time 15 is already booked by another event.
            result.Add(myCalendar.Book(20, 30)); // return True, The event can be booked, as the first event takes every time less than 20, but not including 20.
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
