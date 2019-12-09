using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    class DoubleLink
    {
        public DoubleLink next { get; private set; }
        public DoubleLink previous { get; private set; }

        public bool Ishead
        {
            get { return previous == null; }
        }
        public bool Istail
        {
            get { return next == null; }
        }

        public DoubleLink findBy(int value)
        {
            return null;
        }
        public void insertAfter(DoubleLink node)
        {

        }
        public void insterBefore(DoubleLink node)
        {

        }
        public void delete()
        {

        }
        public void swap(DoubleLink a, DoubleLink b)
        {

        }
    }
}
