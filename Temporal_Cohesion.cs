using System,
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionTopic{
    class Temporal_Cohesion{
        string getTimel
        string getSysName;
        public Temporal_Cohesion(){
            //initializing with System name and current time.
            getSystemName();
            getSystemTime();
        }

        private void getSystemName(){
            getSysName = Environment.MachineName.ToString();
        }

        private void getSystemTime(){
            getTime = DateTime.Now.ToString();
        }
    }
}