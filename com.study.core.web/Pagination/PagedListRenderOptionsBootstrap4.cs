using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList.Core.Mvc;

namespace com.study.core.web.Pagination
{

    public partial class PagedListRenderOptions
    {
        private const string DefaultContainerHtmlTag = "nav";

        private static readonly string[] DefaultUlElementClasses = { "pagination" };

        private static readonly string[] DefaultLiElementClasses = { "page-item" };

        private static readonly string[] DefaultAhrefElementClasses = { "page-link" };

        private const string DefaultLinkToPreviousPageFormat = "이전";

        private const string DefaultLinkToNextPageFormat = "다음";

        private const string DefaultLinkToFirstPageFormat = "처음";

        private const string DefaultLinkToLastPageFormat = "마지막";

        private static void SetBootstrap4Option(PagedListRenderOptions option)
        {
            option.ContainerHtmlTag = DefaultContainerHtmlTag;
            option.UlElementClasses = DefaultUlElementClasses;
            option.LiElementClasses = DefaultLiElementClasses;
            option.AhrefElementClasses = DefaultAhrefElementClasses;
            option.LinkToPreviousPageFormat = DefaultLinkToPreviousPageFormat;
            option.LinkToNextPageFormat = DefaultLinkToNextPageFormat;
            option.LinkToFirstPageFormat = DefaultLinkToFirstPageFormat;
            option.LinkToLastPageFormat = DefaultLinkToLastPageFormat;
        }

        /// <summary>
        /// Only show Previous and Next links.
        /// </summary>
        public static PagedListRenderOptions Bootstrap4Minimal
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetBootstrap4Option(option);
                SetMinimalOption(option);

                return option;
            }
        }

        /// <summary>
        /// Only show Page Numbers.
        /// </summary>
        public static PagedListRenderOptions Bootstrap4PageNumbersOnly
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetBootstrap4Option(option);
                SetPageNumbersOnlyOption(option);

                return option;
            }
        }

        /// <summary>
        /// Show Page Numbers plus Previous and Next links.
        /// </summary>
        public static PagedListRenderOptions Bootstrap4PageNumbersPlusPrevAndNext
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetBootstrap4Option(option);
                SetPageNumbersPlusPrevAndNextOption(option);

                return option;
            }
        }

        /// <summary>
        /// Show Page Numbers plus First and Last links.
        /// </summary>
        public static PagedListRenderOptions Bootstrap4PageNumbersPlusFirstAndLast
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetBootstrap4Option(option);
                SetPageNumbersPlusFirstAndLastOption(option);

                return option;
            }
        }

        /// <summary>
        /// Show Page Numbers plus Previous, Next, First and Last links.
        /// </summary>
        public static PagedListRenderOptions Bootstrap4Full
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetBootstrap4Option(option);
                SetFullOption(option);

                return option;
            }
        }

        public string ContainerHtmlTag { get; private set; }
    }
}

