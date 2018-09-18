using System;

namespace SportsStore.WebUI.Models
{
    public class PagingInfo
    {
        //全部项目数
        public int TotalItems { get; set; }

        //一页所包含的项目数
        public int ItemPerPage { get; set; }

        //当前页
        public int CurrentPage { get; set; }

        //根据所有的项目数除以每页的项目得出总页数
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemPerPage);
    }
}