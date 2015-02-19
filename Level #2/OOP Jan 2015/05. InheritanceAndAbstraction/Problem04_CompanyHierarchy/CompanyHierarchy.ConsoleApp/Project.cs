namespace CompanyHierarchy.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CompanyHierarchy.Interface;

    public class Project : IProject
    {
        private string projectName;
        private DateTime startDate;
        private State type;

        public string ProjectName
        {
            get { return projectName; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Project name is Empty");
                    }
                    else
                    {
                        projectName = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public State Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public enum State 
        {
            Open,
            Closed
        }

        public Project(string projectName, DateTime startDate, State state )
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Type = state;
        }


        public void CloseProject() {
            this.Type = State.Closed;
        }

        public override string ToString()
        {
            return string.Format("project name: {0} date: {1} state: {2}", this.ProjectName,this.StartDate,this.Type);
        }
    }
}
