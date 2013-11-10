using System;

namespace RxDemo
{

    public class StatInfoItem
    {
        public long Count { get; set; }
        public double Mean { get; set; }
        protected internal double M2;
        public double StdDev { get; set; }
        public double Sum { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
    }

    public class StatInfoItem<T> : StatInfoItem
    {
        public StatInfoItem()
        {
            Item = default(T);
        }
        public T Item { get; set; }
    }
}
