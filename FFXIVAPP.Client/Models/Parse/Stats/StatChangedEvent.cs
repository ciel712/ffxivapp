// FFXIVAPP.Client
// StatChangedEvent.cs
// 
// � 2013 Ryan Wilson

#region Usings

using System;

#endregion

namespace FFXIVAPP.Client.Models.Parse.Stats
{
    public class StatChangedEvent : EventArgs
    {
        #region Property Bindings

        private Stat<decimal> SourceStat { get; set; }
        public object PreviousValue { get; private set; }
        public object NewValue { get; private set; }

        #endregion

        /// <summary>
        /// </summary>
        /// <param name="sourceStat"> </param>
        /// <param name="previousValue"> </param>
        /// <param name="newValue"> </param>
        public StatChangedEvent(object sourceStat, object previousValue, object newValue)
        {
            SourceStat = (Stat<decimal>) sourceStat;
            PreviousValue = previousValue;
            NewValue = newValue;
        }
    }
}
