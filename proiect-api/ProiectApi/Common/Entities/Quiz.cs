﻿
namespace Common.Entities
{
    public class Quiz
    {
        public int Id { get; set; }
        public int NoChapter { get; set; }
        public List<Question> Questions { get; set; }
    }
}
