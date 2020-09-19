using System;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using ApiSecureStudent.Controllers;
using ApiSecureStudent.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EstudianteSeguro.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGet()
        {
            //Arrange
            StudentsController controller = new StudentsController();


            //Act
            var listaestudiante = controller.GetStudents();

            //Assert
            Assert.IsNotNull(listaestudiante);
        }

        [TestMethod]
        public void TestMethodPost()
        {
            //Arrange
            StudentsController controller = new StudentsController();
            Student prueba = new Student()
            {
                FirstName = "Salma",
                LastName = "Eid",
                StudentID = 1,
                EnrollmentDate = DateTime.Now
            };

            //Act
            IHttpActionResult actionResult = controller.PostStudent(prueba);
            var createdResult = actionResult as CreatedAtRouteNegotiatedContentResult<Student>;
            
            //Assert
            Assert.IsNotNull(createdResult);
            Assert.AreEqual("DefaultApi", createdResult.RouteName);
            Assert.AreEqual(prueba.StudentID, createdResult.RouteValues["id"]);
            Assert.AreEqual("Salma", createdResult.Content.FirstName);

        }


        //Delete
        [TestMethod]
        public void TestMethodDelete()
        {
            // Arrange
            StudentsController controller = new StudentsController();
            Student prueba = new Student()
            {
                FirstName = "Salma",
                LastName = "Eid",
                StudentID = 1,
                EnrollmentDate = DateTime.Now

            };

            // Act
            IHttpActionResult actionResult = controller.PostStudent(prueba);
            IHttpActionResult actionResultDelete = controller.DeleteStudent(prueba.StudentID);


            // Assert
            Assert.IsInstanceOfType(actionResultDelete, typeof(OkNegotiatedContentResult<Student>));
        }



        //Put
        [TestMethod]
        public void TestMethodPut()
        {
            //Arrange
            StudentsController controller = new StudentsController();
            Student prueba = new Student()
            {
                FirstName = "Salma",
                LastName = "Eid",
                StudentID = 1,
                EnrollmentDate = DateTime.Now
            };
            //Act
            var ListaEstudiante = controller.PostStudent(prueba);
            prueba.FirstName = "Marcela";
            var resultadoCreado = controller.PutStudent(prueba.StudentID, prueba) as StatusCodeResult;

            //Assert
            Assert.IsNotNull(resultadoCreado);
            Assert.AreEqual(HttpStatusCode.NoContent, resultadoCreado.StatusCode);
            Assert.IsInstanceOfType(resultadoCreado, typeof(StatusCodeResult));


        }
    }
}

