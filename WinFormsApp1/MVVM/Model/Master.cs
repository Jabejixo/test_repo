using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.ComponentModel;

namespace WinFormsApp1.MVVM.Model
{
    public class Master
    {
        [DisplayName("ID")]
        public int MasterId { get; set; }
        [DisplayName("Имя")]
        public string MasterName { get; set; }
        public Master() {}
        public Master(string masterName)
        {
            MasterName = masterName;
        }
        public Master(int masterId ,string masterName)
        {
            MasterId = masterId;
            MasterName = masterName;
        }

    }
}
