using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frog
{
    class Lake : IEnumerable<int>
    {
        private List<int> stoneNumbers;

        public Lake(List<int> stoneNumbers)
        {
            this.stoneNumbers = new List<int>(stoneNumbers);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i <= stoneNumbers.Count - 1; i++)
            {

                if (stoneNumbers[i] % 2 == 1)
                {
        
                    yield return stoneNumbers[i];
                }
            }
        }

        public IEnumerable<int> Enumerator()
        {
            for (int i = stoneNumbers.Count - 1; i >= 0; i--)
            {
                if (stoneNumbers[i] % 2 == 0)
                {
                    stoneNumbers.Sort();
                    yield return stoneNumbers[i];
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
