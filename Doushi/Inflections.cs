using System;
using System.Collections.Generic;
using System.Text;

namespace Doushi
{
    public class Inflections
    {
        public Polarity NonPast { get; internal set; }
        public Polarity NonPastPolite { get; internal set; }
        public Polarity Past { get; internal set; }
        public Polarity PastPolite { get; internal set; }
        public Polarity TeForm { get; internal set; }
        public Polarity Potential { get; internal set; }
        public Polarity Passive { get; internal set; }
        public Polarity Causative { get; internal set; }
        public Polarity CausativePassive { get; internal set; }
        public Polarity Imperative { get; internal set; }
        public Type Type { get; internal set; }
    }
}
