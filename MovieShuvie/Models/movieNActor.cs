﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShuvie.Models
{
    public class movieNActor
    {
        [Key]
        [Column(Order = 1 )]
        public int movieId { get; set; }

        [Key]
        [Column(Order = 2 )]
        public int actorId { get; set; }

        [ForeignKey("movieId")]
        public movies movie { get; set; }

        [ForeignKey("actorId")]
        public actors actor { get; set; }
    }
}