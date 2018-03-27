using MP3Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player.SearchClasses
{
    abstract class SearchKey : ISearcher
    {
        public abstract void Search();
    }
}
