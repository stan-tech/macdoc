using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace macdoc
{
    public  class Component
    {
        string name;
        public long id;
        string reference;
        DateTime date_insertion;
        DateTime date_modification;
        double  life_duration ;
        long num_modifications;
        int id_machine;
        string type;
        string machineName;
        string machineRef;



        public string Name
        {
            get { return name; }
            set { name = value; }   
        }

        public string MachineName
        {
            get { return machineName; }
            set { machineName = value; }
        }

        public string MachineRef
        {
            get { return machineRef; }
            set { machineRef = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public long ID
        {
            get { return id; }
            set { id = value; }
        }
        public int ID_Machine
        {
            get { return id_machine; }
            set { id_machine = value; }
        }
        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }
        public DateTime Date_insertion
        {
            get { return date_insertion; }
            set { date_insertion = value; }

        }

        public DateTime Date_modification
        {
            get { return date_modification; }
            set { date_modification = value; }
        }

        public double Life_duration
        {
            get { return life_duration; }
            set { life_duration = value; }
        }

        public long Num_modifications
        { get { return num_modifications; }
        set { num_modifications = value; }
        }
        public Component(string name, string reference,DateTime date_insertion,DateTime date_modification,
        int num_modifications)
        {


            this.Date_insertion = date_insertion;  
            this.Name = name;   
            this.Reference = reference;
            this.Date_modification = date_modification;
            this.date_modification = date_modification;
            this.num_modifications = num_modifications;

        }



    }
}
