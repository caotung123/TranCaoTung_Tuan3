using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls
{
    public class DocFile
    {
        string duongDan;

        public string DuongDan
        {
            get { return duongDan; }
            set { duongDan = value; }
        }
        public DocFile(string duongDan)
        {
            this.duongDan = duongDan;
        }               
    }
}
