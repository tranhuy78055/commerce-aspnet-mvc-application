﻿using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Description { get; set; }
        public DateTime StartDate { get; set; }
        public string EndDate { get; set; }
        public double Price { get; set; }   
        public string ImageURL { get; set; }
        public MovieCategory MovieCategory { get; set; }

        // Relationship
        public List<Actor_Movie> Actor_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

      

    }
}