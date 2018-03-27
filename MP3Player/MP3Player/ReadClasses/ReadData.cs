using MP3Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player.ReadClasses
{
    abstract class ReadData : IReader
    {
        public abstract void ReadInput();
    }
}
