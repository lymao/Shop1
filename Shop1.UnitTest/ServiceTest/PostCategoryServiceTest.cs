﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shop1.Data.Infrastructure;
using Shop1.Data.Repositories;
using Shop1.Model.Models;
using Shop1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop1.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory() {ID=1,Name="DM1",Status=true },
                new PostCategory() {ID=2,Name="DM2",Status=true },
                new PostCategory() {ID=3,Name="DM3",Status=true },
                new PostCategory() {ID=3,Name="DM3",Status=true },
            };
        }
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //set up method
            _mockRepository.Setup(n => n.GetAll(null)).Returns(_listCategory);
            //call action
            var result = _categoryService.GetAll() as List<PostCategory>;
            // compare
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count());
        }
        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test";
            category.Alias = "test";
            category.Status = true;

            _mockRepository.Setup(m => m.Add(category)).Returns((PostCategory p) =>
            {
                p.ID = 1;
                return p;
            });

            var result = _categoryService.Add(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
