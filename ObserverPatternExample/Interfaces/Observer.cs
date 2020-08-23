using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternExample
{
    public interface Observer
    {
        #region public-Methods
        public void Update(bool state);
        #endregion
    }
}
