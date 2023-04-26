﻿namespace LeetCodeTasks._190ReverseBits
{
    public class ReverseBitsClass
    {
        public uint reverseBits(uint n)
        {
            uint res = 0;
            for (var i = 0; i < 32; i++)
            {
                uint bit = (n >> i) & 1;
                res |= bit << (31 - i);
            }

            return res;
        }
    }
}