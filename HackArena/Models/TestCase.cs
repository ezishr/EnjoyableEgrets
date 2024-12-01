using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// This class is used to store the information of a test case of a problem.
// A problem can have multiple test cases
// Each test case has an input and an output and a unique id.
namespace HackArena.Models
{
    public class TestCase
    {
        public int _TestCaseId;


        public int ProblemOrder { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public string Explanation { get; set; }

        /*public TestCase( int ProblemId, int ProblemOrder, string Input, string Output, string Explanation )
        {
            _ProblemId = ProblemId;
            ProblemOrder = ProblemOrder;
            Input = Input;
            Output = Output;
            Explanation = Explanation;
        }*/
    }
}