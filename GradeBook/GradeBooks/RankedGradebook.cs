using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradebook : BaseGradeBook
    {
        public RankedGradebook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
