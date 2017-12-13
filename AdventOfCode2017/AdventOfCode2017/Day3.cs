﻿using System;

namespace AdventOfCode2017
{
    /// <summary>
    /// Each square on the grid is allocated in a spiral pattern starting at a location marked 1 and then counting up while spiraling outward.
    /// For example, the first few squares are allocated like this: 
    /// 17  16  15  14  13
    /// 18   5   4   3  12
    /// 19   6   1   2  11
    /// 20   7   8   9  10
    /// 21  22  23---> ...
    /// 
    /// While this is very space-efficient (no squares are skipped), requested data must be carried back to square 1 
    /// (the location of the only access port for this memory system) by programs that can only move up, down, left, or right. 
    /// They always take the shortest path: the Manhattan Distance between the location of the data and square 1.
    /// 
    /// For example: 
    ///     Data from square 1 is carried 0 steps, since it's at the access port.
    ///     Data from square 12 is carried 3 steps, such as: down, left, left.
    ///     Data from square 23 is carried only 2 steps: up twice.
    ///     Data from square 1024 must be carried 31 steps. 
    /// How many steps are required to carry the data from the square identified in your puzzle input all the way to the access port?
    /// </summary>
    public class Day3 : DayBase
    {
        public override string Calculate()
        {
            /* 
             * Soooo, it goes like this:
             * 0 - 1
             * 12121212 - 8 (4*2)		    min = 1, max = 2
             * 3234323432343234 - 16 (4*4)	min = 2, max = 4
             *                  - 24 (4*6)	min = 3, max = 6
             *                  - 32 (4*8)  min = 4, max = 8
             */
            throw new NotImplementedException();
        }
    }
}