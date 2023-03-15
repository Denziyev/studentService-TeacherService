using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskApp.Core.Models.Base
{
    public abstract class BaseModel
    {
        string _name;
        string _surname;
        string _groupname;
        public readonly int Id;
        static int _count=0;

        public string Name { get; set; }
       
        

        public string Surname { get; set; }

        public string GroupNumber { get; set; }

          
        public override string ToString()
        {
            return $"Name: {Name} Surname: {Surname}  GroupNumber: {GroupNumber}    Id: {Id} ";
        }

        public BaseModel()
        {
            _count++;
            Id= _count;
        }


        

    }
}
