using System;

namespace Proxy
{
    public class People
    {
        private ProxyThink _think;

        public People(ProxyThink think)
        {
            _think = think;
        }

        public void WakeUp()
        {
            _think.ThinkSmall();
        }

        public void InWork()
        {
            _think.ThinkDeep();
        }
    }

    public interface IThink
    {
        void ThinkDeep();
        void ThinkSmall();
    }

    public class Think : IThink
    {
        private string _veryBigObject;

        public void ThinkDeep()
        {
            if (_veryBigObject != null)
                Console.WriteLine("I think " + _veryBigObject);
            else
            {
                _veryBigObject = ". As very big object";
                Console.WriteLine("I think deep" + _veryBigObject);
            }
        }

        public void ThinkSmall()
        {
            Console.WriteLine("I thing very small");
        }
    }

    public class ProxyThink : IThink
    {
        private readonly Think _think;

        public ProxyThink(Think think)
        {
            _think = think;
        }

        public void ThinkDeep()
        {
            _think.ThinkDeep();
        }

        public void ThinkSmall()
        {
            _think.ThinkSmall();
        }
    }
}
