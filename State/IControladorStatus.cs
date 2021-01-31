using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface IControladorStatus
    {
        void SetNewStatus(Status status);
    }
}
