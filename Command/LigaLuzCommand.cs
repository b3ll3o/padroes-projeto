﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class LigaLuzCommand : ICommand
    {
        private Luz _luz;

        public LigaLuzCommand(Luz luz)
        {
            _luz = luz;
        }

        public string Execute()
        {
            return _luz.Liga();
        }
    }
}
