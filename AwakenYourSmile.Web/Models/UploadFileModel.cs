﻿using Rainbow.Web.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwakenYourSmile.Web.Models
{
    public class UploadFileModel
    {
        public Guid Reference { get; set; }

        public IEnumerable<UploadedFile> Files { get; set; }
    }
}