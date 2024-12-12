using ApiHollowKnight.Repositories.Interfaces;

namespace ApiHollowKnight.Repositories.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICharactersRepository _characterRepo;

        private ICharacterSpeciesRepository _characterSpeciesRepo;

        private ICharacterTypeRepository _characterTypeRepo;

        private IPlacesRepository _placesRepo;
        public AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public ICharactersRepository CharacterRepository
        {
            get 
            { 
                return _characterRepo = _characterRepo ?? new CharacterRepository(_context); 
            }
        }

        public ICharacterSpeciesRepository CharacterSpeciesRepository
        {
            get
            {
                return _characterSpeciesRepo = _characterSpeciesRepo ?? new CharacterSpeciesRepository(_context);
            }
        }

        public ICharacterTypeRepository CharacterTypeRepository
        {
            get
            {
                return _characterTypeRepo = _characterTypeRepo ?? new CharacterTypeRepository(_context);
            }
        }

        public IPlacesRepository PlacesRepository
        {
            get
            {
                return _placesRepo = _placesRepo ?? new PlacesRepository(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}