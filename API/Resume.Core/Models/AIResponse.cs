﻿using Resume.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class AIResponse
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AiId { get; set; }
    public int UserId { get; set; }
    // Add this navigation property
    public User User { get; set; }

    public string FileName { get; set; }
    public string FirstName { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PlaceOfStudy { get; set; }
    public string Occupation { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }

}
