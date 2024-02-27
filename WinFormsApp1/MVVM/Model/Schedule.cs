using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.ComponentModel;

namespace WinFormsApp1.MVVM.Model
{
    public class Schedule 
    {

        public Schedule(int masterId, int serviceId, DateTime date, TimeSpan time, int userId)
        {
            MasterId = masterId;
            ServiceId = serviceId;
            Date = date;
            Time = time;
            UserId = userId;
        }
        public Schedule(int scheduleId,int masterId, int serviceId, DateTime date, TimeSpan time, int userId)
        {
            ScheduleId = scheduleId;
            MasterId = masterId;
            ServiceId = serviceId;
            Date = date;
            Time = time;
            UserId = userId;
        }
        public Schedule() {}
        [Catel.ComponentModel.DisplayName("ScheduleId")]
        public int ScheduleId { get; set; }
        [Catel.ComponentModel.DisplayName("MasterId")]
        public int MasterId { get; set; }
        public int ServiceId { get; set; }
        [Catel.ComponentModel.DisplayName("UserId")]
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }



        // Навигационные свойства
        [Browsable(false)]
        public Master Master { get; set; }
        [Browsable(false)]
        public Service Service { get; set; }
    }
}
