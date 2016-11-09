using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JabberBCIT.Controllers
{
    [Authorize]
    public class ForumController : Controller
    {
        // GET: Forum
        public ActionResult ForumMain()
        {
            return View();
        }

        public ActionResult CreateForumPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateForumPost(ForumPost post)
        {
            //post.UserID = User.Identity.
            post.PostTimestamp = DateTime.Now;
            post.Votes = 0;

            db.ForumPosts.Add(post);
            db.SaveChanges();
            return View();
        }

        public ActionResult ViewForumThread()
        {

            return View();
        }
    }
}