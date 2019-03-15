using System;
using EngineClasses.OutputElementsClasses;

namespace EventClasses.UserEventArgs
{
    public class MessageEventArgs : EventArgs
    {

        public readonly string message;
        public MessageEventArgs(string message)
        {
            this.message = message;
        }
    }
    public class ListCheckedEventArgs : EventArgs
    {

        public readonly string message;
        public readonly bool checkState;
        public ListCheckedEventArgs(string message, bool state)
        {
            this.message = message;
            checkState = state;
        }
    }
    public class TypeEventArgs : EventArgs
    {
        public readonly OutputType type;
        public TypeEventArgs(OutputType type)
        {
            this.type = type;
        }
    }
    public class UserEventArgs<T> : EventArgs
    {
        public readonly T item;
        public UserEventArgs(T item)
        {
            this.item = item;
        }
    }
    public class InputsEventArgs : EventArgs
    {
        public readonly double c9;
        public readonly double km;
        public readonly double k2;
        public readonly double ll;
        public readonly double mrr;
        public readonly double ke;
        public readonly double dd;

        public InputsEventArgs(double c9, double km, double k2, double ll, double mrr, double ke, double dd)
        {
            this.c9 = c9;
            this.km = km;
            this.k2 = k2;
            this.ll = ll;
            this.mrr = mrr;
            this.ke = ke;
            this.dd = dd;
        }
    }
    public class ExpParsEventArgs : EventArgs
    {
        public readonly int size;
        public readonly int layers;
        public readonly int iterations;
        public ExpParsEventArgs(int size, int layers, int iterations)
        {
            this.size = size;
            this.layers = layers;
            this.iterations = iterations;
        }
    }
}
