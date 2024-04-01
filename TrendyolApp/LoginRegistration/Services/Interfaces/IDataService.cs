using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendyolApp.Services.Interfaces
{
    interface IDataService
    {
        public void SendData(object data);
        public void SendDatas(object[] datas);

    }
}
