﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.DTOs.CategoryDtos
{
    public class CategoryListDto
    {
        public List<CategoryListItemDto> Categories  { get; set; }
        public int TotalCount { get; set; }
    }

    public class CategoryListItemDto 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
