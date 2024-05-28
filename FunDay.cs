using System;
namespace PlayGround
{
    class FunDay
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        private bool _elementaryPlayground;
        public bool ElementaryPlayground
        {
            get
            {
                return _elementaryPlayground;
            }
            set
            {
                if (Age < 5)
                    _elementaryPlayground = false;
                else
                    _elementaryPlayground = true;
            }
        }
    }
}
