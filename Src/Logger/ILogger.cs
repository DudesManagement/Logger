using System;
using System.Collections.Generic;
using System.Text;

namespace Dudes.Logger
{
    public interface ILogger
    {
        void FATAL(string message);
        void ERROR(string message);
        void WARN(string message);
        void DEBUG(string message);
        void INFO(string message);
        void TRACE(string message);
    }
}
