﻿namespace TaskRubicon.Dtos.CommentDtos
{
    public class GetCommentDto
    {
        public int Id { get; set; }
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        public DateTime updatedAt { get; set; } = DateTime.UtcNow;
        public string Body { get; set; } = string.Empty;

    }
}
