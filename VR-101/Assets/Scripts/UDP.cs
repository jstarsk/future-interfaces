using System;
using System.Collections;
using System.Collections.Generic;
namespace UDP
{
    [Serializable]
    public class UDPManagermsg
    {
        public virtual IList<IList<IList<float>>> data { get; set; }
        public UDPManagermsg() { }
    }
}
