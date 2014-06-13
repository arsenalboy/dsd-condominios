using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Messaging;
using Architecs.Test.Entidades;

namespace Architecs.Test
{
    /// <summary>
    /// Descripción resumida de TestQuejaMessage
    /// </summary>
    [TestClass]
    public class TestQuejaMessage
    {

        [TestMethod]
        public void MensajeEncola()
        {
            //guardamos los mensajes en cola si ocurre error
            string rutaCola = @".\private$\queja";
            if (!MessageQueue.Exists(rutaCola))
            {
                MessageQueue.Create(rutaCola);
            }
            MessageQueue cola = new MessageQueue(rutaCola);
            Message mensaje = new Message();
            mensaje.Label = "Queja registrada con fecha " + DateTime.Now.ToShortDateString();
            mensaje.Body = new  Queja()
            {
                N_IdResidente = 2,
                B_Estado = false,
                C_Detalle = "detalle",
                C_Motivo = "motivo",
                C_Tipo = "Grave",
                D_FecQueja = "2014-06-12",
                D_FecRegistro = new DateTime(10,10,10,10,10,10)
            };
            cola.Send(mensaje);
            
            //recuperamos el mensaje
            MessageQueue cola2 = new MessageQueue(rutaCola);

            int cantidadmensajes = 0;

            if (MessageQueue.Exists(rutaCola))
            {
                cantidadmensajes = cola2.GetAllMessages().Count();
                //recorrer y grabar
                foreach (Message mensajeTodo in cola2.GetAllMessages())
                {
                    mensajeTodo.Formatter = new XmlMessageFormatter(new Type[] { typeof(Queja) });
                    Queja ObjQueja = (Queja)mensajeTodo.Body;
                    //buscamos el que se envio
                    if (ObjQueja.N_IdResidente == 2 & ObjQueja.D_FecQueja == "2014-06-12")
                    {
                        Assert.AreEqual(false, ObjQueja.B_Estado);
                        Assert.AreEqual("detalle", ObjQueja.C_Detalle);
                        Assert.AreEqual("motivo", ObjQueja.C_Motivo);
                        Assert.AreEqual("Grave", ObjQueja.C_Tipo);
                        Assert.AreEqual(new DateTime(10, 10, 10, 10, 10, 10), ObjQueja.D_FecRegistro);
                        cola2.Receive();
                        break;
                    }

                }
                
                //se elimina los mensajes

                MessageQueue.Delete(rutaCola);
            }
            Assert.AreNotEqual(0, cantidadmensajes);
        }
    }
}
