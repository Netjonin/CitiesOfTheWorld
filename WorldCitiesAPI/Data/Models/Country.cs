﻿namespace WorldCitiesAPI.Data.Models
{
    [Table("Countries")]
    [Index(nameof(Name))]
    [Index(nameof(ISO2))]
    [Index(nameof(ISO3))]
    public class Country
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string ISO2 { get; set; } = null!;

        public string ISO3 { get; set; } = null!;

        public ICollection<City>? Cities { get; set; } = null!;
    }
}
