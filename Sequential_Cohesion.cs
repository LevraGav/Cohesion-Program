using System,
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionTopic{
    class GradeCalculator{
        public double ResultChecker(int Obtain_Marks, int Total_Marks){
            double Percentage = (Obtain_Marks / Total_Marks) * 100;
            return Percentage;
        }

        public string GradeDecider(){
            double percentage = ResultChecker(50, 100);
            string grade = "";
            if(percentage > 80){
                grade = "A";
            }

            else if(percentage > 60 && percentage < 80){
                grade = "B";
            }

            else if(percentage < 50){
                grade = "C";
            }
            return grade;
        }

        public void Remarks(){
            string GRADE = GradeDecider();
            string Remarks;

            if(GRADE == "A"){
                Remarks = "Excellent Work!";
            }

            else if(GRADE == "B"){
                Remarks = "Good Work!";
            }

            else if(GRADE == "C"){
                Remarks = "Need to Work!";
            }
        }
    }
}