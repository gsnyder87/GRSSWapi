using SWapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SWapi;
public class Core
{
    private readonly Repository<Vehicle> _vehicleRepository;
    private readonly Repository<Film> _filmRepository;
    private readonly Repository<Planet> _PlanetRepository;

    public Core()
    {
        _vehicleRepository = new Repository<Vehicle>();
        _filmRepository = new Repository<Film>();
        _PlanetRepository = new Repository<Planet>();
    }

    public async Task<ICollection<Vehicle>> GetVehicles(int size = 10)
    {
        var results = await _vehicleRepository.GetEntities(size: size);
        return results;
    }

    public async Task<Vehicle> GetVehicle(int id)
    {
        var results = await _vehicleRepository.GetById(id);
        return results;
    }

    public async Task<ICollection<Film>> GetFilms(int size = 10)
    {
        var results = await _filmRepository.GetEntities(size: size);
        return results;
    }

    public async Task<Film> GetFilm(int id)
    {
        var results = await _filmRepository.GetById(id);
        return results;
    }

    public async Task<ICollection<Planet>> GetPlanets(int size = 10)
    {
        var results = await _PlanetRepository.GetEntities(size: size);
        return results;
    }

    public async Task<Planet> GetPlanet(int id)
    {
        var results = await _PlanetRepository.GetById(id);
        return results;
    }
}
