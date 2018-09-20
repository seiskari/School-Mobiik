﻿using System;
using System.Collections.Generic;
using System.Text;
using SchoolMobiik.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SchoolMobiik.DataAccess
{
    public class SQLDataAccessCourse:IDisposable
    {
        public SQLDataAccessCourse()
        {

        }
        
        public IEnumerable<Course> GetCourses(string schoolId)
        {
            List<Course> CourseList = new List<Course>();
            using (var context = new SemillerosDBContext())
            {
                var list = context.Course.Where(s => s.SchoolId == schoolId).Include(c => c.Teacher)
                    .ThenInclude(t => t.Person)
                    .Include(s => s.Signatures).ToList();

                CourseList = list;
            }
            return CourseList;
        }


        //var list = context.Course.Where(s => s.SchoolId == schoolId).ToList();
        //public IEnumerable<Course> GetCourses(string schoolId)
        //{
        //    List<Course> CourseList = new List<Course>();
        //    List<Teacher> CourseList2 = new List<Teacher>();
        //    Teacher maestro;
        //    Signatures materia;
        //    using (var context = new SemillerosDBContext())
        //    {
        //        var list = context.Course.Where(s => s.SchoolId == schoolId).ToList();

        //        list.ForEach(item => {
        //            maestro = context.Teacher.Where(s => s.TeacherId == item.TeacherId).SingleOrDefault();
        //            var result = (from p in context.Person
        //                          where p.PersonId == maestro.PersonId
        //                          select p).SingleOrDefault();

        //            item.Teacher.Person.PersonFirstName = result.PersonFirstName;

        //            materia = context.Signatures.Where(s => s.SignaturesId == item.SignaturesId).SingleOrDefault();

        //            var result2 = (from s in context.Signatures
        //                          where s.SignaturesId == materia.SignaturesId
        //                          select s).SingleOrDefault();

        //            item.Signatures.SignaturesName = result2.SignaturesName;

        //        });            




        public void Dispose()
        {
        }

    }
}
