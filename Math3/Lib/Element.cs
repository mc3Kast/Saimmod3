using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3.Lib
{
    public class Element
    {
        public static Action<Element, Element, Vocation> OnVocationCreated;
        public static Action<Element, Element> OnBlockPrevious;

        protected Element sender;
        protected Element reciever;
        protected TraficCounter counter;
        protected Vocation vocation;

        protected bool isBusy = false;


        public Vocation Vocation
        {
            get
            {
                return vocation;
            }
        }


        public virtual TraficCounter TraficCounter
        {
            get
            {
                return counter;
            }
        }


        public virtual bool IsBusy
        {
            get
            {
                return isBusy;
            }
        }


        public virtual string State
        {
            get
            {
                return "";
            }
        }


        public bool IsProcessed
        {
            get; set;
        }


        public virtual void ProcessTick(bool isFreeNextElement)
        {

        }


        public virtual void VocationLiveTimeIncrement()
        {
            if (vocation != null)
            {
                vocation.Increment();
            }
        }


        public virtual void Init(Element sender, Element reciever, TraficCounter counter = null, Manager manager = null)
        {
            IsProcessed = false;
            this.sender = sender;
            this.reciever = reciever;
            this.counter = counter;
        }
    }
}
