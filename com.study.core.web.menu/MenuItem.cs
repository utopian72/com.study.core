using System;
using System.Collections.Generic;
using System.Linq;
namespace com.study.core.web.menu
{
    public class MenuItem
    {
        private static List<MenuItem> _lists =  new List<MenuItem>();

        static MenuItem()
        {
            
            _lists.Add(new MenuItem("TblSurveys", "TblSurveys", "Index", "조사", true));
            _lists.Add(new MenuItem("TblSurveys", "TblLists", "Index", "리스트", false));
            _lists.Add(new MenuItem("TblSurveys", "TblQuestions", "Index", "항목", false));
            _lists.Add(new MenuItem("TblUsers", "TblUsers", "Index", "사용자", true));

        }
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
            return _lists;
        }
        public static List<MenuItem> GetCategoryMenus(MenuItem topmenu)
        {
            try
            {
                return _lists.Where(m=>!m.IsTop)
                                .Where(m => m.Category.Equals(topmenu.Category))
                                .ToList();
            }
            catch
            {
                return null;
            }
        }

        public static MenuItem GetMenu(string controllername)
        {
            try
            {
                return _lists.Where(m => m.Controller.Equals(controllername)).ToList().FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
    }
}
