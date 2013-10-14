// FFXIVAPP.Client
// NumericStat.cs
// 
// � 2013 Ryan Wilson

#region Usings

using FFXIVAPP.Client.Plugins.Parse.Models.Stats;

#endregion

namespace FFXIVAPP.Client.Plugins.Parse.Models.LinkedStats
{
    public class NumericStat : Stat<decimal>
    {
        public NumericStat(string name, decimal value) : base(name, 0m)
        {
        }

        public NumericStat(string name) : base(name, 0m)
        {
        }
    }
}
