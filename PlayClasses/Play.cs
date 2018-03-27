using MP3Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player.PlayClasses
{
    abstract class Play : IPlayer
    {
        public abstract void PlayTrack();
    }
}
