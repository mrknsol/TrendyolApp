using GalaSoft.MvvmLight.Messaging;
using TrendyolApp.Messages;
using TrendyolApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendyolApp.Services.Classes
{
    public class DataService : IDataService
    {
        public readonly IMessenger _messenger;

        public DataService(IMessenger messenger)
        {
            _messenger = messenger;
        }

        
        public void SendData(object data)
        {
            _messenger.Send(new DataMessage()
            {
                Data = data
            });
        }
        public void SendDatas(object[] datas)
        {
            _messenger.Send(new DatasMessage()
            {
                Datas = datas
            });
        }
        
    }
}
