using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Services.ResponseDTO
{
    public class ResponseBase<TData> where TData : new()
    {
        public int responsecode { get; set; }
        public string responsemsg { get; set; }
        public TData data { get; set; }

        public ResponseBase()
        {
            data = new TData();
        }
    }
}
