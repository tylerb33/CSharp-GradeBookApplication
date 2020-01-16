using GradeBook.Enums;

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
