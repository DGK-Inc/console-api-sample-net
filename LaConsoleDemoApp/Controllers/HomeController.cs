using LaConsoleDemoApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace LaConsoleDemoApp.Controllers
{
    public class HomeController : Controller
    {
        const string Secret = "your-secret-here";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [EnableCors("*", "*", "*")]
        public ActionResult Endpoint()
        {
            Stream req = Request.InputStream;
            req.Seek(0, System.IO.SeekOrigin.Begin);

            string json = new StreamReader(req).ReadToEnd();

            Obituary obituary = JsonConvert.DeserializeObject<Obituary>(json);

            // Vérifier si les secrets match
            if (obituary.Secret == Secret)
            {
                // Enregistre l'image
                if (!string.IsNullOrEmpty(obituary.Picture))
                {
                    // Retire le prefix
                    string base64 = obituary.Picture.Split(',')[1];
                    // Convertir en array de bytes
                    byte[] bytes = Convert.FromBase64String(base64);

                    // Convertir les bytes en objet Image.
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        using (Image image = Image.FromStream(ms))
                        {
                            // Sauvegarde de l'image
                            string fileName = Guid.NewGuid().ToString().Replace("-", "") + ".jpg"; // Nom aléatoire.
                            string path = Server.MapPath("~/Content/images/" + fileName); // Chemin de l'image
                            image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }
                }

                // TODO : Enregistrer l'avis dans votre base de données.

                // Changer l'adresse de retour par une vraie adresse généré dans votre système.
                return Content("https://www.example.com/obituary/john-doe");
            }

            // Retourne rien si c'est pas valide.
            return new EmptyResult();
        }
    }
}