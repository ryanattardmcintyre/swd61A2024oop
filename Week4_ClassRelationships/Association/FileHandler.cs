using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships.Association
{
    public class FileHandler
    {
        public void Load(TextFile file)
        {
            file.Contents = 
                System.IO.File.ReadAllText(file.Path);
        }


        public int WordCount(TextFile file)
        {
            if (String.IsNullOrEmpty(file.Contents))
            {
                Load(file);
            }
            
            
        //hello today is monday
        //Array[0] = hello
        //Array[1] = today
        //Array[2] = is
        //Array[3] = monday

           return
                file.Contents.Split(new char[] { ' ' }).Length;
            


        }


    }
}
