﻿namespace MoviesShopProxy.DomainModel
{
    public class Adress
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
    }
}