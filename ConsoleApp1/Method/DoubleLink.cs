using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1.Method
{
    public class DoubleLink<T> : IEnumerable<T>
    {
        public DoubleLink(T NodeValue)
        {
            Value = NodeValue;
        }
        public DoubleLink<T> Next { get;  set; }
        public DoubleLink<T> Previous { get;  set; }
        public T Value { get; set; }

        public bool IsHead
        {
            get { return Previous == null; }
        }

        public bool IsTail
        {
            get { return Next == null; }
        }

        public DoubleLink<T> FindBy(T value)
        {
            DoubleLink<T> temp = new DoubleLink<T>(value);
            if (this.Value.Equals(value))
            {
                temp = this;
            }
            return temp;
        }

        public void InsertAfter(DoubleLink<T> node)
        {
            
            if (node.Next == null)
            {
                node.Next = this;
                this.Previous = node;
                this.Next = null;
            }
            else
            {
                this.Next = node.Next;
                this.Previous = node;
                node.Next = this;
                this.Next.Previous = this;
            }
        }

        public void InsterBefore(DoubleLink<T> node)
        {
            if (node.Previous==null)
            {
                this.Previous = null;
                this.Next = node;
                node.Previous = this;
            }
            else
            {
                this.Previous = node.Previous;
                this.Next = node;
                node.Previous = this;
                this.Previous.Next = this;
            }
        }

        public void Delete()
        {
            if (this.IsHead&&this.IsTail)
            {
                throw new Exception("Cannot delete last node!");
            }
            else if (this.IsTail)
            {
                DoubleLink<T> temp = this.Previous;
                temp.Next = null;
            }
            else if (this.IsHead)
            {
                DoubleLink<T> temp = this.Next;
                temp.Previous = null;
            }
            else
            {
                DoubleLink<T> temp1 = this.Previous;
                DoubleLink<T> temp2 = this.Next;
                temp1.Next = temp2;
                temp2.Previous = temp1;
            }
        }

        public void Swap(DoubleLink<T> a, DoubleLink<T> b)
        {
            if (a==b)
            {
                throw new Exception("Cannot Swap!");
            }

            DoubleLink<T> beforeA = a.Previous;
            DoubleLink<T> afterA = a.Next;

            DoubleLink<T> beforeB = b.Previous;
            DoubleLink<T> afterB = b.Next;



            b.Delete();
            b.InsertAfter(a);

            a.Delete();
            if (beforeB == null)
            {
                a.InsterBefore(afterB);
            }
            else
            {
                if (afterA == b)
                {
                    a.InsertAfter(b);
                }
                else
                {
                    a.InsertAfter(beforeB);
                }
            }


        }


        

        public IEnumerator<T> GetEnumerator()
        {
            return new DoubleLinkIEnumerable(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public class DoubleLinkIEnumerable : IEnumerator<T>
        {
            private DoubleLink<T> _node;
            int position;
            int number;

            public DoubleLinkIEnumerable(DoubleLink<T> node)
            {
                number ++;
                _node = node;
                position = -1;
            }
            //public DoubleLink<T> Current { get; set; }
            public T Current { get { return _node.Value; } }
            object IEnumerator.Current => throw new NotImplementedException();

            //T IEnumerator<T>.Current => throw new NotImplementedException();

            public bool MoveNext()
            {
                //bool result = _node != null;
                if (_node != null)
                {
                    position++;
                    _node = _node.Next; 
                }
                //return result;
                return position <= number;
                

            }
            public void Dispose()
            {
                //position = -1;

                //_node.Next = _node;
                //throw new NotImplementedException();
            }

            public void Reset()
            {
                //position = -1;

                //throw new NotImplementedException();
            }
        }
    }


}
