namespace InteractiveLearningSystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProblemStat
    {

        public int Id { get; set; }

        public int Success { get; set; }

        public int Fail { get; set; }

        //[Required]
        public string StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual User Student { get; set; }

        //[Required]
        public int ProblemId { get; set; }

        [ForeignKey("ProblemId")]
        public virtual Problem Problem { get; set; }
    }
}
