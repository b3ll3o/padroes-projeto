using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ReguladorStatus : IControladorStatus
    {
        public Status _status;

        public ReguladorStatus()
        {
            SetNewStatus(new Inicial());
        }

        public void Handle()
        {
            _status.Handle(this);
        }

        public void SetNewStatus(Status status)
        {
            _status = status;
        }
    }
}
