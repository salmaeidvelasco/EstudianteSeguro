using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using ApiSecureStudent.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UTEstudiantesSeguro.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetStudent()
        {
            //Arrange
            StudentsController studentsController = new StudentsController();

            //Act
            var ListaEstudiante = studentsController.GetStudents();

            //Assert
            Assert.IsNotNull(ListaEstudiante);
            //Tarea completar el Post y todos
        }

    }
}
