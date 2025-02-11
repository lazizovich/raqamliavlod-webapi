﻿using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Questions;
using RaqamliAvlod.Domain.Entities.Questions;


namespace RaqamliAvlod.DataAccess.Repositories.Questions
{
    public class QuestionAnswerRepository : GenericRepository<QuestionAnswer>, IQuestionAnswerRepository
    {
        public QuestionAnswerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
