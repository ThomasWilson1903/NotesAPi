using System;
using MediatR;

namespace NotesApplication.Notes.Commands.CreateNote
{
    internal class CreateNoteCommand: IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public String Title { get; set; }
        public String Details { get; set; }
    }
}
