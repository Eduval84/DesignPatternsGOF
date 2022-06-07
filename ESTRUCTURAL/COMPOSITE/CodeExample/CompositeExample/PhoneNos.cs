using System;
using System.Collections.Generic;

namespace CompositeExample
{
    internal class PhoneNos: INode
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public void Add(object o)
        {
            throw new NotImplementedException();
        }

        public List<INode> connectedNode
        {
            get { return null; }
        }
    }
}