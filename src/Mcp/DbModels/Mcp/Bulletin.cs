﻿using System.Collections.Generic;

namespace McpSmyrilLine.DbModels.Mcp
{
    public class Bulletin
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public virtual List<Description> Descriptions { get; set; }
        public virtual List<Image> Images { get; set; }
    }
}
