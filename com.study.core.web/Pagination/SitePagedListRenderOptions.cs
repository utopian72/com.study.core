using PagedList.Core.Mvc;

namespace com.study.core.web.Pagination
{
    public class SitePagedListRenderOptions
    {
        public static PagedListRenderOptions Boostrap4
        {
            get
            {
                var option = PagedListRenderOptions.Bootstrap4Full;

                option.MaximumPageNumbersToDisplay = 5;
                option.LinkToFirstPageFormat = "처음";
                option.LinkToLastPageFormat = "마지막";
                option.LinkToPreviousPageFormat = "이전";
                option.LinkToNextPageFormat = "다음";
                return option;
            }
        }
    }
}
