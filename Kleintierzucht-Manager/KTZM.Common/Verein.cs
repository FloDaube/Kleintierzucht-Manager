using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTZM.Common
{
    public class Verein
    {
        #region Variablen

        private int _id;
        private string _name;
        private string _tattoo;


        #endregion

        #region Eigenschaften

        public int id { get => _id; private set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        #endregion
    }
}
