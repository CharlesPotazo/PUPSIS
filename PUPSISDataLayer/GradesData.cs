using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PUPSISModel;

namespace PUPSISDataLayer
{
    public class GradesData
    {

        List<Grade> charlesGrades = new List<Grade>();
        List<Grade> marcGrades = new List<Grade>();
        List<Grade> princeGrades = new List<Grade>();
        List<Grade> chinoGrades = new List<Grade>();

        public List<Grade> CharlesGrades()
        {
            Grade PATHFIT1 = new Grade { subject = "PATHFIT1: ", score = 1.00};
            charlesGrades.Add(PATHFIT1);
            Grade CompProg1 = new Grade { subject = "CompProg1: ", score = 1.00 };
            charlesGrades.Add(CompProg1);
            Grade DiscreteStructures = new Grade { subject = "Discrete Structures: ", score = 1.25 };
            charlesGrades.Add(DiscreteStructures);
            return charlesGrades;
        }
        public List<Grade> MarcGrades()
        {
            Grade PATHFIT1 = new Grade { subject = "PATHFIT1: ", score = 1.00 };
            marcGrades.Add(PATHFIT1);
            Grade CompProg1 = new Grade { subject = "CompProg1: ", score = 1.00 };
            marcGrades.Add(CompProg1);
            Grade DiscreteStructures = new Grade { subject = "Discrete Structures: ", score = 1.50 };
            marcGrades.Add(DiscreteStructures);
            return charlesGrades;
        }

        public List<Grade> PrinceGrades()
        {
            Grade PATHFIT3 = new Grade { subject = "PATHFIT3: ", score = 1.00 };
            princeGrades.Add(PATHFIT3);
            Grade OS = new Grade { subject = "Operating Systems: ", score = 1.00 };
            princeGrades.Add(OS);
            Grade RVA = new Grade { subject = "RVA: ", score = 1.75 };
            princeGrades.Add(RVA);
            return princeGrades;
        }

        public List<Grade> ChinoGrades()
        {
            Grade PATHFIT3 = new Grade { subject = "PATHFIT3: ", score = 1.00 };
            chinoGrades.Add(PATHFIT3);
            Grade OS = new Grade { subject = "Operating Systems: ", score = 1.25 };
            chinoGrades.Add(OS);
            Grade RVA = new Grade { subject = "RVA: ", score = 1.75 };
            chinoGrades.Add(RVA);
            return chinoGrades;
        }
    }
}
