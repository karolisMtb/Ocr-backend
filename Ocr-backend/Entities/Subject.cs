﻿namespace Ocr_backend.Entities
{
    public class Subject
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Course { get; set; }
        public string Note { get; set; }
    }
}
