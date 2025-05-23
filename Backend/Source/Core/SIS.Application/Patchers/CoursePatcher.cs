﻿using SIS.Application.DTOs.CourseDTOs;
using SIS.Domain.Entities;
using SIS.Domain.Shared;

namespace SIS.Application.Patchers
{
    /// <summary>
    /// Provides extension methods to apply updates or patches to a <see cref="Course"/> entity."
    /// </summary>
    public static class CoursePatcher
    {
        /// <summary>
        /// Updates the properties of a <see cref="Course"/> entity with the values from a <see cref="CourseUpdateDto"/>.
        /// </summary>
        /// <param name="course">The Course entity to update.</param>
        /// <param name="courseDTO">The DTO containing the updated values.</param>
        public static void ApplyUpdate(this Course course, CourseUpdateDto courseDTO)
        {
            course.UpdatedAt = DateTime.Now;

            course.Name = courseDTO.Name;
            course.Code = courseDTO.Code;
            course.Type = courseDTO.Type;
            course.Description = courseDTO.Description;
            course.Credits = courseDTO.Credits;
            course.Level = courseDTO.Level;
            course.IsActive = courseDTO.IsActive;
            course.PrerequisiteCourseIds = courseDTO.PrerequisiteCourseIds;
            course.DepartmentId = courseDTO.DepartmentId;
        }

        /// <summary>
        /// Updates the properties of a <see cref="Course"/> entity with the non-null values from a <see cref="CoursePatchDto"/>.
        /// </summary>
        /// <param name="course">The Course entity to patch.</param>
        /// <param name="courseDto"> The DTO containing the patch values.</param>
        public static void ApplyPatch(this Course course, CoursePatchDto courseDto)
        {
            course.UpdatedAt = DateTime.Now;

            if (courseDto.Name != null)
                course.Name = courseDto.Name;
            if (courseDto.Code != null)
                course.Code = courseDto.Code;
            if (courseDto.Type != null)
                course.Type = (CourseType)courseDto.Type;
            if (courseDto.Description != null)
                course.Description = courseDto.Description;
            if (courseDto.Credits != null)
                course.Credits = (int)courseDto.Credits;
            if (courseDto.Level != null)
                course.Level = (Level)courseDto.Level;
            if (courseDto.IsActive != null)
                course.IsActive = (bool)courseDto.IsActive;
            if (courseDto.PrerequisiteCourseIds != null)
                course.PrerequisiteCourseIds = courseDto.PrerequisiteCourseIds;
            if (courseDto.DepartmentId != null)
                course.DepartmentId = (int)courseDto.DepartmentId;
        }
    }
}
