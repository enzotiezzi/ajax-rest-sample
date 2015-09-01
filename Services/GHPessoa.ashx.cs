using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace rest1.Services
{
    /// <summary>
    /// Summary description for GHPessoa
    /// </summary>
    public class GHPessoa : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Cache.SetNoStore(); //IE caches by default...
            context.Response.TrySkipIisCustomErrors = true;
            context.Response.ContentType = "application/json";
            context.Response.ContentEncoding = Encoding.UTF8;

            Pessoa p;
            p = new Pessoa();
            p.Nome = "Enzo";
            p.SobreNome = "Tiezzi";
            p.Idade = 20;
            //"{"Nome":"Enzo","SobreNome":"Tiezzi","Idade":19}"
            String json = new JavaScriptSerializer().Serialize(p);
            context.Response.Write(json);
            context.Response.StatusCode = 200;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}