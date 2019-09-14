﻿// VTuple.cs created by Iron Wolf for Pawnmorph on 09/12/2019 1:00 PM
// last updated 09/12/2019  1:00 PM

namespace Pawnmorph.Utilities
{
    //value tuples 

    public struct VTuple<TFirst, TSecond>
    {
        public VTuple(TFirst first, TSecond second)
        {
            this.first = first;
            this.second = second; 
        }

        public TFirst first;
        public TSecond second; 
    }

    public struct VTuple<TFirst, TSecond, TThird>
    {
        public VTuple(TFirst first, TSecond second, TThird third)
        {
            this.first = first;
            this.second = second;
            this.third = third; 
        }
        public TFirst first;
        public TSecond second;
        public TThird third; 
    }
}