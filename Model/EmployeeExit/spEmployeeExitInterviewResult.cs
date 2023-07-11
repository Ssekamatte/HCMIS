namespace HCMIS.Model.EmployeeExit
{
    public class spEmployeeExitInterviewResult
    {

        public int? EmployeExitRatingID { get; set; }

        public int? ExitInterviewID { get; set; }

        public int ExitRating_AspectId { get; set; }

        public string AspectDescription { get; set; }

        public bool? PoorRating { get; set; }

        public int? PoorExit_RatingId { get; set; }

        public bool? FairRating { get; set; }

        public int? FairExit_RatingId { get; set; }

        public bool? GoodRating { get; set; }

        public int? GoodExit_RatingId { get; set; }

        public bool? VeryGoodRating { get; set; }

        public int? VeryGoodExit_RatingId { get; set; }

        public bool? ExecellentRating { get; set; }

        public int? ExcellentExit_RatingId { get; set; }

        public string PoorRatingComments { get; set; }

        public string FairRatingComments { get; set; }

        public string GoodRatingComments { get; set; }

        public string VeryGoodRatingComments { get; set; }

        public string ExecellentRatingComments { get; set; }

    }
}
