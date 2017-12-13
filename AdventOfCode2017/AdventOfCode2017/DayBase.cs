namespace AdventOfCode2017
{
    public abstract class DayBase
    {
        public string ClassName => GetType().Name;
        public abstract string Calculate();
    }
}