﻿namespace com.study.core.web.Pagination
{
    public class SitePagedListRenderOptions
    {
        public static PagedListRenderOptions Boostrap4
        {
            get
            {
                var option = PagedListRenderOptions.Bootstrap4Full;

                option.MaximumPageNumbersToDisplay = 5;

                return option;
            }
        }
    }
}
