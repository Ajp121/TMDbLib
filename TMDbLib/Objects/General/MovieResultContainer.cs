﻿using System.Collections.Generic;

namespace TMDbLib.Objects.General
{
    // TODO: Join this with SearchContainer, Lists, MovieResultContainer, ChangesListContainer
    public class MovieResultContainer
    {
        public int Id { get; set; }
        public int Page { get; set; }
        public List<MovieResult> Results { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }
    }
}