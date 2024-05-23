using BeautySalonManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BeautySalonManager.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BeautySalonContext context)
        {
            context.Database.EnsureCreated(); // Asegura que la base de datos haya sido creada

            // Busca si hay algún servicio en la base de datos
            if (context.Servicios.Any())
            {
                return; // La base de datos ya ha sido inicializada
            }

            var servicios = new Servicio[]
            {
                new Servicio { Nombre = "Corte de cabello", Descripcion = "Corte de cabello estándar", Precio = 20, DuracionEstimada = TimeSpan.FromMinutes(30) },
                new Servicio { Nombre = "Manicura", Descripcion = "Cuidado y embellecimiento de las uñas", Precio = 15, DuracionEstimada = TimeSpan.FromMinutes(45) },
                // Agrega más servicios aquí si es necesario
            };

            foreach (Servicio s in servicios)
            {
                context.Servicios.Add(s);
            }

            context.SaveChanges(); // Guarda los cambios en la base de datos
        }
    }
}
