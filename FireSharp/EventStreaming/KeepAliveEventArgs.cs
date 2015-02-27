namespace FireSharp.EventStreaming
{
    using System;

    public class KeepAliveEventArgs : EventArgs
    {
        public KeepAliveEventArgs(bool isAlive)
        {
            this.IsAlive = isAlive;
        }

        public bool IsAlive { get; private set; }
    }
}
