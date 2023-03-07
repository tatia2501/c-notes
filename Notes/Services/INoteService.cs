﻿using System.Collections.Generic;
using Notes.Entities;

namespace Notes.Services
{
    public interface INoteService
    {
        List<NoteModel> GetInitialNotes();
        NoteModel GetNote(int id);
        void InsertNewNote(string title, string text);
    }
}