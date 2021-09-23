using System,
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionTopic{
    class ProceduralCohesion{
        int marks_1 = 25;
        int marks_2 = 24;
        int Total = 0;
        
        public int TotalNumbers(){
            Total = marks_1 + marks_2;
            return Total;
        }

        public int average(){
            int TotalMarks = TotalNumbers();
            return (TotalMarks / 25) * 100;
        }

        public string Status(){
            string status_p_f = "";
            if (average() > 50){
                status_p_f = "Pass";
            }
            return status_p_f;
        }
    }
}