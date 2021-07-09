using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BeltExam.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BeltExam.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        private int? uid
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
        }
        private bool isLoggedIn
        {
            get { return uid != null; }
        }
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if (!isLoggedIn)
            {
                return View();
            }
            return RedirectToAction("Dashboard");
        }
//reg
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            //black belt
            HashSet<char> specialCharacters = new HashSet<char>() { '%', '$', '#','@','&','!' };
            if (user.Password.Any(char.IsLower) &&
                user.Password.Any(char.IsDigit) &&
                user.Password.Any(specialCharacters.Contains)) //valid password
            {
            // Check initial ModelState => if there are no errors
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == user.Email))
                {
                    // email exist in users table
                    ModelState.AddModelError("Email", "Email already in use!");
                    // back to Reg form
                    return View("Index");
                }
                
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                _context.Users.Add(user);
                _context.SaveChanges();
                // save user id to session
                HttpContext.Session.SetInt32("UserId", user.UserId);
                // to Dashboard
                return RedirectToAction("Dashboard");
            }
            // if not valid info
            return View("Index");
            }
            ModelState.AddModelError("Password", "Password must contain at least 1 number, 1 letter, and a special character{%,$,#,@,&,!}");
            return View("Index");
        }

//login
        [HttpPost("login")]
        public IActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == user.LoginEmail);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.LoginPassword);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("LoginPassword", "Invalid Email/Password");
                    return View("Index");
                }
                // if result is not 0, then it is valid
                // Store user id into session
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

// Dashboard
        [HttpGet("Home")]
        public IActionResult Dashboard(){
            if (!isLoggedIn)
            {
                return RedirectToAction("index");
            }
            // user
            User u = _context.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            // all activities
            List<Activityy> allActivities=_context.Activities.OrderByDescending(a => a.UpdatedAt)
            .Include(a => a.PlanedBy)
            .Include(a=>a.participants)
            .ToList();
            return View(allActivities);
        }

// new act form
        [HttpGet("new")]
        public IActionResult newAct()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("index");
            }
            return View();
        }
// process new act

        [HttpPost("processNew")]
        public IActionResult ProcessAct(Activityy act)
        {
            if(act.ActDate <= DateTime.Now)
            {
                ModelState.AddModelError("ActDate", "Date must be in the Future");
            }
            if(ModelState.IsValid)
            {
                // planned by is the user in sessieon
                act.UserId = (int)uid;
                _context.Activities.Add(act);
                _context.SaveChanges();
                //route
                return Redirect($"/activity/{act.ActivityId}");
            }
            return View("newAct");
        }

// activity details
        [HttpGet("activity/{actId}")]
        public IActionResult ActDetails(int actId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("index");
            }
            User u = _context.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            // get activity
            Activityy activity=_context.Activities
            .Include(a =>a.PlanedBy)
            .Include(a =>a.participants) // include list of participants in a wedding
            .ThenInclude(p =>p.participant) // include th participant of class Participate in the participants list!
            .FirstOrDefault(a =>a.ActivityId==actId);
            return View(activity);
        }
        //delete act
        [HttpGet("/delete/{actId}")]
        public IActionResult Delete(int actId)
        {
            Activityy act=_context.Activities.FirstOrDefault(a => a.ActivityId==actId);
            _context.Activities.Remove(act);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

//Join
        [HttpGet("join/{actId}")]
        public IActionResult Join(int actId)
        {
            Participate participate=new Participate();
            participate.UserId=(int)uid;
            participate.ActivityId=actId;
            _context.Participates.Add(participate);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

//Leave
        [HttpGet("leave/{actId}")]
        public IActionResult Leave(int actId)
        {
            Participate participate=_context.Participates.FirstOrDefault(p =>p.UserId==(int)uid && p.ActivityId==actId);
            _context.Participates.Remove(participate);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

















// logout
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
