﻿namespace occurrensBackend.Models.GetDoctorInformationsModels
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalPages { get; set; }
        public int ItemFrom { get; set; }
        public int ItemsTo { get; set; }
        public int TotalPagesCount { get; set;}

        public PagedResult(List<T> items, int totalCount, int pageSize, int pageNumber)
        {
            Items = items;
            TotalPagesCount = totalCount;
            ItemFrom = pageSize * (pageNumber - 1) + 1;
            ItemsTo = ItemFrom + pageSize -1 ;
            TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
        }
    }
}
