using System;
using System.Net;
using System.Web.Http.Results;
using ApiSecureStudent.Controllers;
using ApiSecureStudent.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTestStudent.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPut()
            //Arrange
        {
            Student student_expected = new Student()// Student es de la clase de Student 
            {
                StudentID = 1,
                FirstName = "Salma",
                LastName = "Eid",
                EnrollmentDate = DateTime.Today
            };
            StudentsController studentsController = new StudentsController();


            //Act
            var resultado = studentsController.PutStudent(student_expected.StudentID, student_expected);
            var student_actual = resultado as OkNegotiatedContentResult<Student>;



            /*Assert
            Assert.AreEqual(HttpStatusCode.NoContent, resultado);
            Assert.AreEqual(student_expected, student_actual);*/
            //Asser

            Assert.IsNull(student_actual);

        }
    }
}
