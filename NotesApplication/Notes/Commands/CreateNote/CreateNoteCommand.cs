using MediatR;

namespace NotesApplication.Notes.Commands.CreateNote
{
    internal class CreateNoteCommand: IRequest<Guid>
    {
    }
}
