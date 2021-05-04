using System;
using System.Collections.Generic;

namespace com.study.core.web.menu
{
    public class MenuItem
    {
        public MenuItem(string catergory ,  string  controller , string action ,  string label  , bool istop)
        {
            Controller = controller;
            Label = label;
            Action = action;
            IsTop = istop;
            Category = catergory;
        
        }

        public string Category { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Label { get; set; }

        public bool IsTop { get; set; }

        public static List<MenuItem>  CreateMenus()
        {
            var lists = new List<MenuItem>();
            lists.Add(new MenuItem("Survey","TblSurveys","Index" , "조사" , true));
            lists.Add(new MenuItem("Survey", "TblLists", "Index", "리스트" , false));
            lists.Add(new MenuItem("Survey", "TblQuestions", "Index", "항목", false));

            return lists;

        }
    }
}
