using System,
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionTopic{
    class CommunicationalCohesion{
        int[] arr = new int[5];

        public void InsertData(){
            for(int i = 0; i <= 4; i++){
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            console.WriteLine("Data Inserted Successfully!");
        }

        public void ShowData(){
            for(int i = 0; i <= 4; i++){
                console.WriteLine(arr[i]);
            }
        }

        public void UpdateData(){
            int location = Convert.ToInt32(Console.ReadLine());
            console.WriteLine("Enter new value for the location: " + location);
            arr[location] = Convert.ToInt32(Console.ReadLine());
            console.WriteLine("Data Updated!");
        }
    }
}
