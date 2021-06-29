using Entities.SecondaryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ModelTestResult : EntityBase
    {
        public string ModelTestId { get; set; }
        public string PackageId { get; set; }
        public string UserId { get; set; }
        public int TotalQuestions { get; set; }
        public int CorrectAnswer { get; set; }
        public int WrongAnswer { get; set; }
        public Double ObtainedMark { get; set; }
        public List<QuestionResult> MyProperty { get; set; }
        public TimeSpan TakenDuration { get; set; }
    }
}