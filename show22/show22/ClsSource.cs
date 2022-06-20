using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace show22
{
    class ClsSource: List<ClsDataDesign>
    {
        public ClsSource() {
            this.Add(new ClsDataDesign("P001", "ABC beer", 100, 22.5));
            this.Add(new ClsDataDesign("P002", "Tiger beer", 100, 20.5));
            this.Add(new ClsDataDesign("P003", "Anchor beer", 100, 15.5));
            this.Add(new ClsDataDesign("P004", "cocacola", 100, 8.5));
        }
    }
}
