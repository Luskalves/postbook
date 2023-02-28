using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
  [Key]
  public int UserId { get; set; }
  [Required]
  [MinLength(3)]
  [MaxLength(50)]
  public string Name { get; set; }
  [Required]
  public string Email { get; set; }
  [Required]
  [MinLength(8)]
  public string Password { get; set; }
  public ICollection<Post>? Posts { get; set; }
}