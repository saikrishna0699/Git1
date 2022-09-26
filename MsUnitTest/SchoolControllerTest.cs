
using AutoFixture;
using FoodDonationManagmentSystem.Controllers;
using FoodDonationManagmentSystem.Data.Interface;
using FoodDonationManagmentSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MsUnitTest
{
   
        [TestClass]
        public class SchoolControllerTest
        {
            private Mock<ISchoolModuleRepository> _RepoMock;
            private Fixture _fixture;
           
            private SchoolController _controller;
        public SchoolControllerTest()
        {
                _fixture = new Fixture();
                _RepoMock = new Mock<ISchoolModuleRepository>();
            }
            [TestMethod]

            public async Task GetDonarReturnOk()
            {
                var donarList = _fixture.CreateMany<DonarsModule>(3).ToList();
                _RepoMock.Setup(repo => repo.Get()).Returns(donarList);
                _controller = new SchoolController(_RepoMock.Object);
                var result = await _controller.Get();
                var obj = result as ObjectResult;
                Assert.AreEqual(200, obj.StatusCode);
            }
            [TestMethod]
            public async Task GetDonarThrowException()
            {
                _RepoMock.Setup(repo => repo.Get()).Throws(new Exception());
                _controller = new SchoolController(_RepoMock.Object);
                var result = await _controller.Get();
                var obj = result as ObjectResult;
                Assert.AreEqual(500, obj.StatusCode);
            }
            [TestMethod]
            public async Task AddDonarReturnOk()
            {
                var donar = _fixture.Create<DonarsModule>();
                _RepoMock.Setup(repo => repo.Post(It.IsAny<DonarsModule>())).Returns(donar);
                _controller = new SchoolController(_RepoMock.Object);
                var result = await _controller.Post(donar);
                var obj = result as ObjectResult;
                Assert.AreEqual(200, obj.StatusCode);
            }
            [TestMethod]
            public async Task AddDonarThrowException()
            {
                _RepoMock.Setup(repo => repo.Get()).Throws(new Exception());
                _controller = new SchoolController(_RepoMock.Object);
                var result = await _controller.Get();
                var obj = result as ObjectResult;
                Assert.AreEqual(500, obj.StatusCode);
            }
            [TestMethod]
            public async Task UpdateDonarReturnOk()
            {
                var donar = _fixture.Create<DonarsModule>();
                _RepoMock.Setup(repo => repo.Put(It.IsAny<DonarsModule>())).Returns(donar);
                _controller = new SchoolController(_RepoMock.Object);
                var result = await _controller.Put(donar);
                var obj = result as ObjectResult;
                Assert.AreEqual(200, obj.StatusCode);
            }
            [TestMethod]
            public async Task UpdateDonarThrowException()
            {
                _RepoMock.Setup(repo => repo.Get()).Throws(new Exception());
                _controller = new SchoolController(_RepoMock.Object);
                var result = await _controller.Get();
                var obj = result as ObjectResult;
                Assert.AreEqual(500, obj.StatusCode);
            }
            [TestMethod]
            public async Task DeleteDonarReturnOk()
            {
                var donar = _fixture.Create<DonarsModule>();
                _RepoMock.Setup(repo => repo.Delete(It.IsAny<int>())).Returns(donar);
                _controller = new SchoolController(_RepoMock.Object);
                var result = await _controller.Delete(It.IsAny<int>());
                var obj = result as ObjectResult;
                Assert.AreEqual(200, obj.StatusCode);
            }
            [TestMethod]
            public async Task DeleteDonarThrowException()
            {
                _RepoMock.Setup(repo => repo.Get()).Throws(new Exception());
                _controller = new SchoolController(_RepoMock.Object);
                var result = await _controller.Get();
                var obj = result as ObjectResult;
                Assert.AreEqual(500, obj.StatusCode);
            }
        }
    }
