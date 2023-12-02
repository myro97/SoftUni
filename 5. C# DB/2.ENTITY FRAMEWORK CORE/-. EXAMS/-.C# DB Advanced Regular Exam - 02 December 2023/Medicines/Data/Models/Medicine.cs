﻿using Medicines.Common;
using Medicines.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicines.Data.Models;

public class Medicine
{
    public Medicine()
    {
        PatientsMedicines = new HashSet<PatientMedicine>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(ValidationConstants.MedicineNameMaxLength)]
    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public Category Category { get; set; }

    public DateTime ProductionDate { get; set; }

    public DateTime ExpiryDate  { get; set;}

    [Required]
    [MaxLength(ValidationConstants.MedicineProducerMaxLength)]
    public string Producer  { get; set; } = null!;

    [ForeignKey(nameof(Pharmacy))]
    public int PharmacyId { get; set; }
    public virtual Pharmacy Pharmacy { get; set; } = null!;

    public virtual ICollection<PatientMedicine>  PatientsMedicines { get; set; }
}
