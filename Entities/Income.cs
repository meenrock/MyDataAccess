using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Income
{
    [Key]
    [Column("income_id")]
    public uint IncomeID { get; set; }

    [Column("income_name")]
    public string IncomeName { get; set; }

    [Column("income_category_id")]
    public long IncomeCategoryID { get; set; }

    [Column("income_amount")]
    public long IncomeAmount { get; set; }

    [Column("user_id")]
    public uint UserID { get; set; }

    [Column("income_description")]
    public string IncomeDescription { get; set; }

    [Column("book_id")]
    public string BookID { get; set; }

    [Column("status")]
    public string Status { get; set; }

    [Column("is_verified")]
    public string IsVerified { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}