using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1.Method
{
    public class DoubleLink
    {
        public DoubleLink(int NodeValue)
        {
            Value = NodeValue;
        }
        public DoubleLink Next { get;  set; }
        public DoubleLink Previous { get;  set; }
        public int Value { get; set; }

        public bool IsHead
        {
            get { return Previous == null; }
        }

        public bool IsTail
        {
            get { return Next == null; }
        }

        public DoubleLink FindBy(int value)
        {
            DoubleLink temp = new DoubleLink(value);
            if (value ==this.Value)
            {
                temp = this;
            }
            return temp;
        }

        public void InsertAfter(DoubleLink node)
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

        public void InsterBefore(DoubleLink node)
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
                DoubleLink temp = this.Previous;
                temp.Next = null;
            }
            else if (this.IsHead)
            {
                DoubleLink temp = this.Next;
                temp.Previous = null;
            }
            else
            {
                DoubleLink temp1 = this.Previous;
                DoubleLink temp2 = this.Next;
                temp1.Next = temp2;
                temp2.Previous = temp1;
            }
        }

        public void Swap(DoubleLink a, DoubleLink b)
        {
            if (a==b)
            {
                throw new Exception("Cannot Swap!");
            }

            DoubleLink beforeA = a.Previous;
            DoubleLink afterA = a.Next;

            DoubleLink beforeB = b.Previous;
            DoubleLink afterB = b.Next;



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
    }
}
