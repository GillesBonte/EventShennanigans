using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/// BEGIN HERE
/// I made a class Mathmatics with an EventHandler and an Action,
/// just to show the functionality and implementation of each one
///
/// follow this class to see how we make and invoke both events,
/// then jump to Program to see how it can be implemented and executed by devs.


namespace EventShennanigans
{
    public class Mathmatics
    {
        //definition of Event
        public event EventHandler DivisibleBy3;

        //definition of Action with an integer (not required)
        public Action<int> DivisibleBy5;

        //may aswell be:
        //public Action DivisibleBy5;

        public int NumberOne {  get; set; }
        public int NumberTwo { get; set; }

        public int CalculateSum()
        {

            int intResult = 0;
            intResult = NumberOne + NumberTwo;
           //check to invoke the Event
            if (intResult%3 == 0 )
            {
                //With an Eventhandler we need to use parameters (object, Eventargs)
                DivisibleBy3?.Invoke(this, new EventArgs());
            }
            //check to invoke the Action
            if (intResult%5 == 0)
            {
                //With an Action we only need to add parameters of what we have put between <>
                //in this example: Action<int> and we give the result to the mainprogram
                DivisibleBy5?.Invoke(intResult);
                //u may aswell have used Action<int, string, DateTime> or Action<string, int> etc...
            }

            return intResult;

        }

    }

}
