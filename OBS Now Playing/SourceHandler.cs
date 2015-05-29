﻿using System.Threading.Tasks;

namespace OBS_Now_Playing
{
    abstract class SourceHandler
    {
        string source;
        public SourceHandler() { }

        public SourceHandler(string s)
        {
            source = s;
        }

        public abstract void stop();

        public abstract Task pollForSongChanges();
    }
}