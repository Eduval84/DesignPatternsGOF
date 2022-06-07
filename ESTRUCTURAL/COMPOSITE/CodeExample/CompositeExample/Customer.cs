using System.Collections.Generic;

namespace CompositeExample
{
    class Customer : INode
    {
        private string _name;
        private readonly List<Adress> _adresses = new List<Adress>();

        public string Name
        {
            get { return _name; }
            set => _name = value;
        }
        public void Add(object o)
        {
           _adresses.Add((Adress)o);
        }

        public List<Adress> connectNode
        {
            get { return _adresses; }
        }
    }
}
