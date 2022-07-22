using System.Collections.Generic;

namespace mvc_test
{
    public class Layout
    {

        public List<Locomotive> Locomotives
        {
            get
            {
                return _locomotives;
            } 
            set
            {
                _locomotives = value;
            }
        }

        public List<Turnout> Turnouts
        {
            get
            {
                return _turnouts;
            } 
            set
            {
                _turnouts = value;
            }
        }

        private List<Turnout> _turnouts = new List<Turnout>();
        private List<Locomotive> _locomotives = new List<Locomotive>();

        public Locomotive GetLocomotive(int id)
        {
            return _locomotives.Find(x => x.Id == id);
        }
    }
} 