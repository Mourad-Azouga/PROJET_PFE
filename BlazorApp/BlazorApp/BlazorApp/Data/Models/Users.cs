﻿using System;

namespace BlazorApp.Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Email { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Poste { get; set; }
    }
}