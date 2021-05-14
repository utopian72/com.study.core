using System;
using System.Collections.Generic;
using System.Text;
using com.study.core.model;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace com.study.core.service.user
{
    class daoUser
    {
        private mobileSurveyContext _context;
        public daoUser(mobileSurveyContext context)
        {
            _context = context;
        }


        public int UpdatePassword(TblUser user)
        {
            return UpdatePassword(user, user.Pwd);
        }
        public int UpdatePassword(TblUser user , string password)
        {
            //단방향 알고리즘
            //MD2 | MD4 | MD5 | SHA | SHA1 | SHA2_256 | SHA2_512

            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@memId", user.MemId));
            paras.Add(new SqlParameter("@pwd", password));

            string query = @"UPDATE [dbo].[tbl_user]
                                       SET 
                                          [pwd] = HASHBYTES('SHA2_512', @pwd);
                                     WHERE [memId] = @memId";
            
            //ExecuteSqlInterpolated:사용 방법?

            return _context.Database.ExecuteSqlCommand(query , paras.AsEnumerable());
           
        }

        public List<TblUser> GetUsers()
        {
            //예시
            //var books = context.Books
            //    .FromSql("SELECT * FROM Books")
            //    .Select(b => new {
            //        BookId = b.BookId,
            //        Title = b.Title
            //    }).ToList();

            string query = "SELECT *  FROM [dbo].[tbl_user]";
            return _context.TblUsers.FromSqlRaw(query).ToList();
        }


        public TblUser GetUser(string id , string password)
        {
            //예시
            //var books = context.Books
            //    .FromSql("SELECT * FROM Books")
            //    .Select(b => new {
            //        BookId = b.BookId,
            //        Title = b.Title
            //    }).ToList();


            string query = @"SELECT *  
                                        FROM [dbo].[tbl_user] 
                                        where Memid =@memId 
                                        and  pwd =  HASHBYTES('SHA2_512', @pwd)";

            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@memId", id));
            paras.Add(new SqlParameter("@pwd", password));
            try
            {
                return _context.TblUsers.FromSqlRaw(query, paras).FirstOrDefault();
            }catch
            {
                return null;
            }
        }

    }
}
