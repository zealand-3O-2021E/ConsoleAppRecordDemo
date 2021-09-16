using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRecordDemo
{
    public record Teacher(string firstname, string lastname, string grade) :
        Person( firstname, lastname);

    public  record Person(string firstname, string lastname) {

        public int test { get; set; }

    };
}
