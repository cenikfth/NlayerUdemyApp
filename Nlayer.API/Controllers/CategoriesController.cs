﻿using Microsoft.AspNetCore.Mvc;
using Nlayer.Core.Services;

namespace Nlayer.API.Controllers
{

    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetSingleCategoryByIdWithProducts(int categoryId)
        {
           

            return CreateActionResult(await _categoryService.GetSingleCategoryByWithProductsAsync(categoryId));
        }
    }
}
