﻿using CodePower.DataAccess.Common;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.DataAccess.DbContexts;
using RaqamliAvlod.DataAccess.Interfaces.Courses;
using RaqamliAvlod.Domain.Entities.Courses;

namespace RaqamliAvlod.DataAccess.Repositories.Courses
{
    public class CourseCommentRepository : BaseRepository<CourseComment>, ICourseCommentRepository
    {
        public CourseCommentRepository(AppDbContext context) : base(context)
        {

        }
        public Task<PagedList<CourseComment>> GetAllByCourseIdAsync(long courseId, PaginationParams @params)
        {
            throw new NotImplementedException();
        }
    }
}
