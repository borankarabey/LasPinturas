﻿using LasPinturas.Dtos.Requests;
using LasPinturas.Dtos.Responses;
using LasPinturas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasPinturas.Business
{
   public  interface IProductService
    {
        Task<ICollection<ProductListResponse>> GetProducts();
        Task<int> AddProduct(AddProductRequest product);
        Task<bool> IsExist(int id);
        Task<ProductListResponse> GetProductById(int id);
        Task<int> UpdateProduct(UpdateProductRequest request);
        Task DeleteProduct(int id);
    }
}
