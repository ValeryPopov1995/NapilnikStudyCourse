// remove unused unigs

namespace NapilnikStudyCourse.CleanCode
{
    // using in namespace
    using System;

    // use code analizator
    // change settnigs of code analizator according with company rules
    class Standard
    {
        // I public signatures
        // II private

        // 1 field
        // 2 events
        // 3 property
        // 4 constructor

        public int Value = 3; // capital char

        private int _value; // _ small char

        public event Action ChangeValue;

        public int CurrentValue
        {
            get { return _value; }
        }
        
        public Standard(int value) // small char in argument
        {
            _value = value;
        }

        public void DoWork()
        {
            // no magic values
            for (int i = 0; i < _value; i++)
                Console.WriteLine("do working"); // another line
        }

        // TrySomthing not exclude negative answer
        public bool TryTakeDamage(int damage)
        {
            if (_value > 0)
            {
                if (_value > damage)
                    _value -= damage; // another line
                else
                    _value = 0;

                return true;
            }

            return false;
        }

        // GetSomthing() return value
        public int GetValue()
        {
            return _value;
        }
    }
}
