﻿namespace Eshop.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual Album? Album { get; set; }
    }
}
