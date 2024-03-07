using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList2
{
    internal class Tasks
    {
        static int ID;
        public int id;
        public string title;
        public string description;
        public bool enable;

        public Tasks(int Id, string Title, string Description, bool Enable) {
            ID = id;
            this.id = Id;
            this.title = Title;
            this.description = Description;
            this.enable = Enable;
        }

        public Tasks(string Title, string Description, bool Enable)
        {
            ID++;
            this.id = ID;
            this.title = Title;
            this.description = Description;
            this.enable = Enable;
        }

        override
            public string ToString()
            {
                if (this.enable == false)
                {
                    return this.id + ". " + this.title + " - " + this.description;
                }
                else {
                    return this.id + ". " + this.title + "(Hecho)" + " - " + this.description;
                }
            }

    }
}
