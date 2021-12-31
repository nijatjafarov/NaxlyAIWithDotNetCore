using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NaxlyAI.Models;
using NaxlyAI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Controllers
{
    public class AdminController : Controller
    {
        NaxlyAIContext context = new NaxlyAIContext();
        IHostingEnvironment hostingEnvironment;

        public AdminController(IHostingEnvironment _hostingEnvironment)
        {
            hostingEnvironment = _hostingEnvironment;
        }
        public IActionResult Index()
        {
            AdminHome admin = new AdminHome()
            {
                HomePage = context.HomePages.FirstOrDefault(),
                Configuration = context.Configurations.FirstOrDefault(),
                Clients = context.Clients,
                Testimonials = context.Testimonials,
                UserMessages = context.UserMessages
            };

            return View(admin);
        }

        public IActionResult EditHomePage()
        {
            HomePage home = context.HomePages.FirstOrDefault();
            EditHome homeView = new EditHome()
            {
                AboutServices = home.AboutServices,
                AboutProjects = home.AboutProjects,
                AboutWorkProcess = home.AboutWorkProcess,
                WorkProcessHeader1 = home.WorkProcessHeader1,
                WorkProcessDesc1 = home.WorkProcessDesc1,
                WorkProcessHeader2 = home.WorkProcessHeader2,
                WorkProcessDesc2 = home.WorkProcessDesc2,
                WorkProcessHeader3 = home.WorkProcessHeader3,
                WorkProcessDesc3 = home.WorkProcessDesc3,
                AboutWhyChooseUs = home.AboutWhyChooseUs,
                ClientDescription = home.ClientDescription
            };
            ViewData["Title"] = "Edit Home Page";
            ViewData["PageDesc"] = ViewData["Title"];
            ViewData["Button"] = "Edit";

            return View(homeView);
        }

        [HttpPost]
        public IActionResult EditHomePage(EditHome page)
        {
            if (ModelState.IsValid)
            {
                HomePage home = context.HomePages.FirstOrDefault();
                if (page.FirstPicture != null)
                {
                    home.FirstPicture = FileHandler(page.FirstPicture, home.FirstPicture);
                }
                home.AboutServices = page.AboutServices;

                if(page.ServicesPicture != null)
                {
                    home.ServicesPicture = FileHandler(page.ServicesPicture, home.ServicesPicture);
                }

                home.AboutProjects = page.AboutProjects;
                home.AboutWorkProcess = page.AboutWorkProcess;
                home.WorkProcessHeader1 = page.WorkProcessHeader1;
                home.WorkProcessDesc1 = page.WorkProcessDesc1;
                home.WorkProcessHeader2 = page.WorkProcessHeader2;
                home.WorkProcessDesc2 = page.WorkProcessDesc2;
                home.WorkProcessHeader3 = page.WorkProcessHeader3;
                home.WorkProcessDesc3 = page.WorkProcessDesc3;
                home.AboutWhyChooseUs = page.AboutWhyChooseUs;

                if (page.WhyChooseUsPicture != null)
                {
                    home.WhyChooseUsPicture = FileHandler(page.WhyChooseUsPicture, home.WhyChooseUsPicture);
                }

                home.ClientDescription = page.ClientDescription;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public string FileHandler(IFormFile formProperty, string mainProperty)
        {
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
            string uniqueFileName = Guid.NewGuid() + "_" + formProperty.FileName;
            string newFilePath = Path.Combine(uploadsFolder, uniqueFileName);
            var file = new FileStream(newFilePath, FileMode.Create);
            formProperty.CopyTo(file);
            file.Close();

            if (mainProperty != null)
            {
                DeleteFile(mainProperty);
            }
            return uniqueFileName;
        }

        public void DeleteFile(string file)
        {
            if (file != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                string oldFilePath = Path.Combine(uploadsFolder, file);
                if (System.IO.File.Exists(oldFilePath))
                {
                    System.IO.File.Delete(oldFilePath);
                }
            }
        }

        public IActionResult EditConfiguration()
        {
            Configuration config = context.Configurations.FirstOrDefault();

            ConfigurationModel model = new ConfigurationModel()
            {
                Description = config.Description,
                PhoneNumber = config.PhoneNumber,
                Slogan = config.Slogan
            };
            ViewData["Title"] = "Edit Configuration";
            ViewData["PageDesc"] = ViewData["Title"];
            ViewData["Button"] = "Edit";

            return View(model);
        }

        [HttpPost]
        public IActionResult EditConfiguration(ConfigurationModel model)
        {
            if (ModelState.IsValid)
            {
                Configuration config = context.Configurations.FirstOrDefault();
                if (model.Logo != null)
                {
                    config.Logo = FileHandler(model.Logo, config.Logo);
                }

                config.Description = model.Description;
                config.PhoneNumber = model.PhoneNumber;
                config.Slogan = model.Slogan;

                if (model.SecondLogo != null)
                {
                    config.SecondLogo = FileHandler(model.SecondLogo, config.SecondLogo);
                }

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult AddClient()
        {
            ClientModel model = new ClientModel();

            ViewData["PageDesc"] = "Add Client";
            ViewData["Button"] = "Add";

            return View("ClientPage", model);
        }

        [HttpPost]
        public IActionResult AddClient(ClientModel model)
        {
            if(model.Logo == null)
            {
                ModelState.AddModelError("Logo", "Logo field is required");
            }
            if (ModelState.IsValid)
            {
                Client client = new Client();
                client.Name = model.Name;
                if (model.Logo != null)
                {
                    client.Logo = FileHandler(model.Logo, client.Logo);
                }
                client.Url = model.Url;

                context.Clients.Add(client);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewData["PageDesc"] = "Add Client";
            ViewData["Button"] = "Add";

            return View("ClientPage", model);
        }

        public IActionResult UpdateClient(int id)
        {
            Client client = context.Clients.Find(id);

            ClientModel model = new ClientModel()
            {
                Name = client.Name,
                Url = client.Url
            };

            TempData["ClientId"] = client.Id;
            ViewData["PageDesc"] = "Update Client";
            ViewData["Button"] = "Update";

            return View("ClientPage", model);
        }

        [HttpPost]
        public IActionResult UpdateClient(ClientModel model)
        {
            if (ModelState.IsValid)
            {
                Client client = context.Clients.Find(int.Parse(TempData["ClientId"].ToString()));
                client.Name = model.Name;
                if (model.Logo != null)
                {
                    client.Logo = FileHandler(model.Logo, client.Logo);
                }
                client.Url = model.Url;

                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewData["PageDesc"] = "Update Client";
            ViewData["Button"] = "Update";

            return View("ClientPage", model);
        }

        public IActionResult DeleteClient(int id)
        {
            Client client = context.Clients.Find(id);
            if(client.Logo != null)
            {
                DeleteFile(client.Logo);
            }
            context.Clients.Remove(client);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult AddTestimonial()
        {
            TestimonialModel model = new TestimonialModel();

            ViewData["PageDesc"] = "Add Testimonial";
            ViewData["Button"] = "Add";

            return View("TestimonialPage", model);
        }

        [HttpPost]
        public IActionResult AddTestimonial(TestimonialModel model)
        {
            if (model.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo is required");
            }
            if (ModelState.IsValid)
            {
                Testimonial testimonial = new Testimonial();
                testimonial.Fullname = model.Fullname;
                testimonial.Photo = FileHandler(model.Photo, testimonial.Photo);
                testimonial.Designation = model.Designation;
                testimonial.Review = model.Review;
                testimonial.NumberOfStars = model.NumberOfStars;
                testimonial.Date = DateTime.UtcNow;

                context.Testimonials.Add(testimonial);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewData["PageDesc"] = "Add Testimonial";
            ViewData["Button"] = "Add";

            return View("TestimonialPage", model);
        }

        public IActionResult UpdateTestimonial(int id)
        {
            Testimonial testimonial = context.Testimonials.Find(id);

            TestimonialModel model = new TestimonialModel()
            {
                Fullname = testimonial.Fullname,
                Designation = testimonial.Designation,
                Review = testimonial.Review,
                NumberOfStars = testimonial.NumberOfStars
        };

            TempData["TestimonialId"] = testimonial.Id;
            ViewData["PageDesc"] = "Update Testimonial";
            ViewData["Button"] = "Update";

            return View("TestimonialPage", model);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(TestimonialModel model)
        {
            if (ModelState.IsValid)
            {
                Testimonial testimonial = context.Testimonials.Find(int.Parse(TempData["TestimonialId"].ToString()));
                testimonial.Fullname = model.Fullname;
                if (model.Photo != null)
                {
                    testimonial.Photo = FileHandler(model.Photo, testimonial.Photo);
                }
                testimonial.Review = model.Review;
                testimonial.Designation = model.Designation;
                testimonial.NumberOfStars = model.NumberOfStars;
                testimonial.Date = DateTime.UtcNow;

                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewData["PageDesc"] = "Update Testimonial";
            ViewData["Button"] = "Update";

            return View("TestimonialPage", model);
        }

        public IActionResult DeleteTestimonial(int id)
        {
            Testimonial testimonial = context.Testimonials.Find(id);
            DeleteFile(testimonial.Photo);
            context.Testimonials.Remove(testimonial);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteUserMessage(int id)
        {
            UserMessage message = context.UserMessages.Find(id);
            context.UserMessages.Remove(message);
            context.SaveChanges();

            return RedirectToAction("Index");
        }


        // Company Page

        public IActionResult Company()
        {
            AdminCompany company = new AdminCompany()
            {
                AboutPage = context.AboutCompanies.FirstOrDefault(),
                ContactPage = context.Contacts.FirstOrDefault(),
                StepsOfHistory = context.StepOfHistories,
                ReasonsToChooseUs = context.ReasonForChoosingUs,
                SocialMediasOfCompany = context.SocialMediaOfCompanies
            };

            return View(company);
        }

        public IActionResult EditAboutPage()
        {
            AboutCompany aboutPage = context.AboutCompanies.FirstOrDefault();

            EditAbout editAbout = new EditAbout()
            {
                PageHeader = aboutPage.PageHeader,
                Slogan = aboutPage.Slogan,
                Description = aboutPage.Description,
                VideoTitle = aboutPage.VideoTitle,
                VideoUrl = aboutPage.VideoUrl,
                FoundationYear = aboutPage.FoundationYear,
                AboutOurHistory = aboutPage.AboutOurHistory,
                WhyChooseUs = aboutPage.WhyChooseUs,
                TeamMemberDesc = aboutPage.TeamMemberDesc
            };

            ViewData["Title"] = "Update About Page";
            ViewData["PageDesc"] = ViewData["Title"];
            ViewData["Button"] = "Update";
            return View(editAbout);
        }

        [HttpPost]
        public IActionResult EditAboutPage(EditAbout editAbout)
        {
            if (ModelState.IsValid)
            {
                AboutCompany aboutPage = context.AboutCompanies.FirstOrDefault();

                aboutPage.PageHeader = editAbout.PageHeader;
                aboutPage.Slogan = editAbout.Slogan;
                aboutPage.Description = editAbout.Description;
                aboutPage.VideoTitle = editAbout.VideoTitle;
                aboutPage.VideoUrl = editAbout.VideoUrl;
                aboutPage.FoundationYear = editAbout.FoundationYear;

                if (editAbout.Picture1 != null)
                {
                    aboutPage.Picture1 = FileHandler(editAbout.Picture1, aboutPage.Picture1);
                }

                if (editAbout.Picture2 != null)
                {
                    aboutPage.Picture2 = FileHandler(editAbout.Picture2, aboutPage.Picture2);
                }

                if (editAbout.Picture3 != null)
                {
                    aboutPage.Picture3 = FileHandler(editAbout.Picture3, aboutPage.Picture3);
                }

                aboutPage.AboutOurHistory = editAbout.AboutOurHistory;
                aboutPage.WhyChooseUs = editAbout.WhyChooseUs;

                if (editAbout.WhyChooseUsPicture1 != null)
                {
                    aboutPage.WhyChooseUsPicture1 = FileHandler(editAbout.WhyChooseUsPicture1,
                        aboutPage.WhyChooseUsPicture1);
                }

                if (editAbout.WhyChooseUsPicture2 != null)
                {
                    aboutPage.WhyChooseUsPicture2 = FileHandler(editAbout.WhyChooseUsPicture2,
                        aboutPage.WhyChooseUsPicture2);
                }

                aboutPage.TeamMemberDesc = editAbout.TeamMemberDesc;

                if (editAbout.HomeCoverPicture != null)
                {
                    aboutPage.HomeCoverPicture = FileHandler(editAbout.HomeCoverPicture,
                        aboutPage.HomeCoverPicture);
                }

                context.SaveChanges();

                return RedirectToAction("Company");
            }

            ViewData["Title"] = "Update About Page";
            ViewData["PageDesc"] = ViewData["Title"];
            ViewData["Button"] = "Update";
            return View(editAbout);
        }

        public IActionResult AddStepOfHistory()
        {
            if (context.StepOfHistories.Count() >= 4)
            {
                return RedirectToAction("Company");
            }

            ViewData["PageDesc"] = "Add Step for History";
            ViewData["Button"] = "Add";

            return View("StepOfHistoryPage");
        }

        [HttpPost]
        public IActionResult AddStepOfHistory(StepOfHistory step)
        {
            if (ModelState.IsValid)
            {
                context.StepOfHistories.Add(step);
                context.SaveChanges();
                return RedirectToAction("Company");
            }

            ViewData["PageDesc"] = "Add Step for History";
            ViewData["Button"] = "Add";

            return View("StepOfHistoryPage", step);
        }

        public IActionResult UpdateStepOfHistory(int id)
        {
            StepOfHistory step = context.StepOfHistories.Find(id);

            ViewData["PageDesc"] = "Update Step of History";
            ViewData["Button"] = "Update";

            return View("StepOfHistoryPage", step);
        }

        [HttpPost]
        public IActionResult UpdateStepOfHistory(StepOfHistory model)
        {
            if (ModelState.IsValid)
            {
                StepOfHistory step = context.StepOfHistories.Find(model.Id);

                step.Header = model.Header;
                step.Description = model.Description;
                step.Year = model.Year;

                context.SaveChanges();
                return RedirectToAction("Company");
            }

            ViewData["PageDesc"] = "Update Step of History";
            ViewData["Button"] = "Update";

            return View("StepOfHistoryPage", model);
        }

        public IActionResult DeleteStepOfHistory(int id)
        {
            StepOfHistory step = context.StepOfHistories.Find(id);
            context.StepOfHistories.Remove(step);
            context.SaveChanges();

            return RedirectToAction("Company");
        }

        public IActionResult EditContactPage()
        {
            Contact contact = context.Contacts.FirstOrDefault();

            EditContact editContact = new EditContact()
            {
                PageHeader = contact.PageHeader,
                InnerHeader = contact.InnerHeader,
                Slogan = contact.Slogan, 
                Description = contact.Description,
                LocationHeader = contact.LocationHeader,
                LocationDesc = contact.LocationDesc,
                Address = contact.Address,
                PhoneHeader = contact.PhoneHeader,
                PhoneDesc = contact.PhoneDesc,
                PhoneNum = contact.PhoneNum,
                PhoneTime = contact.PhoneTime,
                EmailHeader = contact.EmailHeader,
                EmailDesc = contact.EmailDesc,
                Email1 = contact.Email1,
                Email2 = contact.Email2
            };

            ViewData["Title"] = "Update Contact Page";
            ViewData["PageDesc"] = ViewData["Title"];
            ViewData["Button"] = "Update";
            return View(editContact);
        }

        [HttpPost]
        public IActionResult EditContactPage(EditContact editContact)
        {
            if (ModelState.IsValid)
            {
                Contact contactPage = context.Contacts.FirstOrDefault();

                contactPage.PageHeader = editContact.PageHeader;
                contactPage.InnerHeader = editContact.InnerHeader;
                contactPage.Slogan = editContact.Slogan;
                contactPage.Description = editContact.Description;
                contactPage.LocationHeader = editContact.LocationHeader;
                contactPage.LocationDesc = editContact.LocationDesc;
                contactPage.Address = editContact.Address;
                contactPage.PhoneHeader = editContact.PhoneHeader;
                contactPage.PhoneDesc = editContact.PhoneDesc;
                contactPage.PhoneNum = editContact.PhoneNum;
                contactPage.PhoneTime = editContact.PhoneTime;
                contactPage.EmailHeader = editContact.EmailHeader;
                contactPage.EmailDesc = editContact.EmailDesc;
                contactPage.Email1 = editContact.Email1;
                contactPage.Email2 = editContact.Email2;

                if (editContact.PagePicture != null)
                {
                    contactPage.PagePicture = FileHandler(editContact.PagePicture, contactPage.PagePicture);
                }

                context.SaveChanges();

                return RedirectToAction("Company");
            }

            ViewData["Title"] = "Update Contact Page";
            ViewData["PageDesc"] = ViewData["Title"];
            ViewData["Button"] = "Update";
            return View(editContact);
        }

        public IActionResult AddReasonToChooseUs()
        {
            if (context.ReasonForChoosingUs.Count() >= 3)
            {
                return RedirectToAction("Company");
            }

            ViewData["PageDesc"] = "Add Reason for Choosing Us";
            ViewData["Button"] = "Add";

            return View("ChooseUsPage");
        }

        [HttpPost]
        public IActionResult AddReasonToChooseUs(ReasonForChoosingU reason)
        {
            if (ModelState.IsValid)
            {
                context.ReasonForChoosingUs.Add(reason);
                context.SaveChanges();
                return RedirectToAction("Company");
            }

            ViewData["PageDesc"] = "Add Reason for Choosing Us";
            ViewData["Button"] = "Add";

            return View("ChooseUsPage", reason);
        }

        public IActionResult UpdateReasonToChooseUs(int id)
        {
            ReasonForChoosingU reason = context.ReasonForChoosingUs.Find(id);

            ViewData["PageDesc"] = "Update Reason of Choosing Us";
            ViewData["Button"] = "Update";

            return View("ChooseUsPage", reason);
        }

        [HttpPost]
        public IActionResult UpdateReasonToChooseUs(ReasonForChoosingU model)
        {
            if (ModelState.IsValid)
            {
                ReasonForChoosingU reason = context.ReasonForChoosingUs.Find(model.Id);

                reason.Header = model.Header;
                reason.Descrioption = model.Descrioption;
                reason.Icon = model.Icon;

                context.SaveChanges();
                return RedirectToAction("Company");
            }

            ViewData["PageDesc"] = "Update Reason of Choosing Us";
            ViewData["Button"] = "Update";

            return View("ChooseUsPage", model);
        }

        public IActionResult DeleteReasonToChooseUs(int id)
        {
            ReasonForChoosingU reason = context.ReasonForChoosingUs.Find(id);
            context.ReasonForChoosingUs.Remove(reason);
            context.SaveChanges();

            return RedirectToAction("Company");
        }

        public IActionResult AddCompanySM()
        {

            ViewData["PageDesc"] = "Add Social Media for Company";
            ViewData["Button"] = "Add";

            return View("CompanySmPage");
        }

        [HttpPost]
        public IActionResult AddCompanySM(SocialMediaOfCompany companySm)
        {
            if (ModelState.IsValid)
            {
                context.SocialMediaOfCompanies.Add(companySm);
                context.SaveChanges();
                return RedirectToAction("Company");
            }

            ViewData["PageDesc"] = "Add Social Media for Company";
            ViewData["Button"] = "Add";

            return View("CompanySmPage", companySm);
        }

        public IActionResult UpdateCompanySM(int id)
        {
            SocialMediaOfCompany companySm = context.SocialMediaOfCompanies.Find(id);

            ViewData["PageDesc"] = "Update Social Media of Company";
            ViewData["Button"] = "Update";

            return View("CompanySmPage", companySm);
        }

        [HttpPost]
        public IActionResult UpdateCompanySM(SocialMediaOfCompany model)
        {
            if (ModelState.IsValid)
            {
                SocialMediaOfCompany companySm = context.SocialMediaOfCompanies.Find(model.Id);

                companySm.Name = model.Name;
                companySm.Icon = model.Icon;
                companySm.Url = model.Url;

                context.SaveChanges();
                return RedirectToAction("Company");
            }

            ViewData["PageDesc"] = "Update Social Media of Company";
            ViewData["Button"] = "Update";

            return View("CompanySmPage", model);
        }

        public IActionResult DeleteCompanySM(int id)
        {
            SocialMediaOfCompany companySm = context.SocialMediaOfCompanies.Find(id);
            context.SocialMediaOfCompanies.Remove(companySm);
            context.SaveChanges();

            return RedirectToAction("Company");
        }

        // Team Page
        public IActionResult Team()
        {
            AdminTeam team = new AdminTeam()
            {
                TeamMembers = context.TeamMembers,
                SocialMedias = context.SocialMedia,
                SMsOfMembers = context.SocialMediaAccountOfMembers
            };

            return View(team);
        }

        public IActionResult AddTeamMember()
        {
            MemberModel model = new MemberModel();

            ViewData["PageDesc"] = "Add Team Member";
            ViewData["Button"] = "Add";

            return View("TeamMemberPage", model);
        }

        [HttpPost]
        public IActionResult AddTeamMember(MemberModel model)
        {
            if (model.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo is required");
            }
            if (ModelState.IsValid)
            {
                TeamMember member = new TeamMember();
                member.Photo = FileHandler(model.Photo, member.Photo);
                member.Fullname = model.Fullname;
                member.Designation = model.Designation;
                member.Email = model.Email;

                context.TeamMembers.Add(member);
                context.SaveChanges();
                return RedirectToAction("Team");
            }

            ViewData["PageDesc"] = "Add Team Member";
            ViewData["Button"] = "Add";

            return View("TeamMemberPage", model);
        }

        public IActionResult UpdateTeamMember(int id)
        {
            TeamMember member = context.TeamMembers.Find(id);

            MemberModel model = new MemberModel()
            {
                Fullname = member.Fullname,
                Designation = member.Designation,
                Email = member.Email
            };

            TempData["MemberId"] = member.Id;
            ViewData["PageDesc"] = "Update Team Member";
            ViewData["Button"] = "Update";

            return View("TeamMemberPage", model);
        }

        [HttpPost]
        public IActionResult UpdateTeamMember(MemberModel model)
        {
            if (ModelState.IsValid)
            {
                TeamMember member = context.TeamMembers.Find(int.Parse(TempData["MemberId"].ToString()));
                member.Fullname = model.Fullname;
                if (model.Photo != null)
                {
                    member.Photo = FileHandler(model.Photo, member.Photo);
                }
                member.Designation = model.Designation;
                member.Email = model.Email;

                context.SaveChanges();
                return RedirectToAction("Team");
            }

            ViewData["PageDesc"] = "Update Team Member";
            ViewData["Button"] = "Update";

            return View("TeamMemberPage", model);
        }

        public IActionResult DeleteTeamMember(int id)
        {
            TeamMember member = context.TeamMembers.Find(id);
            DeleteFile(member.Photo);
            context.TeamMembers.Remove(member);
            context.SaveChanges();

            return RedirectToAction("Team");
        }

        public IActionResult AddSocialMedia()
        {

            ViewData["PageDesc"] = "Add Social Media";
            ViewData["Button"] = "Add";

            return View("SocialMediaPage");
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedium media)
        {
            if (ModelState.IsValid)
            {
                context.SocialMedia.Add(media);
                context.SaveChanges();
                return RedirectToAction("Team");
            }

            ViewData["PageDesc"] = "Add Social Media";
            ViewData["Button"] = "Add";

            return View("SocialMediaPage", media);
        }

        public IActionResult UpdateSocialMedia(int id)
        {
            SocialMedium media = context.SocialMedia.Find(id);

            ViewData["PageDesc"] = "Update Social Media";
            ViewData["Button"] = "Update";

            return View("SocialMediaPage", media);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedium model)
        {
            if (ModelState.IsValid)
            {
                SocialMedium media = context.SocialMedia.Find(model.Id);

                media.Name = model.Name;
                media.Icon = model.Icon;

                context.SaveChanges();
                return RedirectToAction("Team");
            }

            ViewData["PageDesc"] = "Update Social Media";
            ViewData["Button"] = "Update";

            return View("SocialMediaPage", model);
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            SocialMedium media = context.SocialMedia.Find(id);
            context.SocialMedia.Remove(media);
            context.SaveChanges();

            return RedirectToAction("Team");
        }

        public IActionResult AddSMForMember()
        {

            ViewData["PageDesc"] = "Add Social Media Account to Member";
            ViewData["Button"] = "Add";

            return View("SmOfMemberPage");
        }

        [HttpPost]
        public IActionResult AddSMForMember(SocialMediaAccountOfMember media)
        {
            if (ModelState.IsValid)
            {
                context.SocialMediaAccountOfMembers.Add(media);
                context.SaveChanges();
                return RedirectToAction("Team");
            }

            ViewData["PageDesc"] = "Add Social Media Account to Member";
            ViewData["Button"] = "Add";

            return View("SmOfMemberPage", media);
        }

        public IActionResult UpdateSMForMember(int id)
        {
            SocialMediaAccountOfMember media = context.SocialMediaAccountOfMembers.Find(id);

            ViewData["PageDesc"] = "Update Social Media Account of Member";
            ViewData["Button"] = "Update";

            return View("SmOfMemberPage", media);
        }

        [HttpPost]
        public IActionResult UpdateSMForMember(SocialMediaAccountOfMember model)
        {
            if (ModelState.IsValid)
            {
                SocialMediaAccountOfMember media = context.SocialMediaAccountOfMembers.Find(model.Id);
                media.MemberId = model.MemberId;
                media.SocialMediaId = model.SocialMediaId;
                media.Url = model.Url;

                context.SaveChanges();
                return RedirectToAction("Team");
            }

            ViewData["PageDesc"] = "Update Social Media Account of Member";
            ViewData["Button"] = "Update";

            return View("SmOfMemberPage", model);
        }

        public IActionResult DeleteSMForMember(int id)
        {
            SocialMediaAccountOfMember media = context.SocialMediaAccountOfMembers.Find(id);
            context.SocialMediaAccountOfMembers.Remove(media);
            context.SaveChanges();

            return RedirectToAction("Team");
        }

        //Service Page
        public IActionResult Services()
        {
            AdminServices servicesPage = new AdminServices()
            {
                ServicesPage = context.ServicesPages.FirstOrDefault(),
                Services = context.Services,
                Subservices = context.Subservices.OrderBy(s => s.Service),
                ServiceFiles = context.ServiceFiles.OrderBy(s => s.Service),
                Industries = context.Industries,
                Technologies = context.Technologies
            };

            return View(servicesPage);
        }

        public IActionResult EditServicesPage()
        {
            ServicesPage page = context.ServicesPages.FirstOrDefault();

            ServicesPageModel model = new ServicesPageModel()
            {
                PageHeader = page.PageHeader,
                Explanation = page.Explanation,
                ExplanationAboutIndustries = page.ExplanationAboutIndustries,
                VideoUrl = page.VideoUrl,
                AwardText = page.AwardText,
                AwardDescription = page.AwardDescription
            };

            ViewData["Title"] = "Update Services Page";
            ViewData["PageDesc"] = ViewData["Title"];
            ViewData["Button"] = "Update";
            return View(model);
        }

        [HttpPost]
        public IActionResult EditServicesPage(ServicesPageModel model)
        {
            if (ModelState.IsValid)
            {
                ServicesPage servicesPage = context.ServicesPages.FirstOrDefault();

                servicesPage.PageHeader = model.PageHeader;
                servicesPage.Explanation = model.Explanation;
                servicesPage.ExplanationAboutIndustries = model.ExplanationAboutIndustries;
                servicesPage.VideoUrl = model.VideoUrl;
                servicesPage.AwardText = model.AwardText;

                if (model.AwardPicture != null)
                {
                    servicesPage.AwardPicture = FileHandler(model.AwardPicture, servicesPage.AwardPicture);
                }

                servicesPage.AwardDescription = model.AwardDescription;

                context.SaveChanges();

                return RedirectToAction("Services");
            }

            ViewData["Title"] = "Update Services Page";
            ViewData["PageDesc"] = ViewData["Title"];
            ViewData["Button"] = "Update";
            return View(model);
        }

        public IActionResult AddService()
        {
            ServiceModel model = new ServiceModel();

            ViewData["PageDesc"] = "Add Service";
            ViewData["Button"] = "Add";

            return View("ServicePage", model);
        }

        [HttpPost]
        public IActionResult AddService(ServiceModel model)
        {
            if (ModelState.IsValid)
            {
                Service service = new Service();
                service.Name = model.Name;
                service.PageHeader = model.PageHeader;
                service.Intro = model.Intro;
                service.Description = model.Description;
                service.StartYourProjectUrl = model.StartYourProjectUrl;
                if (model.FirstPicture != null)
                {
                    service.FirstPicture = FileHandler(model.FirstPicture, service.FirstPicture);
                }
                service.SubservicesHeader = model.SubservicesHeader;
                service.SubservicesDescription = model.SubservicesDescription;
                service.TechnologiesHeader = model.TechnologiesHeader;
                service.TechnologiesDescription = model.TechnologiesDescription;
                if (model.SecondPicture != null)
                {
                    service.SecondPicture = FileHandler(model.SecondPicture, service.SecondPicture);
                }
                service.ApplicationHeader = model.ApplicationHeader;
                service.ApplicationDescription = model.ApplicationDescription;
                service.ProjectsHeader = model.ProjectsHeader;
                if (model.CoverPicture != null)
                {
                    service.CoverPicture = FileHandler(model.CoverPicture, service.CoverPicture);
                }
                service.Icon = model.Icon;
                service.ContactHeader = model.ContactHeader;
                service.ContactDescription = model.ContactDescription;

                context.Services.Add(service);
                context.SaveChanges();

                if (model.TechIds != null && model.TechIds.Count() > 0)
                {
                    foreach (int techId in model.TechIds)
                    {
                        context.TechAndServices.Add(new TechAndService()
                        {
                            ServiceId = service.Id,
                            TechId = techId
                        });
                    }
                }

                if (model.IndustryIds != null && model.IndustryIds.Count() > 0)
                {
                    foreach (int industryId in model.IndustryIds)
                    {
                        context.ServiceAndIndustries.Add(new ServiceAndIndustry()
                        {
                            ServiceId = service.Id,
                            IndustryId = industryId
                        });
                    }
                }

                if (model.SubfieldString != null)
                {
                    string[] subfields = model.SubfieldString.Split(';');
                    foreach (string subfieldName in subfields)
                    {
                        context.SubfieldOfServices.Add(new SubfieldOfService()
                        {
                            Name = subfieldName,
                            ServiceId = service.Id
                        });
                    }
                }

                if (model.Files != null && model.Files.Count() > 0)
                {
                    foreach (IFormFile formFile in model.Files)
                    {
                        string generalUploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "ServicesFiles");
                        string serviceFolder = Path.Combine(generalUploadsFolder, service.Name);
                        Directory.CreateDirectory(serviceFolder);
                        string newFilePath = Path.Combine(serviceFolder, formFile.FileName);
                        var file = new FileStream(newFilePath, FileMode.Create);
                        formFile.CopyTo(file);
                        file.Close();

                        context.ServiceFiles.Add(new ServiceFile()
                        {
                            Name = Path.GetFileNameWithoutExtension(newFilePath),
                            Extention = Path.GetExtension(newFilePath),
                            Size = (int)(formFile.Length/1024),
                            ServiceId = service.Id
                        });
                    }
                }

                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Add Service";
            ViewData["Button"] = "Add";

            return View("ServicePage", model);
        }

        public IActionResult UpdateService(int id)
        {
            Service service = context.Services.Find(id);


            List<int> techIds = new List<int>();
            foreach (var item in context.TechAndServices.Where(t => t.ServiceId == service.Id))
            {
                techIds.Add(item.TechId);
            }

            List<int> industryIds = new List<int>();
            foreach (var item in context.ServiceAndIndustries.Where(s => s.ServiceId == service.Id))
            {
                industryIds.Add(item.IndustryId);
            }

            List<string> subfields = new List<string>();
            foreach (var item in context.SubfieldOfServices.Where(s => s.ServiceId == service.Id))
            {
                subfields.Add(item.Name);
            }

            ServiceModel model = new ServiceModel()
            {
                Name = service.Name,
                PageHeader = service.PageHeader,
                Intro = service.Intro,
                Description = service.Description,
                StartYourProjectUrl = service.StartYourProjectUrl,
                SubservicesHeader = service.SubservicesHeader,
                SubservicesDescription = service.SubservicesDescription,
                TechnologiesHeader = service.TechnologiesHeader,
                TechnologiesDescription = service.TechnologiesDescription,
                ApplicationHeader = service.ApplicationHeader,
                ApplicationDescription = service.ApplicationDescription,
                ProjectsHeader = service.ProjectsHeader,
                Icon = service.Icon,
                ContactHeader = service.ContactHeader,
                ContactDescription = service.ContactDescription,
                SubfieldString = String.Join(';', subfields),
                TechIds = techIds,
                IndustryIds = industryIds   
                
        };

            TempData["ServiceId"] = service.Id;
            ViewData["PageDesc"] = "Update Service";
            ViewData["Button"] = "Update";

            return View("ServicePage", model);
        }

        [HttpPost]
        public IActionResult UpdateService(ServiceModel model)
        {
            if (ModelState.IsValid)
            {
                Service service = context.Services.Find(int.Parse(TempData["ServiceId"].ToString()));
                service.Name = model.Name;
                service.PageHeader = model.PageHeader;
                service.Intro = model.Intro;
                service.Description = model.Description;
                service.StartYourProjectUrl = model.StartYourProjectUrl;
                if (model.FirstPicture != null)
                {
                    service.FirstPicture = FileHandler(model.FirstPicture, service.FirstPicture);
                }
                service.SubservicesHeader = model.SubservicesHeader;
                service.SubservicesDescription = model.SubservicesDescription;
                service.TechnologiesHeader = model.TechnologiesHeader;
                service.TechnologiesDescription = model.TechnologiesDescription;
                if (model.SecondPicture != null)
                {
                    service.SecondPicture = FileHandler(model.SecondPicture, service.SecondPicture);
                }
                service.ApplicationHeader = model.ApplicationHeader;
                service.ApplicationDescription = model.ApplicationDescription;
                service.ProjectsHeader = model.ProjectsHeader;
                if (model.CoverPicture != null)
                {
                    service.CoverPicture = FileHandler(model.CoverPicture, service.CoverPicture);
                }
                service.Icon = model.Icon;
                service.ContactHeader = model.ContactHeader;
                service.ContactDescription = model.ContactDescription;

                foreach (var techAndService in context.TechAndServices.Where(t => t.ServiceId == service.Id))
                {
                    context.TechAndServices.Remove(techAndService);
                }

                if (model.TechIds != null && model.TechIds.Count() > 0)
                {
                    foreach (int techId in model.TechIds)
                    {
                        context.TechAndServices.Add(new TechAndService()
                        {
                            ServiceId = service.Id,
                            TechId = techId
                        });
                    }
                }

                foreach (var serviceAndIndustry in context.ServiceAndIndustries.Where(s => s.ServiceId == service.Id))
                {
                    context.ServiceAndIndustries.Remove(serviceAndIndustry);
                }

                if (model.IndustryIds != null && model.IndustryIds.Count() > 0)
                {
                    foreach (int industryId in model.IndustryIds)
                    {
                        context.ServiceAndIndustries.Add(new ServiceAndIndustry()
                        {
                            ServiceId = service.Id,
                            IndustryId = industryId
                        });
                    }
                }

                foreach (var subfield in context.SubfieldOfServices.Where(s => s.ServiceId == service.Id))
                {
                    context.SubfieldOfServices.Remove(subfield);
                }

                if (model.SubfieldString != null)
                {
                    string[] subfields = model.SubfieldString.Split(';');
                    foreach (string subfieldName in subfields)
                    {
                        context.SubfieldOfServices.Add(new SubfieldOfService()
                        {
                            Name = subfieldName,
                            ServiceId = service.Id
                        });
                    }
                }

                if (model.Files != null && model.Files.Count() > 0)
                {
                    foreach (IFormFile formFile in model.Files)
                    {
                        string generalUploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "ServicesFiles");
                        string serviceFolder = Path.Combine(generalUploadsFolder, service.Name);
                        Directory.CreateDirectory(serviceFolder);
                        string newFilePath = Path.Combine(serviceFolder, formFile.FileName);
                        var file = new FileStream(newFilePath, FileMode.Create);
                        formFile.CopyTo(file);
                        file.Close();

                        context.ServiceFiles.Add(new ServiceFile()
                        {
                            Name = Path.GetFileNameWithoutExtension(newFilePath),
                            Extention = Path.GetExtension(newFilePath),
                            Size = (int)(formFile.Length / 1024),
                            ServiceId = service.Id
                        });
                    }
                }

                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Update Service";
            ViewData["Button"] = "Update";

            return View("ServicePage", model);
        }

        public IActionResult ServiceDetails(int id)
        {
            Service service = context.Services.Find(id);


            List<string> techNames = new List<string>();
            List<TechAndService> techsAndServices = 
                context.TechAndServices.Where(t => t.ServiceId == service.Id).ToList<TechAndService>();
            foreach (var item in techsAndServices)
            {
                string techName = context.Technologies.Find(item.TechId).Name;
                techNames.Add(techName);
            }

            List<string> industryNames = new List<string>();
            List<ServiceAndIndustry> servicesAndIndustries =
                context.ServiceAndIndustries.Where(s => s.ServiceId == service.Id).ToList<ServiceAndIndustry>();
            foreach (var item in servicesAndIndustries)
            {
                string industryName = context.Industries.Find(item.IndustryId).Name;
                industryNames.Add(industryName);
            }

            List<string> subfields = new List<string>();
            foreach (var item in context.SubfieldOfServices.Where(s => s.ServiceId == service.Id))
            {
                subfields.Add(item.Name);
            }

            List<string> files = new List<string>();
            foreach (var item in context.ServiceFiles.Where(s => s.ServiceId == service.Id))
            {
                files.Add(item.Name+item.Extention);
            }

            ServiceDetails model = new ServiceDetails()
            {
                Name = service.Name,
                PageHeader = service.PageHeader,
                Intro = service.Intro,
                Description = service.Description,
                StartYourProjectUrl = service.StartYourProjectUrl,
                FirstPicture = service.FirstPicture,
                SubservicesHeader = service.SubservicesHeader,
                SubservicesDescription = service.SubservicesDescription,
                TechnologiesHeader = service.TechnologiesHeader,
                TechnologiesDescription = service.TechnologiesDescription,
                ApplicationHeader = service.ApplicationHeader,
                SecondPicture = service.SecondPicture,
                ApplicationDescription = service.ApplicationDescription,
                ProjectsHeader = service.ProjectsHeader,
                CoverPicture = service.CoverPicture,
                Icon = service.Icon,
                SubfieldNames = subfields,
                TechNames = techNames,
                IndustryNames = industryNames,
                FileNames = files,
                ContactHeader = service.ContactHeader,
                ContactDescription = service.ContactDescription
            };

            TempData["ServiceId"] = service.Id;
            ViewData["PageDesc"] = "Service Details";

            return View(model);
        }

        public IActionResult DeleteService(int id)
        {
            Service service = context.Services.Find(id);

            DeleteFile(service.FirstPicture);
            DeleteFile(service.SecondPicture);
            DeleteFile(service.CoverPicture);

            var subfields = context.SubfieldOfServices.Where(s => s.ServiceId == service.Id);
            foreach (var subfield in subfields)
            {
                context.SubfieldOfServices.Remove(subfield);
            }

            var serviceAndIndustries = context.ServiceAndIndustries.Where(s => s.ServiceId == service.Id);
            foreach (var serviceAndIndustry in serviceAndIndustries)
            {
                context.ServiceAndIndustries.Remove(serviceAndIndustry);
            }

            var techAndServices = context.TechAndServices.Where(t => t.ServiceId == service.Id);
            foreach (var techAndService in techAndServices)
            {
                context.TechAndServices.Remove(techAndService);
            }

            var files = context.ServiceFiles.Where(s => s.ServiceId == service.Id);
            foreach (var file in files)
            {
                context.ServiceFiles.Remove(file);
            }

            string generalUploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "ServicesFiles");
            string serviceFolder = Path.Combine(generalUploadsFolder, service.Name);
            if (Directory.Exists(serviceFolder))
            {
                string[] filesPathes = Directory.GetFiles(serviceFolder);
                foreach (string file in filesPathes)
                {
                    System.IO.File.Delete(file);
                }
                Directory.Delete(serviceFolder);
            }

            context.Services.Remove(service);
            context.SaveChanges();

            return RedirectToAction("Services");
        }

        public IActionResult AddSubfieldForService()
        {

            ViewData["PageDesc"] = "Add Subfield of Service";
            ViewData["Button"] = "Add";

            return View("SubfieldForServicePage");
        }

        [HttpPost]
        public IActionResult AddSubfieldForService(SubfieldOfService field)
        {
            if (ModelState.IsValid)
            {
                context.SubfieldOfServices.Add(field);
                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Add Subfield of Service";
            ViewData["Button"] = "Add";

            return View("SubfieldForServicePage", field);
        }

        public IActionResult UpdateSubfieldForService(int id)
        {
            SubfieldOfService field = context.SubfieldOfServices.Find(id);

            ViewData["PageDesc"] = "Update Subfield of Service";
            ViewData["Button"] = "Update";

            return View("SubfieldForServicePage", field);
        }

        [HttpPost]
        public IActionResult UpdateSubfieldForService(SubfieldOfService model)
        {
            if (ModelState.IsValid)
            {
                SubfieldOfService field = context.SubfieldOfServices.Find(model.Id);
                field.Name = model.Name;
                field.ServiceId = model.ServiceId;

                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Update Subfield of Service";
            ViewData["Button"] = "Update";

            return View("SubfieldForServicePage", model);
        }

        public IActionResult DeleteSubfieldForService(int id)
        {
            SubfieldOfService field = context.SubfieldOfServices.Find(id);
            context.SubfieldOfServices.Remove(field);
            context.SaveChanges();

            return RedirectToAction("Services");
        }

        public IActionResult DeleteFileForService(int id)
        {
            ServiceFile file = context.ServiceFiles.Find(id);
            Service parentService = context.Services.Find(file.ServiceId);
            string filename = file.Name + file.Extention;
            string generalUploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "ServicesFiles");
            string serviceFolder = Path.Combine(generalUploadsFolder, parentService.Name);
            string filePath = Path.Combine(serviceFolder, filename);
            System.IO.File.Delete(filePath);

            context.ServiceFiles.Remove(file);
            context.SaveChanges();

            return RedirectToAction("Services");
        }

        public IActionResult AddSubserviceForService()
        {

            ViewData["PageDesc"] = "Add Subservice of Service";
            ViewData["Button"] = "Add";

            return View("SubserviceForServicePage");
        }

        [HttpPost]
        public IActionResult AddSubserviceForService(Subservice subservice)
        {
            if (ModelState.IsValid)
            {
                context.Subservices.Add(subservice);
                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Add Subservice of Service";
            ViewData["Button"] = "Add";

            return View("SubserviceForServicePage", subservice);
        }

        public IActionResult UpdateSubserviceForService(int id)
        {
            Subservice subservice = context.Subservices.Find(id);

            ViewData["PageDesc"] = "Update Subservice of Service";
            ViewData["Button"] = "Update";

            return View("SubserviceForServicePage", subservice);
        }

        [HttpPost]
        public IActionResult UpdateSubserviceForService(Subservice model)
        {
            if (ModelState.IsValid)
            {
                Subservice subservice = context.Subservices.Find(model.Id);
                subservice.Name = model.Name;
                subservice.ServiceId = model.ServiceId;
                subservice.Description = model.Description;
                subservice.Type = model.Type;
                subservice.Url = model.Url;

                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Update Subservice of Service";
            ViewData["Button"] = "Update";

            return View("SubserviceForServicePage", model);
        }

        public IActionResult DeleteSubserviceForService(int id)
        {
            Subservice subservice = context.Subservices.Find(id);
            context.Subservices.Remove(subservice);
            context.SaveChanges();

            return RedirectToAction("Services");
        }

        public IActionResult AddIndustry()
        {

            ViewData["PageDesc"] = "Add Industry";
            ViewData["Button"] = "Add";

            return View("IndustryPage");
        }

        [HttpPost]
        public IActionResult AddIndustry(Industry industry)
        {
            if (ModelState.IsValid)
            {
                context.Industries.Add(industry);
                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Add Industry";
            ViewData["Button"] = "Add";

            return View("IndustryPage", industry);
        }

        public IActionResult UpdateIndustry(int id)
        {
            Industry industry = context.Industries.Find(id);

            ViewData["PageDesc"] = "Update Industry";
            ViewData["Button"] = "Update";

            return View("IndustryPage", industry);
        }

        [HttpPost]
        public IActionResult UpdateIndustry(Industry model)
        {
            if (ModelState.IsValid)
            {
                Industry industry = context.Industries.Find(model.Id);
                industry.Name = model.Name;
                industry.Description = model.Description;
                industry.Icon = model.Icon;

                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Update Industry";
            ViewData["Button"] = "Update";

            return View("IndustryPage", model);
        }

        public IActionResult DeleteIndustry(int id)
        {
            Industry industry = context.Industries.Find(id);
            context.Industries.Remove(industry);
            context.SaveChanges();

            return RedirectToAction("Services");
        }

        public IActionResult AddServiceAndIndustry()
        {

            ViewData["PageDesc"] = "Add Service And Industry";
            ViewData["Button"] = "Add";

            return View("ServiceAndIndustryPage");
        }

        [HttpPost]
        public IActionResult AddServiceAndIndustry(ServiceAndIndustry serviceAndIndustry)
        {
            if (ModelState.IsValid)
            {
                context.ServiceAndIndustries.Add(serviceAndIndustry);
                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Add Service And Industry";
            ViewData["Button"] = "Add";

            return View("ServiceAndIndustryPage", serviceAndIndustry);
        }

        public IActionResult UpdateServiceAndIndustry(int id)
        {
            ServiceAndIndustry serviceAndIndustry = context.ServiceAndIndustries.Find(id);

            ViewData["PageDesc"] = "Update Service And Industry";
            ViewData["Button"] = "Update";

            return View("ServiceAndIndustryPage", serviceAndIndustry);
        }

        [HttpPost]
        public IActionResult UpdateServiceAndIndustry(ServiceAndIndustry model)
        {
            if (ModelState.IsValid)
            {
                ServiceAndIndustry serviceAndIndustry = context.ServiceAndIndustries.Find(model.Id);
                serviceAndIndustry.IndustryId = model.IndustryId;
                serviceAndIndustry.ServiceId = model.ServiceId;

                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Update Service And Industry";
            ViewData["Button"] = "Update";

            return View("ServiceAndIndustryPage", model);
        }

        public IActionResult DeleteServiceAndIndustry(int id)
        {
            ServiceAndIndustry serviceAndIndustry = context.ServiceAndIndustries.Find(id);
            context.ServiceAndIndustries.Remove(serviceAndIndustry);
            context.SaveChanges();

            return RedirectToAction("Services");
        }

        public IActionResult AddTech()
        {

            ViewData["PageDesc"] = "Add Technology";
            ViewData["Button"] = "Add";

            return View("TechPage");
        }

        [HttpPost]
        public IActionResult AddTech(Technology tech)
        {
            if (ModelState.IsValid)
            {
                context.Technologies.Add(tech);
                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Add Technology";
            ViewData["Button"] = "Add";

            return View("TechPage", tech);
        }

        public IActionResult UpdateTech(int id)
        {
            Technology tech = context.Technologies.Find(id);

            ViewData["PageDesc"] = "Update Technology";
            ViewData["Button"] = "Update";

            return View("TechPage", tech);
        }

        [HttpPost]
        public IActionResult UpdateTech(Technology model)
        {
            if (ModelState.IsValid)
            {
                Technology tech = context.Technologies.Find(model.Id);
                tech.Name = model.Name;
                tech.Picture = model.Picture;

                context.SaveChanges();
                return RedirectToAction("Services");
            }

            ViewData["PageDesc"] = "Update Technology";
            ViewData["Button"] = "Update";

            return View("TechPage", model);
        }

        public IActionResult DeleteTech(int id)
        {
            Technology tech = context.Technologies.Find(id);
            context.Technologies.Remove(tech);
            context.SaveChanges();

            return RedirectToAction("Services");
        }

        // Projects Page
        public IActionResult Projects()
        {
            AdminProjects projectsPage = new AdminProjects()
            {
                Projects = context.Projects,
                StepsOfProjects = context.StepOfProjects.OrderBy(s => s.Project)
            };

            return View(projectsPage);
        }

        public IActionResult AddProject()
        {
            ProjectModel model = new ProjectModel();

            ViewData["PageDesc"] = "Add Project";
            ViewData["Button"] = "Add";

            return View("ProjectPage", model);
        }

        [HttpPost]
        public IActionResult AddProject(ProjectModel model)
        {
            if (model.CoverPicture == null)
            {
                ModelState.AddModelError("CoverPicture", "Cover Picture is required");
            }
            if (ModelState.IsValid)
            {
                Project project = new Project();
                project.ClientId = model.ClientId;
                project.Name = model.Name;
                project.PageHeader = model.PageHeader;
                project.IndustyId = model.IndustyId;
                project.Industy = context.Industries.Find(model.IndustyId);
                project.TimePeriod = model.TimePeriod;
                project.Website = model.Website;
                project.Header = model.Header;
                project.Description = model.Description;
                project.Challenge = model.Challenge;
                project.Solution = model.Solution;
                project.CoverPicture = FileHandler(model.CoverPicture, project.CoverPicture);
                if (model.PagePicture != null)
                {
                    project.PagePicture = FileHandler(model.PagePicture, project.PagePicture);
                }
                project.ProcessDescription = model.ProcessDescription;
                project.ResultDescription = model.ResultDescription;

                context.Projects.Add(project);
                context.SaveChanges();

                if (model.ProjectMembers != null && model.ProjectMembers.Count() > 0)
                {
                    foreach (int memberId in model.ProjectMembers)
                    {
                        context.ProjectAndMembers.Add(new ProjectAndMember()
                        {
                            ProjectId = project.Id,
                            MemberId = memberId
                        });
                    }
                }

                if (model.ProjectTeches != null && model.ProjectTeches.Count() > 0)
                {
                    foreach (int techId in model.ProjectTeches)
                    {
                        context.ProjectAndTeches.Add(new ProjectAndTech()
                        {
                            ProjectId = project.Id,
                            TechId = techId
                        });
                    }
                }

                context.SaveChanges();
                return RedirectToAction("Projects");
            }

            ViewData["PageDesc"] = "Add Project";
            ViewData["Button"] = "Add";

            return View("ProjectPage", model);
        }

        public IActionResult UpdateProject(int id)
        {
            Project project = context.Projects.Find(id);


            List<int> techIds = new List<int>();
            foreach (var item in context.ProjectAndTeches.Where(t => t.ProjectId == project.Id))
            {
                techIds.Add(item.TechId);
            }

            List<int> membersIds = new List<int>();
            foreach (var item in context.ProjectAndMembers.Where(p => p.ProjectId == project.Id))
            {
                membersIds.Add(item.MemberId);
            }

            ProjectModel model = new ProjectModel()
            {
                ClientId = project.ClientId,
                Name = project.Name,
                PageHeader = project.PageHeader,
                IndustyId = project.IndustyId,
                TimePeriod = project.TimePeriod,
                Website = project.Website,
                Header = project.Header,
                Description = project.Description,
                Challenge = project.Challenge,
                Solution = project.Solution,
                ProcessDescription = project.ProcessDescription,
                ResultDescription = project.ResultDescription,
                ProjectTeches = techIds,
                ProjectMembers = membersIds

        };

            TempData["ProjectId"] = project.Id;
            ViewData["PageDesc"] = "Update Project";
            ViewData["Button"] = "Update";

            return View("ProjectPage", model);
        }

        [HttpPost]
        public IActionResult UpdateProject(ProjectModel model)
        {
            if (ModelState.IsValid)
            {
                Project project = context.Projects.Find(int.Parse(TempData["ProjectId"].ToString()));
                project.ClientId = model.ClientId;
                project.Name = model.Name;
                project.PageHeader = model.PageHeader;
                project.IndustyId = model.IndustyId;
                project.TimePeriod = model.TimePeriod;
                project.Website = model.Website;
                project.Header = model.Header;
                project.Description = model.Description;
                project.Challenge = model.Challenge;
                project.Solution = model.Solution;
                if (model.CoverPicture != null)
                {
                    project.CoverPicture = FileHandler(model.CoverPicture, project.CoverPicture);
                }
                if (model.PagePicture != null)
                {
                    project.PagePicture = FileHandler(model.PagePicture, project.PagePicture);
                }
                project.ProcessDescription = model.ProcessDescription;
                project.ResultDescription = model.ResultDescription;

                foreach (var projectAndTech in context.ProjectAndTeches.Where(p => p.ProjectId == project.Id))
                {
                    context.ProjectAndTeches.Remove(projectAndTech);
                }

                if (model.ProjectTeches != null && model.ProjectTeches.Count() > 0)
                {
                    foreach (int techId in model.ProjectTeches)
                    {
                        context.ProjectAndTeches.Add(new ProjectAndTech()
                        {
                            ProjectId = project.Id,
                            TechId = techId
                        });
                    }
                }

                foreach (var projAndMember in context.ProjectAndMembers.Where(p => p.ProjectId == project.Id))
                {
                    context.ProjectAndMembers.Remove(projAndMember);
                }

                if (model.ProjectMembers != null && model.ProjectMembers.Count() > 0)
                {
                    foreach (int memberId in model.ProjectMembers)
                    {
                        context.ProjectAndMembers.Add(new ProjectAndMember()
                        {
                            ProjectId = project.Id,
                            MemberId = memberId
                        });
                    }
                }

                context.SaveChanges();
                return RedirectToAction("Projects");
            }

            ViewData["PageDesc"] = "Update Project";
            ViewData["Button"] = "Update";

            return View("ProjectPage", model);
        }

        public IActionResult ProjectDetails(int id)
        {
            Project project = context.Projects.Find(id);


            List<string> techNames = new List<string>();
            List<ProjectAndTech> projectsAndTeches =
                context.ProjectAndTeches.Where(p => p.ProjectId == project.Id).ToList<ProjectAndTech>();
            foreach (var item in projectsAndTeches)
            {
                string techName = context.Technologies.Find(item.TechId).Name;
                techNames.Add(techName);
            }

            List<string> membersNames = new List<string>();
            List<ProjectAndMember> projectsAndMembers =
                context.ProjectAndMembers.Where(p => p.ProjectId == project.Id).ToList<ProjectAndMember>();
            foreach (var item in projectsAndMembers)
            {
                string memberName = context.TeamMembers.Find(item.MemberId).Fullname;
                membersNames.Add(memberName);
            }

            ProjectDetails model = new ProjectDetails()
            {
                ClientName = context.Clients.Find(project.ClientId).Name,
                Name = project.Name,
                PageHeader = project.PageHeader,
                IndustyName = context.Industries.Find(project.IndustyId).Name,
                TimePeriod = project.TimePeriod,
                Website = project.Website,
                Header = project.Header,
                Description = project.Description,
                Challenge = project.Challenge,
                Solution = project.Solution,
                CoverPicture = project.CoverPicture,
                PagePicture = project.PagePicture,
                ProcessDescription = project.ProcessDescription,
                ResultDescription = project.ResultDescription,
                ProjectTeches = techNames,
                ProjectMembers = membersNames
            };

            TempData["ProjectId"] = project.Id;
            ViewData["PageDesc"] = "Project Details";

            return View(model);
        }

        public IActionResult DeleteProject(int id)
        {
            Project project = context.Projects.Find(id);

            DeleteFile(project.CoverPicture);
            DeleteFile(project.PagePicture);

            var projectsAndMembers = context.ProjectAndMembers.Where(p => p.ProjectId == project.Id);
            foreach (var projectAndMember in projectsAndMembers)
            {
                context.ProjectAndMembers.Remove(projectAndMember);
            }

            var projectsAndTeches = context.ProjectAndTeches.Where(p => p.ProjectId == project.Id);
            foreach (var projectAndTech in projectsAndTeches)
            {
                context.ProjectAndTeches.Remove(projectAndTech);
            }

            context.Projects.Remove(project);
            context.SaveChanges();

            return RedirectToAction("Projects");
        }

        public IActionResult AddProjectStep()
        {

            ViewData["PageDesc"] = "Add Project Step";
            ViewData["Button"] = "Add";

            return View("ProjectStepPage");
        }

        [HttpPost]
        public IActionResult AddProjectStep(ProjectStepModel model)
        {
            if (model.Picture == null)
            {
                ModelState.AddModelError("Picture", "Picture is required");
            }
            if (ModelState.IsValid)
            {
                StepOfProject step = new StepOfProject();
                step.Name = model.Name;
                step.Description = model.Description;
                step.Picture = FileHandler(model.Picture, step.Picture);
                step.ProjectId = model.ProjectId;

                context.StepOfProjects.Add(step);
                context.SaveChanges();
                return RedirectToAction("Projects");
            }

            ViewData["PageDesc"] = "Add Project Step";
            ViewData["Button"] = "Add";

            return View("ProjectStepPage", model);
        }

        public IActionResult UpdateProjectStep(int id)
        {
            StepOfProject step = context.StepOfProjects.Find(id);

            ProjectStepModel model = new ProjectStepModel()
            {
                Name = step.Name,
                Description = step.Description,
                ProjectId = step.ProjectId
            };

            TempData["StepId"] = id;
            ViewData["PageDesc"] = "Update Project Step";
            ViewData["Button"] = "Update";

            return View("ProjectStepPage", model);
        }

        [HttpPost]
        public IActionResult UpdateProjectStep(ProjectStepModel model)
        {
            if (ModelState.IsValid)
            {
                StepOfProject step = context.StepOfProjects.Find(int.Parse(TempData["StepId"].ToString()));
                step.Name = model.Name;
                step.Description = model.Description;
                if (model.Picture != null)
                {
                    step.Picture = FileHandler(model.Picture, step.Picture);
                }
                step.ProjectId = model.ProjectId;

                context.SaveChanges();
                return RedirectToAction("Projects");
            }

            ViewData["PageDesc"] = "Update Project Step";
            ViewData["Button"] = "Update";

            return View("ProjectStepPage", model);
        }

        public IActionResult DeleteProjectStep(int id)
        {
            StepOfProject step = context.StepOfProjects.Find(id);
            DeleteFile(step.Picture);
            context.StepOfProjects.Remove(step);
            context.SaveChanges();

            return RedirectToAction("Projects");
        }

    }
}
