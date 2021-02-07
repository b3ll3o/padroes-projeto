using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ReguladorStatus : IControladorStatus
    {
        public ReguladorStatus()
        {
            SetNewStatus(new Inicial());
        }

        public Status Status { get; private set; }

        public void Handle()
        {
            Status.Handle(this);
        }

        public void SetNewStatus(Status status)
        {
            Status = status;
        }
    }
}
