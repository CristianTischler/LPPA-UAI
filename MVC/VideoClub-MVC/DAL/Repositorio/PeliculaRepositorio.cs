using System;
using BE;
using DAL.DataContext;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
    public class PeliculaRepositorio : IGenericRepository<Pelicula>
    {
        private readonly VideoclubLppaContext _dBVideoClub_LPPA;
        public PeliculaRepositorio(VideoclubLppaContext context)
        {
            _dBVideoClub_LPPA = context;
        }
        public async Task<bool> Actualizar(Pelicula modelo)
        {
            _dBVideoClub_LPPA.Peliculas.Update(modelo);
            await _dBVideoClub_LPPA.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Pelicula modelo = _dBVideoClub_LPPA.Peliculas.First(p => p.Id == id);
            _dBVideoClub_LPPA.Peliculas.Remove(modelo);
            await _dBVideoClub_LPPA.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Pelicula modelo)
        {
            _dBVideoClub_LPPA.Peliculas.Add(modelo);
            await _dBVideoClub_LPPA.SaveChangesAsync();
            return true;
        }

        public async Task<Pelicula> ObtenerUno(int id)
        {
            return await _dBVideoClub_LPPA.Peliculas.FindAsync(id);
        }

        public async Task<IQueryable<Pelicula>> ObtenerTodos()
        {
            IQueryable<Pelicula> peliculas = _dBVideoClub_LPPA.Peliculas;
            return peliculas;
        }
    }
}
