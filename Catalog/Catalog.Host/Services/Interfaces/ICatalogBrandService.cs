﻿using Catalog.Host.Models.Dtos;

namespace Catalog.Host.Services.Interfaces;

public interface ICatalogBrandService
{
    Task<int?> Add(string brand);
    Task<bool?> Delete(int id);
    Task<CatalogBrandDto> Update(int id, string brand);
}