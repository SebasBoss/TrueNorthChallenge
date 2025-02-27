﻿using System;
using System.Collections.Generic;

namespace TrueNorthChallenge.Common.DTO
{
    public class PostDetailsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public List<string> Tags { get; set; }
    }
}
