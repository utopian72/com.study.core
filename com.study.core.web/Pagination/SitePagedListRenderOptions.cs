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

/*option
 
            DisplayLinkToIndividualPages = true;
            DisplayPageCountAndCurrentLocation = false;
            MaximumPageNumbersToDisplay = 10;
            DisplayEllipsesWhenNotShowingAllPageNumbers = true;
            EllipsesFormat = "&#8230;";
            LinkToFirstPageFormat = "처음";
            LinkToPreviousPageFormat = "이전";
            LinkToIndividualPageFormat = "{0}";
            LinkToNextPageFormat = "다음";
            LinkToLastPageFormat = "마지막";
            PageCountAndCurrentLocationFormat = "Page {0} of {1}.";
            ItemSliceAndTotalFormat = "Showing items {0} through {1} of {2}.";
            ClassToApplyToFirstListItemInPager = null;
            ClassToApplyToLastListItemInPager = null;
            ContainerHtmlTag = "nav";
            UlElementClasses = new[] { "pagination" };
            LiElementClasses = Enumerable.Empty<string>();
            AhrefElementClasses = Enumerable.Empty<string>();
            ActiveElementClasses = new[] { "active" };
            DisabledElementClasses = new[] { "disabled" };
            ClassToApplyToFirstListItemInPager = "이전";
            ClassToApplyToLastListItemInPager = "다음";

 */