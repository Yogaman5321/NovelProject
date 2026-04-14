using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelProject
{
    public enum State
    {
        LOGINASGUEST,
        TRYCREDENTIALS,
        SUCCESS,
        FAILEDLOGIN,
        FAILEDCREATE
    }
}
