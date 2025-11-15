using System;


        public class Resume()
        {

            public string name = "";
            public List<Job> _jobs = [];
            public void Display(){
                Console.WriteLine(name);
                foreach(Job j in _jobs){
                    j.Display();
                }
                
            }
        }