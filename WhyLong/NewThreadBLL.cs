using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WhyLong
{
    class NewThreadBLL
    {
        NewThreadDAL dalNewThread;
        public NewThreadBLL()
        {
            dalNewThread = new NewThreadDAL();
        }
        public DataTable getAllNewThread()
        {
            return dalNewThread.getAllNewThread();
        }
    }
}
