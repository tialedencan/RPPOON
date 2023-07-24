using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Cart
    {
        private List<IItem> items;
        private IVisitor visitor;

        public Cart(IVisitor visitor)
        {
            this.items = new List<IItem>();
            this.visitor = visitor;
        }
        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
        public void SetVisitor(IVisitor visitor)
        {
            this.visitor = visitor;
        }
        public double Accept()
        {
            double sum = 0;
            foreach (IItem item in this.items)
            {
                sum += item.Accept(visitor);
            }
            return sum;
        }

    }
}
