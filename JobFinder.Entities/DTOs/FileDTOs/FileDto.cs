﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Entities.DTOs.FileDTOs
{
    public class FileDto
    {
        
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileId { get; set; }
        public string Path { get; set; }
        public byte[] Content { get; set; }
        public string ContentType { get; set; }
    }
}
