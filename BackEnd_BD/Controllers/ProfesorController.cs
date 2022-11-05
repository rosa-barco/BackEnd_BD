using BackEnd_BD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd_BD.Controllers
{
    public class ProfesorController : Controller
    {
        // GET: Profesor
        public ActionResult Index()
        {
            using (AlumnoDBContext dbProfes = new AlumnoDBContext())
            {
                return View(dbProfes.Profesor.ToList());
            }
        }

        public ActionResult Details(int id)
        {
            using (AlumnoDBContext dbProfes = new AlumnoDBContext())
            {
                Profesor profes = dbProfes.Profesor.Find(id);
                if (profes == null)
                {
                    return HttpNotFound();
                }

                return View(profes);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Profesor profe)
        {
            using (AlumnoDBContext dbProfe = new AlumnoDBContext())
            {
                dbProfe.Profesor.Add(profe);
                dbProfe.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            using (AlumnoDBContext dbProfe = new AlumnoDBContext())
            {
                return View(dbProfe.Profesor.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        [HttpPost]
        public ActionResult Edit(Profesor prof)
        {
            using (AlumnoDBContext dbProfe = new AlumnoDBContext())
            {
                dbProfe.Entry(prof).State = EntityState.Modified;
                dbProfe.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            using (AlumnoDBContext dbProfe = new AlumnoDBContext())
            {
                return View(dbProfe.Profesor.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        [HttpPost]
        public ActionResult Delete(Profesor prof, int id)
        {
            using (AlumnoDBContext dbProfe = new AlumnoDBContext())
            {
                Profesor al = dbProfe.Profesor.Where(x => x.Id == id).FirstOrDefault();
                dbProfe.Profesor.Remove(al);
                dbProfe.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}