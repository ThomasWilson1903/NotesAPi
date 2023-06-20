using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NotesDomain;


namespace NotesApplication.Notes.Commands.CreateNote
{
    class CreateNoteCommandHandler
    : IRequestHandler<CreateNoteCommand, Guid>
    {
        public async Task<Guid> Handler(CreateNoteCommand request,
            CancellationToken cancellationToken)
        {
            var note = new Note
            {
                UserId = request.UserId,
                Title = request.Title,
                Detailse = request.Details,
                Id = Guid.NewGuid(),
                CreationDate = DateTime.Now,
                EdirDate = null
            };

            return note.Id;
        }
    }



}
