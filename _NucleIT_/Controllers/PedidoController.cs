using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _NucleIT_.Controllers
{
    public class PedidoController : Controller
    {
        // GET: Pedido
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pedido/Details/5
        public ActionResult Details(int id)
        {
            
            using (pedidosEntities pedidosEntities = new pedidosEntities())
            {
               
                List<Items> listado = new List<Items>();
                
                try
                {
                    var q = pedidosEntities.Pedido.Join(pedidosEntities.Cliente, dir => dir.ID_Cliente,
                        per => per.ID, (dir, per) => new { dir, per }).Join(pedidosEntities.Mozo, dir =>dir.dir.ID_Mozo,
                        moz => moz.ID,(dir,moz) =>new { dir,moz}).FirstOrDefault(x => x.dir.dir.ID == id);

                    var p = pedidosEntities.PedidoProducto.Join(pedidosEntities.Pedido, pp => pp.ID_Pedido,
                        pro => pro.ID, (pp, pro) => new { pp, pro }).Join(pedidosEntities.Producto, item => item.pp.ID_Producto,
                        _item => _item.ID, (item,_item) => new {item,_item }).Where(x=>x.item.pp.ID_Pedido == id);
                    foreach (var item in p)
                    {
                        Items aux = new Items(item._item.Precio, item.item.pp.Cantidad);
                        //aux.Cantidad = item.item.pp.Cantidad;
                        aux.Nombre = item._item.Nombre;
                        //aux.Precio = item._item.Precio;
                        listado.Add(aux);

                    }
                    PedidoFinal pedidoFinal = new PedidoFinal(listado);
                    pedidoFinal.numero = q.dir.dir.ID;
                    pedidoFinal.Cliente = q.dir.per.Nombre;
                    pedidoFinal.Mozo = q.moz.Nombre;
                    //pedidoFinal.Productos = listado;
                    pedidoFinal.Fecha = q.dir.dir.Fecha.ToString();
                    return Json(pedidoFinal, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(ex.Message, JsonRequestBehavior.AllowGet);
                    throw;
                }
            }
            
        }

        // GET: Pedido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pedido/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedido/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pedido/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedido/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pedido/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
