using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public enum GroupNames
    {
        BackEnd,
        FrontEnd,
        QA
    };

    public class Group
    {
        private List<Person> students;
        private GroupNames groupName;

        public Group(GroupNames name, List<Person> students)
        {
            groupName = name;
            this.students = students;

        }
        public void Add(Person student)
        {
            students.Add(student);
        }

        public GroupNames GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }
        public List<Person> Students
        {
            get { return students; }
            set { students = value; }
        }
    }
}
