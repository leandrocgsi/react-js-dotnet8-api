﻿using RestWithASPNETErudio.Hypermedia;
using RestWithASPNETErudio.Hypermedia.Abstract;

namespace RestWithASPNETErudio.Data.VO

{
    public class PersonVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public bool Enabled { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
