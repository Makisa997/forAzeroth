using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace forAzeroth.Helpers
{
    public static class Helpers
    {
        public static MvcHtmlString ProfileHelper(string text)
        {
            var tagBuilder = new TagBuilder("div");
            tagBuilder.InnerHtml =  "<br>" + "<br>" + "<h2>" + text + "</h2>";
            tagBuilder.AddCssClass("helper");
            return new MvcHtmlString(tagBuilder.ToString());
        }
        public static MvcHtmlString OfficerHelper(string Name, string CharacterName, int Age, int YearsOfExperience)
        {
            var tagBuilder = new TagBuilder("tr");
            tagBuilder.InnerHtml = " <td>" + Name + "</td>" + "<td>" + Age + " " + YearsOfExperience + "</td>" + "<td>" + CharacterName + "</td>";
            tagBuilder.AddCssClass("red");
            return new MvcHtmlString(tagBuilder.ToString());
        }
    }
}