using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BSbankcore.Model
{
    [Table("client")]
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public string address { get; set; }
        [Required]
        public string account_type { get; set; }
        [Required]
        public int deposit_amount { get; set; }
        [Required]
        public string mobile_number { get; set; }
        [Required]
        public string email { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
