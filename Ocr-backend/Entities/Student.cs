﻿namespace Ocr_backend.Entities
{
    public class Student
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
