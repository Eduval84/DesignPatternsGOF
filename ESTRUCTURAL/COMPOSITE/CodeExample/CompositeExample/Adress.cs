using System.Collections.Generic;

namespace CompositeExample
{
    class Adress : INode
    {

        private string _name;
        private List<PhoneNos> _phoneNos = new List<PhoneNos>();

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public void Add(object o)
        {
            _phoneNos.Add((PhoneNos)o);
        }

        public List<PhoneNos> connectedNode
        {
            get
            {
                return _phoneNos;
            }
        }
    }
}
