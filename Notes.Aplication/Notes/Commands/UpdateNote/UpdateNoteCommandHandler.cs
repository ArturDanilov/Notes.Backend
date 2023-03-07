using MediatR;
using Notes.Aplication.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Notes.Aplication.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommandHandler : IRequestHandler<UpdateNoteCommand>
    {
        private readonly INotesDbContext _dbContext;
        public UpdateNoteCommandHandler(INotesDbContext dbContext) => 
            _dbContext = dbContext;
        public async Task<Unit> Handle(UpdateNoteCommand request, 
            CancellationToken cancellationToken)
        {
            var entity = 
                await _dbContext.Notes.FirstOrDefaultAsync(note => 
                note.Id == request.Id, cancellationToken);

            if (entity == null || entity.UserId != request.UserId)
            {
                throw new Exception("Note not found");
            }
            return Unit.Value;
        }
    }
}
