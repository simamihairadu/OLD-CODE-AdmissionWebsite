﻿using AdmissionWebsiteFinal.Data;
using AdmissionWebsiteFinal.Models;
using AdmissionWebsiteFinal.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Controllers
{
    [Authorize]
    public class SessionController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public SessionController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var sessionList = mapper.Map<List<SessionViewModel>>(unitOfWork.Sessions.GetAll());
            return View(sessionList);
        }

        public ActionResult Create()
        {
            if (unitOfWork.Sessions.IsAnyActive())
            {
                ModelState.AddModelError("Active", "Can't have more than one active session.");
                var sessionList = mapper.Map<List<SessionViewModel>>(unitOfWork.Sessions.GetAll());
                return View("Index", sessionList);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SessionViewModel sessionViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create");
                }
                var session = mapper.Map<Session>(sessionViewModel);
                unitOfWork.Sessions.Add(session);
                unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                var session = unitOfWork.Sessions.Get(id);
                unitOfWork.Sessions.Remove(session);
                unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            var session = mapper.Map<SessionViewModel>(unitOfWork.Sessions.Get(id));
            var options = mapper.Map<IEnumerable<OptionViewModel>>(unitOfWork.Options.GetOptionsBySessionId(id));
            foreach (var option in options)
            {
                option.Name = unitOfWork.Specializations.GetNameById(option.SpecializationId);
            }
            session.Options = options;
            return View(session);
        }

        public ActionResult AddOption()
        {
            var specializations = mapper.Map<IEnumerable<SpecializationViewModel>>(unitOfWork.Specializations.GetAll());
            var option = new OptionViewModel
            {
                Specializations = specializations
            };
            return View(option);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddOption(OptionViewModel optionViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("AddOption");
                }
                var option = mapper.Map<Option>(optionViewModel);
                var session = unitOfWork.Sessions.GetActiveSession();
                option.SessionId = session.Id;
                unitOfWork.Options.Add(option);
                unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                var specializations = mapper.Map<IEnumerable<SpecializationViewModel>>(unitOfWork.Specializations.GetAll());
                var option = new OptionViewModel
                {
                    Specializations = specializations
                };
                return View(option);
            }
        }

        public ActionResult End(int id)
        {
            var session = unitOfWork.Sessions.Get(id);

            session.Active = false;
            unitOfWork.Sessions.Update(session);
            unitOfWork.Complete();

            var sessionList = mapper.Map<List<SessionViewModel>>(unitOfWork.Sessions.GetAll());

            return View("Index", sessionList);
        }
    }
}
