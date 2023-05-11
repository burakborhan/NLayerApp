using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTO_s;
using NLayer.Core.Models;
using System.Diagnostics;
using NLayer.Service.Helpers;


namespace NLayer.WEB.Controllers
{
    public class HomeController : Controller
    {
        public UserManager<AppUser> userManager { get; set; }
        public SignInManager<AppUser> signInManager { get; set; }

        public HomeController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public IActionResult Login(string ReturnUrl)
        {

            TempData["ReturnUrl"] = ReturnUrl;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel userLogin)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await userManager.FindByNameAsync(userLogin.userName);

                if (user != null)
                {
                    if (await userManager.IsLockedOutAsync(user))
                    {
                        ModelState.AddModelError("", "Your account is locked for a while. Please try again later.");
                        return View(userLogin);
                    }

                    if (userManager.IsEmailConfirmedAsync(user).Result == false)
                    {
                        ModelState.AddModelError("", "Your e-mail adress is not confirmed. Please confirm your e-mail adress.");
                        return View(userLogin);
                    }

                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, userLogin.Password, userLogin.RememberMe, false);




                    if (result.Succeeded)
                    {
                        await userManager.ResetAccessFailedCountAsync(user);

                        if (TempData["ReturnUrl"] != null)
                        {
                            return Redirect(TempData["ReturnUrl"].ToString());
                        }
                        return RedirectToAction("Index", "Products");
                    }
                    else
                    {
                        await userManager.AccessFailedAsync(user);

                        int fail = await userManager.GetAccessFailedCountAsync(user);

                        ModelState.AddModelError("", $"{fail} failed login. ");

                        if (fail == 3)
                        {
                            await userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.Now.AddMinutes(10)));
                            ModelState.AddModelError("", "Your login attempt failed 3 times. Your account has been banned for 10 minutes. Please try again later.");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Invalid username or password");
                        }

                    }
                }
                else
                {
                    ModelState.AddModelError(nameof(LoginViewModel.userName), "Invalid username or password");
                }

            }
            return View(userLogin);
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserViewModel userViewModel)
        {

            if (ModelState.IsValid)
            {
                if (userManager.Users.Any(u => u.PhoneNumber == userViewModel.PhoneNumber))
                {
                    ModelState.AddModelError("", "This phone number is registered");
                    return View(userViewModel);
                }


                AppUser user = new AppUser();
                user.UserName = userViewModel.UserName;
                user.Email = userViewModel.Email;
                user.PhoneNumber = userViewModel.PhoneNumber;
                user.CompanyName = userViewModel.CompanyName;

                IdentityResult result = await userManager.CreateAsync(user, userViewModel.Password);

                if (result.Succeeded)
                {
                    string confirmationToken = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    string link = Url.Action("ConfirmEmail", "Home", new
                    {
                        userId = user.Id,
                        token = confirmationToken,
                    }, protocol: HttpContext.Request.Scheme

                    );

                    EmailConfirmation.EmailConfirmationHelper(link, user.Email);

                    return RedirectToAction("Login");
                }
                else
                {
                    AddModelError(result);
                }
            }

            return View(userViewModel);
        }
        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            AppUser user = userManager.FindByEmailAsync(resetPasswordViewModel.Email).Result;

            if (user != null)
            {
                string passwordResetToken = userManager.GeneratePasswordResetTokenAsync(user).Result;

                string passwordResetLink = Url.Action("ResetPasswordConfirm", "Home", new
                {
                    userId = user.Id,
                    token = passwordResetToken
                }, HttpContext.Request.Scheme);

                //www.iMapMapComminication.com/Home/ResetPasswordConfirm?userId=asdfasdfsd&token=sadfasdfsa
                PasswordReset.PasswordResetEmail(passwordResetLink, resetPasswordViewModel);

                ViewBag.status = "Succesfull";
            }
            else
            {
                ModelState.AddModelError("", "Your e-mail address is not registered in the system.");
            }


            return View(resetPasswordViewModel);
        }

        public IActionResult ResetPasswordConfirm(string userId, string token)
        {
            TempData["userId"] = userId;
            TempData["token"] = token;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPasswordConfirm(ResetPasswordViewModel request)
        {
            var userId = TempData["userId"];
            var token = TempData["token"];

            if (userId == null || token == null)
            {
                throw new Exception("An error has occurred");
            }

            var hasUser = await userManager.FindByIdAsync(userId.ToString()!);

            if (hasUser == null)
            {
                ModelState.AddModelError(String.Empty, "User couldn't found.");
                return View();
            }

            IdentityResult result = await userManager.ResetPasswordAsync(hasUser, token.ToString()!, request.NewPassword);

            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "Your password has been successfully reset";
            }
            else
            {
                ModelState.AddModelError("", "There was an error. Please try again.");
            }

            return View();
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var user = await userManager.FindByIdAsync(userId);

            IdentityResult result = await userManager.ConfirmEmailAsync(user, token);

            if (result.Succeeded)
            {
                ViewBag.status = "Your e-mail is confirmed. You can login in login page.";
            }
            else
            {
                ViewBag.status = "An error occured. Please try again.";
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(ErrorViewModel errorViewModel)
        {
            return View(errorViewModel);
        }

        public void AddModelError(IdentityResult result)
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
        }
    }
}