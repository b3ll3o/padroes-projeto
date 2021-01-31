using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class DesligaLuzCommand : ICommand
    {
        private Luz _luz;

        public DesligaLuzCommand(Luz luz)
        {
            _luz = luz;
        }

        public void Execute()
        {
            _luz.Desliga();
        }
    }
}
