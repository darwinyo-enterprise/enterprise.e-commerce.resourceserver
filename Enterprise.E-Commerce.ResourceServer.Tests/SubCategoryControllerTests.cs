﻿using Enterprise.Abstract.NetStandard;
using Enterprise.Constants.NetStandard;
using Enterprise.E_Commerce.NetStandard.DataLayers.ECommerceDB;
using Enterprise.E_Commerce.NetStandard.MockData;
using Enterprise.Fixtures.NetStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Enterprise.E_Commerce.ResourceServer.Tests
{
    //[Collection("E-Commerce Resource Server Test Collection")]
    //public class SubCategoryControllerTests : BaseTest
    //{
    //    public SubCategoryControllerTests(AuthorizationServiceFixture authorizationServiceFixture, ECommerceServiceFixture eCommerceServiceFixture, URLFixture uRLFixture)
    //    {
    //        _authorizationServiceFixture = authorizationServiceFixture;
    //        _eCommerceServiceFixture = eCommerceServiceFixture;
    //        _uRLFixture = uRLFixture;
    //    }

    //    #region Fields
    //    private AuthorizationServiceFixture _authorizationServiceFixture;
    //    private ECommerceServiceFixture _eCommerceServiceFixture;
    //    private URLFixture _uRLFixture;
    //    private SubCategoryMockData _subCategoryMockData;

    //    private const string clientID = ClientIDs.e_commerce_resourceserver_testclient;
    //    private const string secret = ClientSecrets.e_commerce_resourceserver_testclient;
    //    private const string scope = E_Commerce_ResourceServerScopes.full_access;
    //    private string accessToken;

    //    #endregion
    //    #region Overrides
    //    public override void InitVariables()
    //    {
    //        accessToken = _authorizationServiceFixture.AuthorizationService.CreateAccessTokenAsync(clientID, secret, scope).Result;
    //    }
    //    public override void InitMockData()
    //    {
    //        _subCategoryMockData = new SubCategoryMockData();
    //    }
    //    public override void CleanUpDatabase()
    //    {
    //        _eCommerceServiceFixture.ECommerceService.DeleteAllCategoryAsync(accessToken).Wait();
    //    }
    //    public override void CleanUpMockData()
    //    {
    //        _subCategoryMockData = null;
    //    }
    //    #endregion
    //    [Fact]
    //    public void Post_WhenModelPassedHasSubCategoryInside_InsertCategoryAndSubcategories()
    //    {
    //        var categoryMock = _subCategoryMockData.GetListOfSubCategory();
    //        // Assert Pre Test
    //        var categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.Empty(categories);

    //        // Action
    //        _eCommerceServiceFixture.ECommerceService.PostCategoryAsync(categoryMock, accessToken);

    //        // Assert
    //        categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.NotEmpty(categories);

    //        Assert.Equal(categories[0].Name, categoryMock.Name);
    //        Assert.Equal(categories[0].Enabled, categoryMock.Enabled);
    //        Assert.Equal(categories[0].CreatedBy, Guid.Empty);
    //        Assert.Equal(categories[0].Images, categoryMock.Images);

    //        Assert.NotEmpty(categories[0].SubCategory);

    //        Assert.Equal(categories[0].SubCategory.Count, categoryMock.SubCategory.Count);
    //        Assert.Equal(((List<SubCategory>)categories[0].SubCategory)[0].CreatedBy, Guid.Empty);
    //        Assert.Equal(((List<SubCategory>)categories[0].SubCategory)[0].Name, ((List<SubCategory>)categoryMock.SubCategory)[0].Name);
    //    }
    //    [Fact]
    //    public void Post_ArgumentPassedNull_ThrowException()
    //    {
    //        // Assert Pre Test
    //        var categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.Empty(categories);

    //        // Action And Assert
    //        string expectedMessage = JsonConvert.SerializeObject(new { error = Constants.NetStandard.ExceptionMessage.PARAMETER_MUST_CONTAIN_VALUE });

    //        var response = _eCommerceServiceFixture.ECommerceService.PostCategoryAsync(null, accessToken).Result;

    //        Assert.Equal(expectedMessage, response.Content.ReadAsStringAsync().Result);
    //    }
    //    [Fact]
    //    public void Post_ArgumentPassedThenCategoryAlreadyRegistered_ThrowUniqueException()
    //    {
    //        var categoryMock = _subCategoryMockData.CategoryNonSubCategory();
    //        // Assert Pre Test
    //        var categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.Empty(categories);
    //        _eCommerceServiceFixture.ECommerceService.PostCategoryAsync(categoryMock, accessToken).Wait();

    //        // Action And Assert
    //        string expectedMessage = JsonConvert.SerializeObject(new { error = Constants.NetStandard.ExceptionMessage.PARAMETER_MUST_CONTAIN_VALUE });

    //        var response = _eCommerceServiceFixture.ECommerceService.PostCategoryAsync(categoryMock, accessToken).Result;

    //        Assert.Equal(expectedMessage, response.Content.ReadAsStringAsync().Result);
    //    }
    //    [Fact]
    //    public void DeleteById_ArgumentPassed_DeleteSuccess()
    //    {
    //        var categoryMock = _subCategoryMockData.CategoryNonSubCategory();
    //        // Assert Pre Test
    //        var categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.Empty(categories);
    //        _eCommerceServiceFixture.ECommerceService.PostCategoryAsync(categoryMock, accessToken).Wait();

    //        categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.NotEmpty(categories);

    //        _eCommerceServiceFixture.ECommerceService.DeleteCategoryByIdAsync(categories[0].Id, accessToken).Wait();

    //        // Assert
    //        categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.Empty(categories);
    //    }
    //    [Fact]
    //    public void DeleteAll_ArgumentPassed_DeleteSuccess()
    //    {
    //        var categoryMock = _subCategoryMockData.CategoryNonSubCategory();
    //        // Assert Pre Test
    //        var categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.Empty(categories);
    //        _eCommerceServiceFixture.ECommerceService.PostCategoryAsync(categoryMock, accessToken).Wait();

    //        categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.NotEmpty(categories);

    //        _eCommerceServiceFixture.ECommerceService.DeleteAllCategoryAsync(accessToken).Wait();

    //        // Assert
    //        categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.Empty(categories);
    //    }

    //    [Fact]
    //    public void GetAll_GetAllCategorySuccess()
    //    {
    //        var categoryMock = _subCategoryMockData.CategoryNonSubCategory();
    //        // Assert Pre Test
    //        var categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.Empty(categories);
    //        _eCommerceServiceFixture.ECommerceService.PostCategoryAsync(categoryMock, accessToken).Wait();

    //        categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        // Assert
    //        Assert.NotEmpty(categories);
    //        Assert.Single(categories);
    //    }
    //    [Fact]
    //    public void GetByID_ParameterPassed_GetSingleExists()
    //    {
    //        var categoryMock = _subCategoryMockData.CategoryNonSubCategory();
    //        // Assert Pre Test
    //        var categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.Empty(categories);
    //        _eCommerceServiceFixture.ECommerceService.PostCategoryAsync(categoryMock, accessToken).Wait();

    //        categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.NotEmpty(categories);

    //        // Action
    //        var category = _eCommerceServiceFixture.ECommerceService.GetCategoryByIdAsync(categories[0].Id, accessToken).Result;

    //        // Assert
    //        Assert.NotNull(category);
    //    }
    //    [Fact]
    //    public void GetByID_ParameterPassed_GetNotExists()
    //    {
    //        var categoryMock = _subCategoryMockData.CategoryNonSubCategory();
    //        // Assert Pre Test
    //        var categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.Empty(categories);
    //        _eCommerceServiceFixture.ECommerceService.PostCategoryAsync(categoryMock, accessToken).Wait();

    //        categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.NotEmpty(categories);

    //        // Action
    //        var category = _eCommerceServiceFixture.ECommerceService.GetCategoryByIdAsync(Guid.NewGuid(), accessToken).Result;

    //        // Assert
    //        Assert.Null(category);
    //    }

    //    // TODO: Create Front-end First to Make clear PUT API purpose
    //    [Fact]
    //    public void Put_ParameterPassed_()
    //    {
    //        var categoryMock = _subCategoryMockData.CategoryNonSubCategory();
    //        // Assert Pre Test
    //        var categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.Empty(categories);
    //        _eCommerceServiceFixture.ECommerceService.PostCategoryAsync(categoryMock, accessToken).Wait();

    //        categories = (List<SubCategory>)_eCommerceServiceFixture.ECommerceService.GetAllCategoryAsync(accessToken).Result;

    //        Assert.NotEmpty(categories);

    //        // Action
    //        var category = _eCommerceServiceFixture.ECommerceService.GetCategoryByIdAsync(Guid.NewGuid(), accessToken).Result;

    //        // Assert
    //        Assert.Null(category);
    //    }
    //}
}
