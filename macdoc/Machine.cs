using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macdoc
{
    public class Machine
    {

        public string name;
        public string type;
        public string reference;

        public string id;
        List<string> sensors;
        List<string> motors;
        List<string> reductors;
        List<string> straps;



        public Machine() { }

        public Machine(string name, string type, string id, string reference) {

            this.name = name;
            this.type = type;
            this.id = id;
            this.reference = reference;

        }



        public string Name { get { return name; }
            set { name = value; } }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string ID {

            get { return id;}
            set { id = value; }

         }

        public string Reference {
            get { return reference; }
            set {  reference = value; }
        }

    }
}
