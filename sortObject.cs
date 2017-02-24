using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI
{
    public class sortObject
    {
        public double grade;
        public string path;
        public string name;
        
        public sortObject(double grade,string path,string name)
        {
            this.grade = grade;
            this.path = path;
            this.name = name;
        }
    }
    public class sortObjectComparer : IComparer<sortObject>
    {
        public sortObjectComparer() { }
        public int Compare(sortObject s1, sortObject s2)
        {
            return s2.grade.CompareTo(s1.grade);
        }
    }
}
