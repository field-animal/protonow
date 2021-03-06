// <copyright file="PageListViewModelTest.cs">Copyright ©  2014</copyright>
using System;
using System.Windows.Controls;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Naver.Compass.Module;

namespace Naver.Compass.Module.Tests
{
    /// <summary>This class contains parameterized unit tests for PageListViewModel</summary>
    [PexClass(typeof(PageListViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class PageListViewModelTest
    {
        /// <summary>Test stub for .ctor(TreeView)</summary>
        [PexMethod]
        internal PageListViewModel ConstructorTest(TreeView tree)
        {
            PageListViewModel target = new PageListViewModel(tree);
            return target;
            // TODO: add assertions to method PageListViewModelTest.ConstructorTest(TreeView)
        }
    }
}
