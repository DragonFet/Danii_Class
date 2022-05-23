using Person.Work;
using Person;
using ConsoleApp4;

Person.person mixalych = new person("Name", "Surename", 42);
mixalych.Print();
work GazProm = new work("GazProm","Head",200000);
GazProm.Print_2();
namespace Person
{
    class person
    {
        public string name;
        public string surename;
        public int age;
        public person(string name,string surename ,int age)
        {
            this.name = name;
            this.surename = surename;
            this.age = age;
        }
        public void Print()
        {
            Console.WriteLine(name+" "+surename+" "+age);
        }
        public void Destroer(out string name,out string surename,out int age)
        {
            name=this.name;
            surename=this.surename;
            age=this.age;
        }
    }
    namespace Work
    {
        class work
        {
            public string company_name;
            public string name_worker;
            public double sallary;
            public void Print_2()
            {
                Console.WriteLine(company_name + " " + name_worker + " " + sallary);
            }
            public work(string company_name ,string name_worcker, double sallary)
            {
                this.company_name = company_name;
                this.name_worker=name_worcker;
                this.sallary = sallary;
            }
            public void Destructor( out string company_name, out string name_worker,out double sallary)
            {
                company_name=this.company_name;
                name_worker = this.name_worker;
                sallary=this.sallary;
            }
        }
    }
}

